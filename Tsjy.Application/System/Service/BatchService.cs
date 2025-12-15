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
    // ★★★ 新增注入：用于查询体系名称 ★★★
    private readonly IRepository<SpeEvalNode> _speRepo;
    private readonly IRepository<IncEvalNode> _incRepo;
    private readonly IRepository<EduEvalNode> _eduRepo;
    public BatchService(
        IRepository<DistributionBatch> batchRepo,
        IRepository<BatchTarget> targetRepo,
        IRepository<Tasks> taskRepo,
        IRepository<SpeEvalNode> speRepo,
        IRepository<IncEvalNode> incRepo,
        IRepository<EduEvalNode> eduRepo
        )
    {
        _batchRepo = batchRepo;
        _targetRepo = targetRepo;
        _taskRepo = taskRepo;
        _speRepo = speRepo;
        _incRepo = incRepo;
        _eduRepo = eduRepo;
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
            query = query.Where(b => b.TargetType == orgType.Value);
        }

        var list = await query.OrderByDescending(b => b.CreatedAt)
            .Select(b => new BatchListDto
            {
                Id = b.Id,
                Name = b.Name,
                Status = b.Status,
                CreatedAt = b.CreatedAt,
                IsDeleted = b.IsDeleted,
                TargetType = b.TargetType, // 获取类型
                TreeId = b.TreeId,         // 获取TreeId以便后续查名
                StartAt = b.StartAt,
                DueAt = b.DueAt,
                // 计算机构数
                OrgCount = _targetRepo.AsQueryable(false).Count(t => t.BatchId == b.Id && !t.IsDeleted),
            })
            .ToListAsync();

        // 4. 填充 TreeName (因为体系分布在三张表，无法简单 Join，我们在内存中填充)
        if (list.Any())
        {
            // 获取所有涉及的 TreeId
            var specialTreeIds = list.Where(x => x.TargetType == OrgType.SpecialSchool).Select(x => x.TreeId).Distinct().ToList();
            var inclusiveTreeIds = list.Where(x => x.TargetType == OrgType.InclusiveSchool).Select(x => x.TreeId).Distinct().ToList();
            var eduTreeIds = list.Where(x => x.TargetType == OrgType.EducationBureau).Select(x => x.TreeId).Distinct().ToList();

            // 批量查询名称
            var speNames = await _speRepo.Where(x => specialTreeIds.Contains(x.Id)).Select(x => new { x.Id, x.Name }).ToDictionaryAsync(x => x.Id, x => x.Name);
            var incNames = await _incRepo.Where(x => inclusiveTreeIds.Contains(x.Id)).Select(x => new { x.Id, x.Name }).ToDictionaryAsync(x => x.Id, x => x.Name);
            var eduNames = await _eduRepo.Where(x => eduTreeIds.Contains(x.Id)).Select(x => new { x.Id, x.Name }).ToDictionaryAsync(x => x.Id, x => x.Name);

            // 填回 DTO
            foreach (var item in list)
            {
                if (item.TargetType == OrgType.SpecialSchool && speNames.ContainsKey(item.TreeId))
                    item.TreeName = speNames[item.TreeId];
                else if (item.TargetType == OrgType.InclusiveSchool && incNames.ContainsKey(item.TreeId))
                    item.TreeName = incNames[item.TreeId];
                else if (item.TargetType == OrgType.EducationBureau && eduNames.ContainsKey(item.TreeId))
                    item.TreeName = eduNames[item.TreeId];
                else
                    item.TreeName = $"未知体系 ({item.TreeId})";
            }
        }

        return list;
    }
    public async Task<BatchInputDto> GetDetailAsync(long id)
    {
        var entity = await _batchRepo.FindOrDefaultAsync(id);
        if (entity == null) return new BatchInputDto();

        return new BatchInputDto
        {
            Id = entity.Id,
            Name = entity.Name,
            TargetType = entity.TargetType,
            TreeId = entity.TreeId,
            Status = entity.Status,
            StartAt = entity.StartAt,
            DueAt = entity.DueAt
        };
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
            TreeId = input.TreeId ?? 0,
            TargetType = input.TargetType ?? OrgType.SpecialSchool
        };
        await _batchRepo.InsertNowAsync(entity);
    }
}