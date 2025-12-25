using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Tsjy.Application.System.Dtos.InspectionDtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Entities;
namespace Tsjy.Application.System.Service
{
    

    public class InspectionService : IInspectionService, ITransient, IScoped
    {
        private readonly IRepository<InspectionLog> _logRepo;
        private readonly IRepository<InspectionSchedule> _scheduleRepo;
        private readonly IRepository<InspectionTeamMember> _memberRepo;
        private readonly IRepository<InspectionTeam> _teamRepo;
        private readonly IRepository<Tasks> _taskRepo;
        private readonly IRepository<Departments> _deptRepo;

        public InspectionService(
          IRepository<InspectionLog> logRepo,
        IRepository<InspectionSchedule> scheduleRepo,
        IRepository<InspectionTeamMember> memberRepo,
        IRepository<InspectionTeam> teamRepo,
        IRepository<Tasks> taskRepo,
        IRepository<Departments> deptRepo)
        {
            _logRepo = logRepo;
            _scheduleRepo = scheduleRepo;
            _memberRepo = memberRepo;
            _teamRepo = teamRepo;
            _taskRepo = taskRepo;
            _deptRepo = deptRepo;
        }
        /// <summary>
        /// 获取当前视导员的任务列表 (逻辑：User -> TeamMember -> Team -> Schedule)
        /// </summary>
        public async Task<List<InspectorTaskDto>> GetMyInspectionsAsync(string userId)
        {
            // 1. 找出该用户所在的所有小组ID
            var myTeamIds = await _memberRepo.AsQueryable()
                .Where(m => m.UserId == userId && !m.IsDeleted)
                .Select(m => m.TeamId)
                .ToListAsync();

            if (!myTeamIds.Any()) return new List<InspectorTaskDto>();

            // 2. 找出这些小组负责的视导行程
            var query = from s in _scheduleRepo.AsQueryable()
                        join t in _teamRepo.AsQueryable() on s.TeamId equals t.Id
                        join task in _taskRepo.AsQueryable() on s.AssignmentId equals task.Id
                        join d in _deptRepo.AsQueryable() on task.TargetId equals d.Id.ToString() // 假设 TargetId 存的是 Dept Id
                        where myTeamIds.Contains(s.TeamId) && !s.IsDeleted
                        orderby s.VisitStartAt descending
                        select new InspectorTaskDto
                        {
                            ScheduleId = s.Id,
                            TaskId = task.Id,
                            TaskName = task.Name,
                            SchoolName = d.Name,
                            TeamName = t.Name,
                            StartDate = s.VisitStartAt,
                            EndDate = s.VisitEndAt,
                            Status = s.Status
                        };

            return await query.ToListAsync();
        }

        /// <summary>
        /// 获取某次行程、某个指标的已保存记录
        /// </summary>
        public async Task<InspectionLogInputDto> GetNodeLogAsync(long scheduleId, long nodeId)
        {
            var log = await _logRepo.FirstOrDefaultAsync(x => x.ScheduleId == scheduleId && x.NodeId == nodeId && !x.IsDeleted);

            if (log == null)
            {
                return new InspectionLogInputDto
                {
                    ScheduleId = scheduleId,
                    NodeId = nodeId,
                    FileUrls = new List<string>()
                };
            }

            var files = string.IsNullOrEmpty(log.EvidenceFiles)
                ? new List<string>()
                : JsonSerializer.Deserialize<List<string>>(log.EvidenceFiles);

            return new InspectionLogInputDto
            {
                ScheduleId = scheduleId,
                NodeId = nodeId,
                Findings = log.Findings,
                FileUrls = files ?? new List<string>()
            };
        }

        /// <summary>
        /// 保存现场记录和素材
        /// </summary>
        public async Task SaveNodeLogAsync(InspectionLogInputDto input, string userId)
        {
            // 检查是否已存在记录
            var log = await _logRepo.FirstOrDefaultAsync(x => x.ScheduleId == input.ScheduleId && x.NodeId == input.NodeId);

            if (log == null)
            {
                // 新增
                log = new InspectionLog
                {
                    ScheduleId = input.ScheduleId,
                    NodeId = input.NodeId,
                    Findings = input.Findings,
                    EvidenceFiles = JsonSerializer.Serialize(input.FileUrls),
                    CreatedBy = long.Parse(userId), // 记录最后操作人
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                await _logRepo.InsertAsync(log);
            }
            else
            {
                // 更新
                log.Findings = input.Findings;
                log.EvidenceFiles = JsonSerializer.Serialize(input.FileUrls);
                log.CreatedBy = long.Parse(userId); // 更新操作人
                log.UpdatedAt = DateTime.UtcNow;
                await _logRepo.UpdateAsync(log);
            }
        }
        /// <summary>
        /// 获取特定任务和节点的巡视组证据材料
        /// </summary>
        public async Task<(string Content, List<string> FileUrls)> GetInspectionEvidence(long taskId, long nodeId)
        {
            // 1. 查找关联到该任务的视导行程
            var schedule = await _scheduleRepo.FirstOrDefaultAsync(x => x.AssignmentId == taskId && !x.IsDeleted);
            if (schedule == null) return (string.Empty, new List<string>());

            // 2. 查找该行程下对应指标的现场取证记录
            var log = await _logRepo.FirstOrDefaultAsync(x => x.ScheduleId == schedule.Id && x.NodeId == nodeId && !x.IsDeleted);
            if (log == null) return (string.Empty, new List<string>());

            // 3. 解析 JSON 存储的文件列表
            var files = string.IsNullOrEmpty(log.EvidenceFiles)
                ? new List<string>()
                : global::System.Text.Json.JsonSerializer.Deserialize<List<string>>(log.EvidenceFiles);

            return (log.Findings, files);
        }
    }
}