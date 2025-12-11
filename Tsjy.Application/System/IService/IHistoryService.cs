using Tsjy.Application.System.Dtos.History;

namespace Tsjy.Application.System.IService;

public interface IHistoryService
{
    // 所有方法增加 orgId 参数
    Task<List<HistoryTaskDto>> GetHistoryListAsync(string orgId);
    Task<List<ChartDataDto>> GetScoreTrendAsync(string orgId);
    Task<HistoryTaskDto> GetBestScoreAsync(string orgId);
}