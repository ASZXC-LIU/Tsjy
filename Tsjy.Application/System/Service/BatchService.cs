using System.Linq;
using BootstrapBlazor.Components;
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
    private readonly IRepository<Tasks> _taskRepo;
    private readonly IRepository<SysUsers> _userRepo;
    private readonly IRepository<Departments> _deptRepo;
    // ★★★ 新增注入：用于查询体系名称 ★★★
    private readonly IRepository<SpeEvalNode> _speRepo;
    private readonly IRepository<IncEvalNode> _incRepo;
    private readonly IRepository<EduEvalNode> _eduRepo;
    private readonly IRepository<InspectionTeam> _inspectionTeamRepo;
    private readonly IRepository<InspectionTeamMember> _teamMemberRepo;
    private readonly IRepository<ExpertReview> _expertReviewRepo;
    public BatchService(
        IRepository<DistributionBatch> batchRepo,
        IRepository<SysUsers> userRepo,
        IRepository<Departments> deptRepo,
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
        _userRepo = userRepo;
        _deptRepo = deptRepo;
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
                UploadStart = b.UploadStart,
                UploadEnd = b.UploadEnd,
                ReviewStart = b.ReviewStart,
                ReviewEnd = b.ReviewEnd,
                InspectionStart = b.InspectionStart,
                InspectionEnd = b.InspectionEnd
                // OrgCount = 0 // 先不计算，防止并发冲突
            })
            .ToListAsync(); // 此时 Context 操作已完成，释放控制权

        // 4. 填充 TreeName 和 OrgCount (内存处理)
        if (list.Any())
        {
            var batchIds = list.Select(x => x.Id).ToList();

            // ★★★ 修复步骤 2：单独批量查询 OrgCount ★★★
            // 使用 GroupBy 一次性查出所有相关批次的数量，避免 N+1 问题，且不在循环中使用 Context
            var counts = await _taskRepo.AsQueryable(false)
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

        // 获取仓储的 Database 对象开启事务
        // 注意：Furion 的 IRepository 通常有 Context 属性
        // 或者注入 IUnitOfWork

        // 假设使用 EF Core 原生事务
        var strategy = _batchRepo.Context.Database.CreateExecutionStrategy();

        await strategy.ExecuteAsync(async () =>
        {
            using var transaction = await _batchRepo.Context.Database.BeginTransactionAsync();
            try
            {
                // 1. 获取批次
                var batch = await _batchRepo.FindOrDefaultAsync(input.BatchId);
                if (batch == null) throw new Exception("批次不存在");
                // ★★★ 新增：防止重复发布 ★★★
                if (batch.Status != PublicStatus.NotStarted)
                    throw new Exception($"该批次状态为“{batch.Status.ToDescriptionString()}”，不可重复分发！");
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
                var expertIds = input.ReviewExpertIds;
                int expertCount = expertIds.Count;

                // 打乱指标顺序
                var rng = new Random();
                var shuffledNodes = pointNodeIds.OrderBy(a => rng.Next()).ToList();

                // 建立映射: ExpertId -> List<NodeId>
                var expertWorkloadMap = new Dictionary<string, List<long>>();
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
                    Status = TaskStatu.NotStarted,
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
                        string expertId = kvp.Key;
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
                    // 设置每批次的大小，例如 1000 条
                    int batchSize = 1000;
                    int total = expertReviewsToAdd.Count;

                    // 计算需要分多少批
                    int batchCount = (int)Math.Ceiling((double)total / batchSize);

                    for (int i = 0; i < batchCount; i++)
                    {
                        // 跳过前 i * batchSize 条，取接下来的 batchSize 条
                        // ★★★ 修复：将变量名 'batch' 改为 'currentBatch' 以避免冲突 ★★★
                        var currentBatch = expertReviewsToAdd.Skip(i * batchSize).Take(batchSize).ToList();

                        // 插入这一批
                        await _expertReviewRepo.InsertAsync(currentBatch);
                    }
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
                        UserId = uid
                    });
                    await _teamMemberRepo.InsertAsync(members);
                }

                // 7. 更新批次状态
                batch.Status = PublicStatus.Published;
                await _batchRepo.UpdateAsync(batch);

                await _batchRepo.Context.SaveChangesAsync(); // 确保所有更改提交
                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw; // 抛出异常给前端提示
            }
        });
        
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
            UploadStart = entity.UploadStart,
            UploadEnd = entity.UploadEnd,
            ReviewStart = entity.ReviewStart,
            ReviewEnd = entity.ReviewEnd,
            InspectionStart = entity.InspectionStart,
            InspectionEnd = entity.InspectionEnd
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
            
            entity.UploadStart = input.UploadStart;
            entity.UploadEnd = input.UploadEnd;
            entity.ReviewStart = input.ReviewStart;
            entity.ReviewEnd = input.ReviewEnd;
            entity.InspectionStart = input.InspectionStart;
            entity.InspectionEnd = input.InspectionEnd;
            entity.UpdatedAt = DateTime.Now;
            if (input.UploadStart.HasValue) entity.StartAt = input.UploadStart.Value;
            if (input.InspectionEnd.HasValue) entity.DueAt = input.ReviewEnd.Value;
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
            UploadStart = input.UploadStart,
            UploadEnd = input.UploadEnd,
            ReviewStart = input.ReviewStart,
            ReviewEnd = input.ReviewEnd,
            InspectionStart = input.InspectionStart,
            InspectionEnd = input.InspectionEnd,

            // 兼容旧字段
            StartAt = input.UploadStart ?? DateTime.Now,
            DueAt = input.ReviewEnd ?? DateTime.Now.AddDays(30),
            TreeId = input.TreeId ?? 0,
            TargetType = input.TargetType ?? OrgType.SpecialSchool
        };
        await _batchRepo.InsertNowAsync(entity);
    }

    public async Task<BatchProgressDetailDto> GetProgressDetailAsync(long batchId)
    {
        var result = new BatchProgressDetailDto { BatchId = batchId };

        // 1. 获取单位填报进度 (查 Tasks 表 + 关联部门表)
        // 假设 _orgRepo 是 Departments 仓储
        // 注意：这里需要根据 TargetId 关联部门名称，为了性能建议先查出 Tasks 再批量查部门
        var tasks = await _taskRepo.Where(t => t.BatchId == batchId && !t.IsDeleted).ToListAsync();
        var orgCodes = tasks.Select(t => t.TargetId).Distinct().ToList();

        // 假设您有 _deptRepo，如果没有请注入 IRepository<Departments>
        // var orgNames = await _deptRepo.Where(d => orgCodes.Contains(d.Code)).ToDictionaryAsync(d => d.Code, d => d.Name);
        // 这里为了演示，假设 OrgType 不变，您需要根据实际情况注入仓储
        // 临时模拟：实际请务必查库
        

        // ★★★ 核心修复：根据 TargetId (Code) 查询单位名称 ★★★
        var orgNames = await _deptRepo.Where(d => orgCodes.Contains(d.Code))
                                      .Select(d => new { d.Code, d.Name })
                                      .ToDictionaryAsync(d => d.Code, d => d.Name);

        result.OrgProgresses = tasks.Select(t => new OrgProgressDto
        {
            TargetId = t.TargetId,
            OrgName = orgNames.ContainsKey(t.TargetId) ? orgNames[t.TargetId] : $"未命名单位 ({t.TargetId})",
            Status = t.Status,
            SubmittedAt = t.SubmittedAt
        }).ToList();

        // 2. 获取专家评审进度 (查 ExpertReview 表)
        // 统计逻辑：按 ReviewerId 分组，计算 Status == Completed 的比例
        // 需要联表 Task 确保是当前 Batch 的
        var expertStats = await _expertReviewRepo.AsQueryable()
            .Join(_taskRepo.AsQueryable(), r => r.TaskId, t => t.Id, (r, t) => new { r, t })
            .Where(x => x.t.BatchId == batchId && !x.r.IsDeleted)
            .GroupBy(x => x.r.ReviewerId)
            .Select(g => new
            {
                ExpertId = g.Key,
                Total = g.Count(),
                Finished = g.Sum(x => x.r.Status == ReviewStatus.Submitted ? 1 : 0) // 假设枚举是 Submitted 代表完成
            })
            .ToListAsync();

        var expertIds = expertStats.Select(x => x.ExpertId).ToList();
        // 查专家姓名
        var expertNames = await _userRepo.Where(u => expertIds.Contains(u.IDNumber))
                                     .ToDictionaryAsync(u => u.IDNumber, u => u.RealName);// 假设是 RealName

        result.ExpertProgresses = expertStats.Select(x => new ExpertProgressDto
        {
            ExpertId = x.ExpertId,
            ExpertName = expertNames.ContainsKey(x.ExpertId) ? expertNames[x.ExpertId] : "未知专家",
            TotalTasks = x.Total,
            CompletedTasks = x.Finished,
            ProgressRate = x.Total == 0 ? 0 : (double)x.Finished / x.Total * 100
        }).ToList();

        // 3. 获取视导组进度
        // 查 InspectionTeam + InspectionTeamMember
        var teams = await _inspectionTeamRepo.Where(t => t.BatchId == batchId && !t.IsDeleted).ToListAsync();
        var teamIds = teams.Select(t => t.Id).ToList();

        var members = await _teamMemberRepo.Where(m => teamIds.Contains(m.TeamId) && !m.IsDeleted).ToListAsync();
        var memberUserIds = members.Select(m => m.UserId).Distinct().ToList();
        var memberNames = await _userRepo.Where(u => memberUserIds.Contains(u.IDNumber))
                                         .ToDictionaryAsync(u => u.IDNumber, u => u.RealName);

        foreach (var team in teams)
        {
            var teamMembers = members.Where(m => m.TeamId == team.Id)
                                     .Select(m => memberNames.ContainsKey(m.UserId) ? memberNames[m.UserId] : m.UserId.ToString())
                                     .ToList();

            result.InspectionGroups.Add(new InspectionGroupDto
            {
                TeamId = team.Id,
                TeamName = team.Name,
                MemberNames = teamMembers,
                // 这里暂时没查 Schedule 表，如果需要可以补充查询 InspectionSchedule
                ScheduledCount = 0,
                FinishedCount = 0
            });
        }

        return result;
    }



}