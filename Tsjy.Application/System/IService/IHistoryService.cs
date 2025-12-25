using Tsjy.Application.System.Dtos.History;

namespace Tsjy.Application.System.IService;

public interface IHistoryService
{
    Task<List<ChartDataDto>> GetScoreTrendAsync(string orgId);
    Task<HistoryTaskDto> GetBestScoreAsync(string orgId);
}