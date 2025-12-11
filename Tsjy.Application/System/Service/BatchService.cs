using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Tsjy.Application.System.Dtos.BatchDtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Service;

public class BatchService : IBatchService, ITransient
{
    private readonly IRepository<DistributionBatch> _batchRepo;
    private readonly IRepository<BatchTarget> _targetRepo;
    private readonly IRepository<Tasks> _taskRepo;
    public BatchService(IRepository<DistributionBatch> batchRepo, IRepository<BatchTarget> targetRepo, IRepository<Tasks> taskRepo)
    {
        _batchRepo = batchRepo;
        _targetRepo = targetRepo;
        _taskRepo = taskRepo; 
    }

    public async Task<List<BatchListDto>> GetListAsync(OrgType? orgType = null)
    {
        var query = _batchRepo.AsQueryable()
                    .Where(b => !b.IsDeleted);

        // 如果传入了机构类型，则通过子查询过滤包含该类型任务的批次
        if (orgType.HasValue)
        {
            query = query.Where(b => _taskRepo.AsQueryable(false)
                .Any(t => t.BatchId == b.Id && t.TargetType == orgType.Value));
        }

        var listQuery = query.OrderByDescending(b => b.CreatedAt)
            .Select(b => new BatchListDto
            {
                Id = b.Id,
                Name = b.Name,
                Status = b.Status,
                CreatedAt = b.CreatedAt,
                IsEnabled = b.Status != PublicStatus.NotStarted && b.Status != PublicStatus.Finished, // 简单的逻辑映射，根据实际需求调整

                // 计算机构数量
                OrgCount = _targetRepo.AsQueryable(false).Count(t => t.BatchId == b.Id && !t.IsDeleted),

                // 获取时间：假设同一批次下的任务时间是一致的，取第一个非空的
                StartAt = _taskRepo.AsQueryable(false)
                            .Where(t => t.BatchId == b.Id)
                            .Select(t => (DateTime?)t.StartAt)
                            .FirstOrDefault(),

                DueAt = _taskRepo.AsQueryable(false)
                            .Where(t => t.BatchId == b.Id)
                            .Select(t => (DateTime?)t.DueAt)
                            .FirstOrDefault()
            });

        return await listQuery.ToListAsync();
    }

    public async Task DeleteAsync(long id)
    {
        var entity = await _batchRepo.FindOrDefaultAsync(id);
        if (entity != null)
        {
            entity.IsDeleted = true;
            entity.UpdatedAt = DateTime.Now;
            await _batchRepo.UpdateNowAsync(entity);
        }
    }

    public async Task UpdateStatusAsync(long id, bool isEnabled)
    {
        var entity = await _batchRepo.FindOrDefaultAsync(id);
        if (entity != null)
        {
            
            entity.UpdatedAt = DateTime.Now;
            await _batchRepo.UpdateNowAsync(entity);
        }
    }

    public async Task UpdateAsync(BatchInputDto input)
    {
        var entity = await _batchRepo.FindOrDefaultAsync(input.Id);
        if (entity != null)
        {
            entity.Name = input.Name;
            // 可以在这里更新其他字段
            entity.UpdatedAt = DateTime.Now;
            await _batchRepo.UpdateNowAsync(entity);
        }
    }
}