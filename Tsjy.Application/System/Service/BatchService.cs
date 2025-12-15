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
    private readonly IRepository<InspectionTeam> _inspectionTeamRepo;
    private readonly IRepository<InspectionTeamMember> _teamMemberRepo;
    private readonly IRepository<ExpertReview> _expertReviewRepo;
    public BatchService(
        IRepository<DistributionBatch> batchRepo,
        IRepository<BatchTarget> targetRepo,
        IRepository<Tasks> taskRepo,
        IRepository<InspectionTeam> inspectionTeamRepo,
        IRepository<InspectionTeamMember> teamMemberRepo,
        IRepository<SpeEvalNode> speRepo,
        IRepository<IncEvalNode> incRepo,
        IRepository<ExpertReview> expertReviewRepo,
        IRepository<EduEvalNode> eduRepo
        )
    {
        _batchRepo = batchRepo;
        _targetRepo = targetRepo;
        _taskRepo = taskRepo;
        _speRepo = speRepo;
        _incRepo = incRepo;
        _eduRepo = eduRepo;
        _inspectionTeamRepo = inspectionTeamRepo; // 赋值
        _teamMemberRepo = teamMemberRepo;         // 赋值
        _expertReviewRepo = expertReviewRepo;
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
        // 1. 获取批次
        var batch = await _batchRepo.FindOrDefaultAsync(input.BatchId);
        if (batch == null) throw new Exception("批次不存在");

        // 2. 获取该体系所有“评估要点(Points)”
        List<long> pointNodeIds = new();

        if (batch.TargetType == OrgType.SpecialSchool)
        {
            pointNodeIds = await _speRepo.Where(x => x.TreeId == batch.TreeId && x.Type == EvalNodeType.Points && !x.IsDeleted)
                                         .Select(x => x.Id).ToListAsync();
        }
        else if (batch.TargetType == OrgType.InclusiveSchool)
        {
            pointNodeIds = await _incRepo.Where(x => x.TreeId == batch.TreeId && x.Type == EvalNodeType.Points && !x.IsDeleted)
                                         .Select(x => x.Id).ToListAsync();
        }
        else if (batch.TargetType == OrgType.EducationBureau)
        {
            pointNodeIds = await _eduRepo.Where(x => x.TreeId == batch.TreeId && x.Type == EvalNodeType.Points && !x.IsDeleted)
                                         .Select(x => x.Id).ToListAsync();
        }

        if (!pointNodeIds.Any()) throw new Exception("该评价体系未找到“评估要点”数据，无法分配！");
        if (!input.ReviewExpertIds.Any()) throw new Exception("未选择评审专家！");

        // 3. 核心算法：洗牌并平均分配 (Shuffle & Deal)
        var expertIds = input.ReviewExpertIds.Select(long.Parse).ToList();
        int expertCount = expertIds.Count;

        // 打乱指标顺序
        var rng = new Random();
        var shuffledNodes = pointNodeIds.OrderBy(a => rng.Next()).ToList();

        // 建立映射: ExpertId -> List<NodeId>
        var expertWorkloadMap = new Dictionary<long, List<long>>();
        foreach (var eid in expertIds)
        {
            expertWorkloadMap[eid] = new List<long>();
        }

        // 发牌
        for (int i = 0; i < shuffledNodes.Count; i++)
        {
            var expertIndex = i % expertCount;
            var targetExpertId = expertIds[expertIndex];
            expertWorkloadMap[targetExpertId].Add(shuffledNodes[i]);
        }

        // 4. 创建学校任务 (Tasks)
        var tasksToAdd = input.SelectedOrgIds.Select(orgId => new Tasks
        {
            BatchId = input.BatchId,
            TreeId = batch.TreeId,
            TargetType = batch.TargetType,
            TargetId = orgId,
            Status = TaskStatu.Pending,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        }).ToList();

        // 插入数据库并获取 TaskId
        var createdTasks = new List<Tasks>();
        foreach (var task in tasksToAdd)
        {
            var entry = await _taskRepo.InsertNowAsync(task);
            createdTasks.Add(entry.Entity);
        }

        // 5. 预生成专家评分表 (ExpertReview)
        var expertReviewsToAdd = new List<ExpertReview>();

        foreach (var task in createdTasks)
        {
            // 对于每个学校，应用刚才计算的分配规则
            foreach (var kvp in expertWorkloadMap)
            {
                long expertId = kvp.Key;
                List<long> assignedNodes = kvp.Value;

                foreach (var nodeId in assignedNodes)
                {
                    expertReviewsToAdd.Add(new ExpertReview
                    {
                        TaskId = task.Id,
                        NodeId = nodeId,
                        ReviewerId = expertId,
                        Status = ReviewStatus.Pending, // 待评审
                        // 分数留空
                        ScoreRatio = null,
                        FinalScore = null,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    });
                }
            }
        }

        if (expertReviewsToAdd.Any())
        {
            // 批量插入
            await _expertReviewRepo.InsertAsync(expertReviewsToAdd);
        }

        // 6. 创建视导组
        if (input.InspectionGroupUserIds.Any())
        {
            var team = new InspectionTeam
            {
                BatchId = input.BatchId,
                Name = $"{batch.Name}-视导组"
            };
            var teamEntity = await _inspectionTeamRepo.InsertNowAsync(team);

            var members = input.InspectionGroupUserIds.Select(uid => new InspectionTeamMember
            {
                TeamId = teamEntity.Entity.Id,
                UserId = long.Parse(uid)
            });
            await _teamMemberRepo.InsertAsync(members);
        }

        // 7. 更新批次状态
        batch.Status = PublicStatus.Published;
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