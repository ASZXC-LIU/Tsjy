using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Tsjy.Core.Entities;
using Tsjy.Application.System.IService;
namespace Tsjy.Application.System.Service
{
    

    public class InspectionService : IInspectionService, ITransient, IScoped
    {
        private readonly IRepository<InspectionLog> _logRepo;
        private readonly IRepository<InspectionSchedule> _scheduleRepo;

        public InspectionService(
            IRepository<InspectionLog> logRepo,
            IRepository<InspectionSchedule> scheduleRepo)
        {
            _logRepo = logRepo;
            _scheduleRepo = scheduleRepo;
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