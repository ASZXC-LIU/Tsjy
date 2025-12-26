using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Text.Json; // 必须引用，用于 JsonSerializer
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
        // ★★★ 新增：用于获取任务名称 ★★★
        private readonly IRepository<DistributionBatch> _batchRepo;

        public InspectionService(
            IRepository<InspectionLog> logRepo,
            IRepository<InspectionSchedule> scheduleRepo,
            IRepository<InspectionTeamMember> memberRepo,
            IRepository<InspectionTeam> teamRepo,
            IRepository<Tasks> taskRepo,
            IRepository<Departments> deptRepo,
            IRepository<DistributionBatch> batchRepo)
        {
            _logRepo = logRepo;
            _scheduleRepo = scheduleRepo;
            _memberRepo = memberRepo;
            _teamRepo = teamRepo;
            _taskRepo = taskRepo;
            _deptRepo = deptRepo;
            _batchRepo = batchRepo;
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

            // 2. 联表查询
            var query = from s in _scheduleRepo.AsQueryable()
                        join t in _teamRepo.AsQueryable() on s.TeamId equals t.Id
                        join task in _taskRepo.AsQueryable() on s.AssignmentId equals task.Id
                        // ★★★ 修复1：关联 Batch 获取任务名称 ★★★
                        join batch in _batchRepo.AsQueryable() on task.BatchId equals batch.Id
                        // ★★★ 修复2：Departments 使用 Code 作为主键 ★★★
                        join d in _deptRepo.AsQueryable() on task.TargetId equals d.Code
                        where myTeamIds.Contains(s.TeamId) && !s.IsDeleted
                        orderby s.VisitStartAt descending
                        select new InspectorTaskDto
                        {
                            ScheduleId = s.Id,
                            TaskId = task.Id,
                            TaskName = batch.Name, // 获取批次名称作为任务名
                            SchoolName = d.Name,
                            TeamName = t.Name,
                            StartDate = s.VisitStartAt,
                            EndDate = s.VisitEndAt,
                            // 注意：这里假设 InspectorTaskDto.Status 类型与 InspectionSchedule.Status 兼容
                            // 如果不兼容可能需要强转，例如 (int)s.Status
                            Status = s.Status
                        };

            return await query.ToListAsync();
        }

        /// <summary>
        /// ★★★ 新增：验证视导员是否有权限访问该任务 ★★★
        /// </summary>
        public async Task<bool> ValidateInspectionAccessAsync(long taskId, string expertId)
        {
            // 逻辑：检查是否存在一条行程(Schedule)，该行程关联了指定任务(AssignmentId)，
            // 且该行程的小组(Team)中包含当前专家(TeamMember)
            var hasAccess = await (from s in _scheduleRepo.AsQueryable()
                                   join m in _memberRepo.AsQueryable() on s.TeamId equals m.TeamId
                                   where s.AssignmentId == taskId
                                         && m.UserId == expertId
                                         && !s.IsDeleted
                                         && !m.IsDeleted
                                   select s.Id).AnyAsync();
            return hasAccess;
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
            var log = await _logRepo.FirstOrDefaultAsync(x => x.ScheduleId == input.ScheduleId && x.NodeId == input.NodeId);

            if (log == null)
            {
                log = new InspectionLog
                {
                    ScheduleId = input.ScheduleId,
                    NodeId = input.NodeId,
                    Findings = input.Findings,
                    EvidenceFiles = JsonSerializer.Serialize(input.FileUrls),
                    CreatedBy = long.Parse(userId),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                await _logRepo.InsertAsync(log);
            }
            else
            {
                log.Findings = input.Findings;
                log.EvidenceFiles = JsonSerializer.Serialize(input.FileUrls);
                log.CreatedBy = long.Parse(userId);
                log.UpdatedAt = DateTime.UtcNow;
                await _logRepo.UpdateAsync(log);
            }
        }

        /// <summary>
        /// 获取特定任务和节点的巡视组证据材料
        /// </summary>
        public async Task<(string Content, List<string> FileUrls)> GetInspectionEvidence(long taskId, long nodeId)
        {
            var schedule = await _scheduleRepo.FirstOrDefaultAsync(x => x.AssignmentId == taskId && !x.IsDeleted);
            if (schedule == null) return (string.Empty, new List<string>());

            var log = await _logRepo.FirstOrDefaultAsync(x => x.ScheduleId == schedule.Id && x.NodeId == nodeId && !x.IsDeleted);
            if (log == null) return (string.Empty, new List<string>());

            var files = string.IsNullOrEmpty(log.EvidenceFiles)
                ? new List<string>()
                : JsonSerializer.Deserialize<List<string>>(log.EvidenceFiles);

            return (log.Findings, files);
        }
    }
}