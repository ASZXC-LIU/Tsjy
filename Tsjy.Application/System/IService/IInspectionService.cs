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
        Task<List<InspectorTaskDto>> GetMyInspectionsAsync(string userId);
        Task<InspectionLogInputDto> GetNodeLogAsync(long scheduleId, long nodeId);
        Task SaveNodeLogAsync(InspectionLogInputDto input, string userId);
    }
}
