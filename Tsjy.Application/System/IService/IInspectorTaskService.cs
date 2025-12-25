using Tsjy.Application.System.Dtos.InspectionDtos;

namespace Tsjy.Application.System.IService;

public interface IInspectorTaskService
{
    // 获取当前视导员的任务列表
    Task<List<InspectorTaskDto>> GetMyInspectionsAsync(string expertId);

    // 获取视导任务详情（用于校验权限）
    Task<bool> ValidateInspectionAccessAsync(long taskId, string expertId);
}