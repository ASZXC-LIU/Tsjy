using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tsjy.Application.System.Dtos.History;
using Tsjy.Application.System.IService;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums; // 引用枚举命名空间

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

    //public async Task<List<HistoryTaskDto>> GetHistoryListAsync(string orgId)
    //{
    //    if (string.IsNullOrEmpty(orgId)) return new List<HistoryTaskDto>();

    //    var query = from t in _taskRepo.AsQueryable()
    //                join b in _batchRepo.AsQueryable() on t.BatchId equals b.Id
    //                // 使用传入的 orgId 进行过滤
    //                where t.TargetId == orgId
    //                orderby t.StartAt descending
    //                select new HistoryTaskDto
    //                {
    //                    Id = t.Id,
    //                    BatchName = b.Name,
    //                    Version = "标准体系",
    //                    Status = t.Status == TaskStatu.Finished ? "已完成" : "进行中",
    //                    StatusCode = t.Status == TaskStatu.Finished ? "Completed" : "Pending",
    //                    FinalScore = t.FinalScore,
    //                    Year = t.StartAt.Year,
    //                    Rank = "-"
    //                };

    //    return await query.ToListAsync();
    //}

    //public async Task<List<ChartDataDto>> GetScoreTrendAsync(string orgId)
    //{
    //    if (string.IsNullOrEmpty(orgId)) return new List<ChartDataDto>();

    //    var query = from t in _taskRepo.AsQueryable()
    //                join b in _batchRepo.AsQueryable() on t.BatchId equals b.Id
    //                where t.TargetId == orgId && t.Status == TaskStatu.Finished && t.FinalScore != null
    //                orderby t.StartAt
    //                select new ChartDataDto
    //                {
    //                    Label = b.Name,
    //                    Score = t.FinalScore.Value
    //                };

    //    return await query.ToListAsync();
    //}

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
                        //Year = t.StartAt.Year
                    };

        var best = await query.FirstOrDefaultAsync();
        return best ?? new HistoryTaskDto { FinalScore = 0, BatchName = "暂无数据" };
    }
}