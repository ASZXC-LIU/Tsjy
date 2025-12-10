
using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc; // [FromBody] 需要这个
using System.ComponentModel.DataAnnotations; // [Required] 需要这个
using Tsjy.Application.System.Dtos; // 引用刚刚创建的 DTO
using Tsjy.Core.Entities; // 引用 Tasks, DistributionBatch 等实体
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Service
{
    public class TaskService : IDynamicApiController, ITransient
    {
        private readonly IRepository<DistributionBatch> _batchRepo;
        private readonly IRepository<BatchTarget> _batchTargetRepo;
        private readonly IRepository<Tasks> _taskRepo;
        private readonly IRepository<AssignmentEvidence> _evidenceRepo;
        private readonly IRepository<SysUsers> _userRepo;

        // 注入不同类型的指标仓储
        private readonly IRepository<SpeEvalNode> _speRepo;
        private readonly IRepository<IncEvalNode> _incRepo;
        private readonly IRepository<EduEvalNode> _eduRepo;

        public TaskService(
            IRepository<DistributionBatch> batchRepo,
            IRepository<BatchTarget> batchTargetRepo,
            IRepository<Tasks> taskRepo,
            IRepository<AssignmentEvidence> evidenceRepo,
            IRepository<SysUsers> userRepo,
            IRepository<SpeEvalNode> speRepo,
            IRepository<IncEvalNode> incRepo,
            IRepository<EduEvalNode> eduRepo)
        {
            _batchRepo = batchRepo;
            _batchTargetRepo = batchTargetRepo;
            _taskRepo = taskRepo;
            _evidenceRepo = evidenceRepo;
            _userRepo = userRepo;
            _speRepo = speRepo;
            _incRepo = incRepo;
            _eduRepo = eduRepo;
        }

        #region 管理员：分发任务

        /// <summary>
        /// 获取待选单位列表 (根据类型)
        /// </summary>
        public async Task<List<SysUserDto>> GetTargetsByType(OrgType type)
        {
            // 假设 SysUser 表中有 OrgType 字段或关联，这里简化处理，直接查用户
            // 实际项目中可能需要关联 Departments 表
            var role = type == OrgType.EducationBureau ? UserRole.Admin : UserRole.SchoolUser;
            return await _userRepo.Where(u => !u.IsDeleted && u.Role == role)
                                  .Select(u => new SysUserDto { IDNumber = u.IDNumber, RealName = u.RealName ?? u.UserName })
                                  .ToListAsync();
        }

        /// <summary>
        /// 发布任务
        /// </summary>
        public async Task PublishTask([FromBody] DistributeTaskDto input)
        {
            // 1. 创建批次
            var batch = new DistributionBatch
            {
                TreeId = input.TreeId,
                Name = input.BatchName,
                Status = PublicStatus.finalized,
                CreatedAt = DateTime.Now
            };
            var batchEntity = await _batchRepo.InsertNowAsync(batch);

            // 2. 创建具体任务
            var tasks = new List<Tasks>();
            var batchTargets = new List<BatchTarget>();

            foreach (var targetId in input.SelectedTargetIds)
            {
                // 记录批次目标
                batchTargets.Add(new BatchTarget
                {
                    BatchId = batchEntity.Entity.Id,
                    OrgId = targetId,
                    CreatedAt = DateTime.Now
                });

                // 生成任务单
                tasks.Add(new Tasks
                {
                    BatchId = batchEntity.Entity.Id,
                    TreeId = input.TreeId,
                    TargetType = input.TargetType,
                    TargetId = targetId,
                    Status = TaskStatu.Pending, // 初始状态
                    StartAt = input.StartAt,
                    DueAt = input.DueAt,
                    CreatedAt = DateTime.Now
                });
            }

            await _batchTargetRepo.InsertAsync(batchTargets);
            await _taskRepo.InsertAsync(tasks);
        }

        #endregion

        #region 学校端：查看与执行

        /// <summary>
        /// 获取我的任务列表
        /// </summary>
        public async Task<List<SchoolTaskListDto>> GetMyTasks(long myId)
        {
            var tasks = await _taskRepo.AsQueryable()
                .Include(t => t.BatchId) // 如果需要关联批次名，这里假设 Tasks 里没存 Name，得去 Batch 查
                .Where(t => t.TargetId == myId && !t.IsDeleted)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            // 补全批次名称
            var batchIds = tasks.Select(t => t.BatchId).Distinct().ToList();
            var batches = await _batchRepo.Where(b => batchIds.Contains(b.Id)).ToDictionaryAsync(b => b.Id, b => b.Name);

            return tasks.Select(t => new SchoolTaskListDto
            {
                TaskId = t.Id,
                BatchName = batches.ContainsKey(t.BatchId) ? batches[t.BatchId] : "未知任务",
                Status = t.Status,
                DueAt = t.DueAt,
                FinalScore = t.FinalScore,
                Progress = 0 // TODO: 计算完成百分比
            }).ToList();
        }

        /// <summary>
        /// 获取任务详情树 (带填报状态)
        /// </summary>
        public async Task<List<TaskNodeTreeDto>> GetTaskTree(long taskId)
        {
            var task = await _taskRepo.FindOrDefaultAsync(taskId);
            if (task == null) throw new Exception("任务不存在");

            // 1. 根据类型获取对应的指标表
            List<EvalNodeTreeDto> rawNodes = task.TargetType switch
            {
                OrgType.SpecialSchool => await GetNodesInternal(_speRepo, task.TreeId),
                OrgType.InclusiveSchool => await GetNodesInternal(_incRepo, task.TreeId),
                OrgType.EducationBureau => await GetNodesInternal(_eduRepo, task.TreeId),
                _ => new List<EvalNodeTreeDto>()
            };

            // 2. 获取已填报的佐证
            var evidences = await _evidenceRepo.Where(e => e.TaskId == taskId && !e.IsDeleted).ToListAsync();
            var evidenceDict = evidences.ToDictionary(e => e.NodeId, e => e.Status);

            // 3. 转换为带状态的树节点
            // 这里我们需要递归或者扁平转树，假设 GetNodesInternal 返回的是扁平列表
            var treeNodes = rawNodes.Select(n => new TaskNodeTreeDto
            {
                Id = n.Id,
                ParentId = n.ParentId,
                Name = n.Name,
                Code = n.Code,
                Type = n.Type,
                IsCompleted = evidenceDict.ContainsKey(n.Id), // 是否已填
                AuditStatus = evidenceDict.ContainsKey(n.Id) ? evidenceDict[n.Id] : AuditStatus.Pending
            }).ToList();

            return treeNodes; // 前端会用 TreeView 组件处理层级关系，只要 ParentId 对就行
        }

        /// <summary>
        /// 获取单个节点的详细填报信息 (含上下文)
        /// </summary>
        public async Task<NodeFillDetailDto> GetNodeFillDetail(long taskId, long nodeId)
        {
            var task = await _taskRepo.FindOrDefaultAsync(taskId);

            // 1. 获取节点及其上下文（递归找父级）
            // 这里简化逻辑：根据 TargetType 选 Repo，然后查出该节点及其所有父节点
            // 实际开发建议写个存储过程或递归查询，这里用内存处理演示思路
            IEvalNode node = null;
            List<IEvalNode> allNodes = new();

            if (task.TargetType == OrgType.SpecialSchool)
            {
                node = await _speRepo.FindOrDefaultAsync(nodeId);
                allNodes = (await _speRepo.Where(x => x.TreeId == task.TreeId).ToListAsync()).Cast<IEvalNode>().ToList();
            }
            // ... 其他类型省略

            if (node == null) throw new Exception("指标不存在");

            // 2. 构建上下文路径
            var dto = new NodeFillDetailDto { NodeId = nodeId, TaskId = taskId };

            // 简单向上查找填充 FirstIndicator, SecondIndicator 等
            var current = node;
            while (current != null)
            {
                if (current.Type == EvalNodeType.Points) dto.PointName = current.Name;
                else if (current.Type == EvalNodeType.Reference) dto.ReferencePoint = current.Name;
                else if (current.Type == EvalNodeType.SecondIndicator) dto.SecondIndicator = current.Name;
                else if (current.Type == EvalNodeType.FirstIndicator) dto.FirstIndicator = current.Name;
                else if (current.Type == EvalNodeType.Method) dto.Method = current.Name;

                if (current.ParentId == null) break;
                current = allNodes.FirstOrDefault(x => x.Id == current.ParentId);
            }

            // 如果选中的是 Method，可能需要特殊处理展示逻辑
            if (node.Type == EvalNodeType.Points)
            {
                var methodNode = allNodes.FirstOrDefault(x => x.ParentId == node.Id && x.Type == EvalNodeType.Method);
                if (methodNode != null) dto.Method = methodNode.Name;
            }

            dto.MaxScore = node.MaxScore;

            // 3. 获取已填内容
            var evidence = await _evidenceRepo.FirstOrDefaultAsync(e => e.TaskId == taskId && e.NodeId == nodeId);
            if (evidence != null)
            {
                dto.EvidenceId = evidence.Id;
                dto.MyContent = evidence.Content;
                dto.FileUrls = string.IsNullOrEmpty(evidence.FileUrls)
                    ? new List<string>()
                    : global::System.Text.Json.JsonSerializer.Deserialize<List<string>>(evidence.FileUrls);
                dto.Status = evidence.Status;
                dto.RejectReason = evidence.RejectReason;
            }

            return dto;
        }

        /// <summary>
        /// 提交佐证
        /// </summary>
        public async Task SubmitEvidence(NodeFillDetailDto input)
        {
            var evidence = await _evidenceRepo.FirstOrDefaultAsync(e => e.TaskId == input.TaskId && e.NodeId == input.NodeId);
            if (evidence == null)
            {
                evidence = new AssignmentEvidence
                {
                    TaskId = input.TaskId,
                    NodeId = input.NodeId,
                    CreatedAt = DateTime.Now
                };
                await _evidenceRepo.InsertAsync(evidence);
            }

            evidence.Content = input.MyContent;
            evidence.FileUrls = global::System.Text.Json.JsonSerializer.Serialize(input.FileUrls);
            evidence.Status = AuditStatus.Pending; // 提交后重置为待审核
            evidence.UpdatedAt = DateTime.Now;

            await _evidenceRepo.UpdateAsync(evidence);

            // 更新任务状态为“填报中”
            var task = await _taskRepo.FindOrDefaultAsync(input.TaskId);
            if (task.Status == TaskStatu.Pending || task.Status == TaskStatu.Sent)
            {
                task.Status = TaskStatu.Submitting;
                await _taskRepo.UpdateAsync(task);
            }
        }

        // 复用之前的 GetNodesInternal
        private async Task<List<EvalNodeTreeDto>> GetNodesInternal<T>(IRepository<T> repo, long TreeId) where T : class, IEntity, IEvalNode, new()
        {
            var list = await repo.Where(x => !x.IsDeleted && x.TreeId == TreeId).OrderBy(x => x.OrderIndex).ToListAsync();
            return list.Adapt<List<EvalNodeTreeDto>>();
        }
        #endregion
    }
}