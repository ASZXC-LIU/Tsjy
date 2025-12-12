using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Tsjy.Application.System.Dtos.BatchDtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Service;

public class BatchService : IBatchService, ITransient,IScoped
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

    // 修改：支持 includeDeleted 参数
    public async Task<List<BatchListDto>> GetListAsync(OrgType? orgType = null, bool includeDeleted = false)
    {
        // 1. 基础查询
        var query = _batchRepo.AsQueryable();

        // 2. 如果不包含已删除(未启用)，则过滤掉 IsDeleted=true 的
        if (!includeDeleted)
        {
            query = query.Where(b => !b.IsDeleted);
        }
        // 否则（includeDeleted=true），就查询所有，不加过滤条件

        // 3. 机构类型过滤
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
                Status = b.Status, // 保持原有的业务状态
                CreatedAt = b.CreatedAt,
                IsDeleted = b.IsDeleted, // 映射数据库的 IsDeleted

                OrgCount = _targetRepo.AsQueryable(false).Count(t => t.BatchId == b.Id && !t.IsDeleted),

                //StartAt = _taskRepo.AsQueryable(false)
                //            .Where(t => t.BatchId == b.Id)
                //            .Select(t => (DateTime?)t.StartAt)
                //            .FirstOrDefault(),

                //DueAt = _taskRepo.AsQueryable(false)
                //            .Where(t => t.BatchId == b.Id)
                //            .Select(t => (DateTime?)t.DueAt)
                //            .FirstOrDefault()
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

    // 修改：只更新 IsDeleted，不修改 Status
    public async Task UpdateStatusAsync(long id, bool isEnabled)
    {
        var entity = await _batchRepo.FindOrDefaultAsync(id);
        if (entity != null)
        {
            // 启用(true) => IsDeleted = false
            // 禁用(false) => IsDeleted = true
            entity.IsDeleted = !isEnabled;

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
            if (input.StartAt.HasValue) entity.StartAt = input.StartAt.Value;
            if (input.DueAt.HasValue) entity.DueAt = input.DueAt.Value;
            entity.UpdatedAt = DateTime.Now;
            await _batchRepo.UpdateNowAsync(entity);
        }
    }

    // 新增：创建实现
    public async Task CreateAsync(BatchInputDto input)
    {
        var entity = new DistributionBatch
        {
            Name = input.Name,
            Status = PublicStatus.NotStarted,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
            IsDeleted = false,
            // 赋默认值或前端传来的值
            StartAt = input.StartAt ?? DateTime.Now,
            DueAt = input.DueAt ?? DateTime.Now.AddDays(30),
            TreeId = input.TreeId ?? 0 // 暂时硬编码或从 Input 传入，根据业务需求调整
        };
        await _batchRepo.InsertNowAsync(entity);
    }
}