using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tsjy.Application.System.Dtos.History;
using Tsjy.Application.System.IService;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Service;

public class HistoryService : IHistoryService, ITransient, IScoped
{
    private readonly IRepository<Tasks> _taskRepo;
    private readonly IRepository<DistributionBatch> _batchRepo;

    public HistoryService(IRepository<Tasks> taskRepo, IRepository<DistributionBatch> batchRepo)
    {
        _taskRepo = taskRepo;
        _batchRepo = batchRepo;
    }

    // GetHistoryListAsync 可保持注释或删除...

    // 取消注释并实现图表数据逻辑
    public async Task<List<ChartDataDto>> GetScoreTrendAsync(string orgId)
    {
        if (string.IsNullOrEmpty(orgId)) return new List<ChartDataDto>();

        var query = from t in _taskRepo.AsQueryable()
                    join b in _batchRepo.AsQueryable() on t.BatchId equals b.Id
                    // 筛选
                    where t.TargetId == orgId && t.Status == TaskStatu.Finished && t.FinalScore != null
                    // 【核心修复1】添加排序：按批次创建时间正序排列
                    orderby b.UploadEnd ascending
                    select new ChartDataDto
                    {
                        Label = b.Name,
                        Score = t.FinalScore.Value
                    };

        return await query.ToListAsync();
    }

    public async Task<HistoryTaskDto> GetBestScoreAsync(string orgId)
    {
        if (string.IsNullOrEmpty(orgId)) return new HistoryTaskDto { FinalScore = 0, BatchName = "暂无数据" };

        var query = from t in _taskRepo.AsQueryable()
                    join b in _batchRepo.AsQueryable() on t.BatchId equals b.Id
                    where t.TargetId == orgId && t.Status == TaskStatu.Finished && t.FinalScore != null
                    orderby t.FinalScore descending
                    select new HistoryTaskDto
                    {
                        FinalScore = t.FinalScore,
                        BatchName = b.Name,
                    };

        var best = await query.FirstOrDefaultAsync();
        return best ?? new HistoryTaskDto { FinalScore = 0, BatchName = "暂无数据" };
    }
}