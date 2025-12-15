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

        // 3. 机构类型过滤
        if (orgType.HasValue)
        {
            query = query.Where(b => b.TargetType == orgType.Value);
        }

        // ★★★ 修复步骤 1：移除 Select 中的子查询 OrgCount ★★★
        var list = await query.OrderByDescending(b => b.CreatedAt)
            .Select(b => new BatchListDto
            {
                Id = b.Id,
                Name = b.Name,
                Status = b.Status,
                CreatedAt = b.CreatedAt,
                IsDeleted = b.IsDeleted,
                TargetType = b.TargetType,
                TreeId = b.TreeId,
                StartAt = b.StartAt,
                DueAt = b.DueAt,
                // OrgCount = 0 // 先不计算，防止并发冲突
            })
            .ToListAsync(); // 此时 Context 操作已完成，释放控制权

        // 4. 填充 TreeName 和 OrgCount (内存处理)
        if (list.Any())
        {
            var batchIds = list.Select(x => x.Id).ToList();

            // ★★★ 修复步骤 2：单独批量查询 OrgCount ★★★
            // 使用 GroupBy 一次性查出所有相关批次的数量，避免 N+1 问题，且不在循环中使用 Context
            var counts = await _targetRepo.AsQueryable(false)
                .Where(t => batchIds.Contains(t.BatchId) && !t.IsDeleted)
                .GroupBy(t => t.BatchId)
                .Select(g => new { BatchId = g.Key, Count = g.Count() })
                .ToDictionaryAsync(x => x.BatchId, x => x.Count);

            // 获取所有涉及的 TreeId (原有逻辑)
            var specialTreeIds = list.Where(x => x.TargetType == OrgType.SpecialSchool).Select(x => x.TreeId).Distinct().ToList();
            var inclusiveTreeIds = list.Where(x => x.TargetType == OrgType.InclusiveSchool).Select(x => x.TreeId).Distinct().ToList();
            var eduTreeIds = list.Where(x => x.TargetType == OrgType.EducationBureau).Select(x => x.TreeId).Distinct().ToList();

            // 批量查询名称 (原有逻辑)
            var speNames = await _speRepo.Where(x => specialTreeIds.Contains(x.Id)).Select(x => new { x.Id, x.Name }).ToDictionaryAsync(x => x.Id, x => x.Name);
            var incNames = await _incRepo.Where(x => inclusiveTreeIds.Contains(x.Id)).Select(x => new { x.Id, x.Name }).ToDictionaryAsync(x => x.Id, x => x.Name);
            var eduNames = await _eduRepo.Where(x => eduTreeIds.Contains(x.Id)).Select(x => new { x.Id, x.Name }).ToDictionaryAsync(x => x.Id, x => x.Name);

            // 填回 DTO
            foreach (var item in list)
            {
                // ★★★ 填充统计数据 ★★★
                if (counts.ContainsKey(item.Id))
                {
                    item.OrgCount = counts[item.Id];
                }
                else
                {
                    item.OrgCount = 0;
                }

                // 填充体系名称
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

    public async Task DistributeAsync(BatchDistributeDto input)
    {
        // 1. 获取批次信息
        var batch = await _batchRepo.FindOrDefaultAsync(input.BatchId);
        if (batch == null) throw new Exception("批次不存在");

        // 2. 插入任务表 (Tasks) - 为每个选中的单位创建任务
        var tasksToAdd = input.SelectedOrgIds.Select(orgId => new Tasks
        {
            BatchId = input.BatchId,
            TreeId = batch.TreeId,
            TargetType = batch.TargetType,
            TargetId = orgId, // 这里存的是 DepartmentDto.Code 或 ID
            Status = TaskStatu.Pending
        }).ToList();
        await _taskRepo.InsertAsync(tasksToAdd); // 假设你有 _taskRepo

        // 3. 创建视导组 (InspectionTeam)
        if (input.InspectionGroupUserIds.Any())
        {
            var team = new InspectionTeam
            {
                BatchId = input.BatchId,
                Name = $"{batch.Name}-视导组"
            };
            var teamEntity = await _inspectionTeamRepo.InsertNowAsync(team); // 假设你有 _inspectionTeamRepo

            var members = input.InspectionGroupUserIds.Select(uid => new InspectionTeamMember
            {
                TeamId = teamEntity.Entity.Id,
                UserId = long.Parse(uid)
            });
            await _teamMemberRepo.InsertAsync(members);
        }

        // 4. 分配专家评审 (ReviewAllocation)
        // 逻辑：所有创建的任务(tasksToAdd) 都要应用这套专家分配规则
        // 注意：这里需要拿到刚才插入的 Task 的 ID，建议用事务或 SaveChanges 后再查
        // 简单起见，这里演示逻辑：

        // 获取刚刚插入的任务ID列表 (实际开发中需确保获取到ID)
        // var createdTasks = await _taskRepo.Where(t => t.BatchId == input.BatchId).ToListAsync();

        // foreach (var task in createdTasks)
        // {
        //     foreach (var allocation in input.ExpertAllocations)
        //     {
        //         foreach (var expertIdStr in allocation.SelectedExpertIds)
        //         {
        //              _reviewRepo.Insert({ TaskId = task.Id, NodeId = allocation.NodeId, ExpertId = long.Parse(expertIdStr) ... })
        //         }
        //     }
        // }

        // 5. 更新批次状态为已发布
        batch.Status = PublicStatus.Published; // 假设你有这个状态枚举
        await _batchRepo.UpdateAsync(batch);
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