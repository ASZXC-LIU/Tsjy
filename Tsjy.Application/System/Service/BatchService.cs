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

    public BatchService(IRepository<DistributionBatch> batchRepo, IRepository<BatchTarget> targetRepo)
    {
        _batchRepo = batchRepo;
        _targetRepo = targetRepo;
    }

    public async Task<List<BatchListDto>> GetListAsync()
    {
        // 关联查询计算机构数量
        var query = from b in _batchRepo.AsQueryable()
                    where !b.IsDeleted
                    orderby b.CreatedAt descending
                    select new BatchListDto
                    {
                        Id = b.Id,
                        Name = b.Name,
                        Status = b.Status,
                        CreatedAt = b.CreatedAt,
                        // ★★★ 修复 CS0854：显式传入 false 参数 ★★★
                        OrgCount = _targetRepo.AsQueryable(false).Count(t => t.BatchId == b.Id && !t.IsDeleted)
                    };

        return await query.ToListAsync();
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