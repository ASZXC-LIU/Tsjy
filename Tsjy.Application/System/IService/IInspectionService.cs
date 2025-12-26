using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsjy.Application.System.Dtos.InspectionDtos;

namespace Tsjy.Application.System.IService
{
    public interface IInspectionService
    {
        Task<(string Content, List<string> FileUrls)> GetInspectionEvidence(long taskId, long nodeId);

        // 获取我的视导任务列表
        Task<List<InspectorTaskDto>> GetMyInspectionsAsync(string userId);

        // 获取节点填报日志
        Task<InspectionLogInputDto> GetNodeLogAsync(long scheduleId, long nodeId);

        // 保存节点填报日志
        Task SaveNodeLogAsync(InspectionLogInputDto input, string userId);

        // ★★★ 新增：合并过来的权限校验方法 ★★★
        Task<bool> ValidateInspectionAccessAsync(long taskId, string expertId);
    }
}
