using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tsjy.Application.System.Dtos;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Service
{
    public class TaskService : IDynamicApiController, ITransient, IScoped
    {
        private readonly IRepository<DistributionBatch> _batchRepo;
        private readonly IRepository<Tasks> _taskRepo;
        private readonly IRepository<TaskEvidences> _evidenceRepo;
        private readonly IRepository<Departments> _orgRepo;
        private readonly IRepository<SysUsers> _userRepo;
        private readonly IRepository<SpeEvalNode> _speRepo;
        private readonly IRepository<IncEvalNode> _incRepo;
        private readonly IRepository<EduEvalNode> _eduRepo;
        private readonly IRepository<ScoringModelItem> _scoringItemRepo;
        private readonly IRepository<ScoringModel> _modelRepo;

        public TaskService(
            IRepository<ScoringModelItem> scoringItemRepo,
            IRepository<DistributionBatch> batchRepo,
            IRepository<Tasks> taskRepo,
            IRepository<TaskEvidences> evidenceRepo,
            IRepository<SysUsers> userRepo,
            IRepository<Departments> orgRepo,
            IRepository<SpeEvalNode> speRepo,
            IRepository<IncEvalNode> incRepo,
            IRepository<ScoringModel> modelRepo,
            IRepository<EduEvalNode> eduRepo)
        {
            _scoringItemRepo = scoringItemRepo;
            _modelRepo = modelRepo;
            _batchRepo = batchRepo;
            _taskRepo = taskRepo;
            _evidenceRepo = evidenceRepo;
            _userRepo = userRepo;
            _orgRepo = orgRepo;
            _speRepo = speRepo;
            _incRepo = incRepo;
            _eduRepo = eduRepo;
        }

        #region 学校端：查看与执行

        /// <summary>
        /// 检查任务是否处于可编辑状态 (通用检查：状态+时间)
        /// </summary>
        public async Task<bool> IsTaskEditable(long taskId)
        {
            var task = await _taskRepo.FindOrDefaultAsync(taskId);
            if (task == null) return false;
            if (task.Status == TaskStatu.Returned) return true;
            // 1. 状态校验：允许 待提交、填报中、被退回
            bool isStatusAllow = task.Status == TaskStatu.ToSubmit ||
                                 task.Status == TaskStatu.Submitting ||
                                 task.Status == TaskStatu.Returned;

            if (!isStatusAllow) return false;

            // 2. 时间校验
            var batch = await _batchRepo.FindOrDefaultAsync(task.BatchId);
            if (batch != null)
            {
                var now = DateTime.Now;
                // 如果还没到开始时间
                if (batch.UploadStart.HasValue && now < batch.UploadStart.Value) return false;
                // 如果已经过了结束时间
                if (batch.UploadEnd.HasValue && now > batch.UploadEnd.Value) return false;
            }

            return true;
        }

        /// <summary>
        /// 获取任务当前状态 (供前端判断)
        /// </summary>
        [HttpGet]
        public async Task<TaskStatu> GetTaskStatus(long taskId)
        {
            var task = await _taskRepo.FindOrDefaultAsync(taskId);
            return task?.Status ?? TaskStatu.NotStarted;
        }

        /// <summary>
        /// 获取我的任务列表 (包含状态自动流转逻辑)
        /// </summary>
        public async Task<List<SchoolTaskListDto>> GetMyTasks(string myOrgId)
        {
            if (string.IsNullOrEmpty(myOrgId)) return new List<SchoolTaskListDto>();

            var tasks = await _taskRepo.AsQueryable()
                .Where(t => t.TargetId == myOrgId && !t.IsDeleted)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            if (!tasks.Any()) return new List<SchoolTaskListDto>();

            var batchIds = tasks.Select(t => t.BatchId).Distinct().ToList();
            var batches = await _batchRepo.Where(b => batchIds.Contains(b.Id))
                                          .ToDictionaryAsync(b => b.Id, b => b);

            bool needSave = false;
            var now = DateTime.Now;

            foreach (var task in tasks)
            {
                // A. 自动检测驳回：优先级最高
                // 只要有节点被驳回，状态强制变为 Returned
                if (task.Status == TaskStatu.Reviewing ||
            task.Status == TaskStatu.Submitted ||
            task.Status == TaskStatu.Submitting ||
            task.Status == TaskStatu.Finished)
                {
                    bool hasRejectedNodes = await _evidenceRepo.AnyAsync(e => e.TaskId == task.Id && e.Status == AuditStatus.Rejected);
                    if (hasRejectedNodes && task.Status != TaskStatu.Returned)
                    {
                        task.Status = TaskStatu.Returned;
                        _taskRepo.Update(task);
                        needSave = true;
                        continue; // 状态已变，跳过后续检查
                    }
                }

                if (batches.TryGetValue(task.BatchId, out var batch))
                {
                    // Logic A: 自动开始
                    // 状态是"未开始" 且 时间到了 -> 变为 "待提交"
                    if (task.Status == TaskStatu.NotStarted && batch.UploadStart.HasValue && now >= batch.UploadStart.Value)
                    {
                        task.Status = TaskStatu.ToSubmit;
                        _taskRepo.Update(task);
                        needSave = true;
                    }

                    // Logic B: 自动结束
                    // 时间过了截止时间 且 状态还在填报中 -> 自动变为 "已完成"
                    if (batch.UploadEnd.HasValue && now > batch.UploadEnd.Value)
                    {
                        if (task.Status == TaskStatu.Submitting || task.Status == TaskStatu.ToSubmit)
                        {
                            task.Status = TaskStatu.Finished;
                            _taskRepo.Update(task);
                            needSave = true;
                        }
                    }
                }

                // Logic C: 自动检测驳回 (如果专家驳回了节点，任务状态自动变更为"被退回")
                if (task.Status == TaskStatu.Reviewing || task.Status == TaskStatu.Submitted)
                {
                    bool hasRejectedNodes = await _evidenceRepo.AnyAsync(e => e.TaskId == task.Id && e.Status == AuditStatus.Rejected);
                    if (hasRejectedNodes)
                    {
                        task.Status = TaskStatu.Returned;
                        _taskRepo.Update(task);
                        needSave = true;
                    }
                }
            }

            if (needSave)
            {
                await _taskRepo.Context.SaveChangesAsync();
            }

            return tasks.Select(t =>
            {
                var batch = batches.ContainsKey(t.BatchId) ? batches[t.BatchId] : null;
                return new SchoolTaskListDto
                {
                    TaskId = t.Id,
                    BatchName = batch?.Name ?? "未知任务",
                    Status = t.Status,
                    UploadStart = batch?.UploadStart,
                    UploadEnd = batch?.UploadEnd,
                    FinalScore = t.FinalScore
                };
            }).ToList();
        }

        // ... GetTaskTree 方法保持不变 ...
        public async Task<List<TaskNodeTreeDto>> GetTaskTree(long taskId)
        {
            // 保持您原有的代码逻辑
            var task = await _taskRepo.FindOrDefaultAsync(taskId);
            if (task == null) throw new Exception("任务不存在");

            List<EvalNodeTreeDto> rawNodes = task.TargetType switch
            {
                OrgType.SpecialSchool => await GetNodesInternal(_speRepo, task.TreeId),
                OrgType.InclusiveSchool => await GetNodesInternal(_incRepo, task.TreeId),
                OrgType.EducationBureau => await GetNodesInternal(_eduRepo, task.TreeId),
                _ => new List<EvalNodeTreeDto>()
            };

            var evidences = await _evidenceRepo.Where(e => e.TaskId == taskId && !e.IsDeleted).ToListAsync();
            var evidenceDict = evidences.ToDictionary(e => e.NodeId, e => e.Status);

            return rawNodes.Select(n => new TaskNodeTreeDto
            {
                Id = n.Id,
                ParentId = n.ParentId,
                Name = n.Name,
                Code = n.Code,
                Type = n.Type,
                MaxScore = n.MaxScore,
                OrderIndex = n.OrderIndex,
                IsCompleted = evidenceDict.ContainsKey(n.Id),
                AuditStatus = evidenceDict.ContainsKey(n.Id) ? evidenceDict[n.Id] : AuditStatus.Pending
            }).ToList();
        }

        // ... GetNodeFillDetail 方法保持不变 (使用您之前修改好的版本) ...
        public async Task<NodeFillDetailDto> GetNodeFillDetail(long taskId, long nodeId)
        {
            // 此处代码较长，请保持上一轮我们修复后的版本，包含 Reference 查找和 TemplateId 查找逻辑
            // 为节省篇幅，此处省略，请确保不要覆盖掉那部分逻辑
            // ... (复制您代码中已有的 GetNodeFillDetail 实现) ...

            var task = await _taskRepo.FindOrDefaultAsync(taskId);
            IEvalNode targetNode = null;
            List<IEvalNode> allNodes = new();

            switch (task.TargetType)
            {
                case OrgType.SpecialSchool:
                    targetNode = await _speRepo.FindOrDefaultAsync(nodeId);
                    allNodes = (await _speRepo.Where(x => x.TreeId == task.TreeId).ToListAsync()).Cast<IEvalNode>().ToList();
                    break;
                case OrgType.InclusiveSchool:
                    targetNode = await _incRepo.FindOrDefaultAsync(nodeId);
                    allNodes = (await _incRepo.Where(x => x.TreeId == task.TreeId).ToListAsync()).Cast<IEvalNode>().ToList();
                    break;
                case OrgType.EducationBureau:
                    targetNode = await _eduRepo.FindOrDefaultAsync(nodeId);
                    allNodes = (await _eduRepo.Where(x => x.TreeId == task.TreeId).ToListAsync()).Cast<IEvalNode>().ToList();
                    break;
            }

            if (targetNode == null) throw new Exception("指标不存在");

            var dto = new NodeFillDetailDto
            {
                NodeId = nodeId,
                TaskId = taskId,
                PointName = targetNode.Name,
                MaxScore = targetNode.MaxScore
            };

            IEvalNode referenceNode = null;
            var current = targetNode;
            while (current.ParentId != null)
            {
                var parent = allNodes.FirstOrDefault(x => x.Id == current.ParentId);
                if (parent == null) break;
                if (parent.Type == EvalNodeType.Reference) { dto.ReferencePoint = parent.Name; referenceNode = parent; }
                else if (parent.Type == EvalNodeType.SecondIndicator) dto.SecondIndicator = parent.Name;
                else if (parent.Type == EvalNodeType.FirstIndicator) dto.FirstIndicator = parent.Name;
                current = parent;
            }

            if (referenceNode == null && targetNode.ParentId.HasValue)
            {
                referenceNode = allNodes.FirstOrDefault(x => x.ParentId == targetNode.ParentId && x.Type == EvalNodeType.Reference);
                if (referenceNode != null) dto.ReferencePoint = referenceNode.Name;
            }

            IEvalNode methodNode = allNodes.FirstOrDefault(x => x.ParentId == targetNode.Id && x.Type == EvalNodeType.Method);
            if (methodNode == null && referenceNode != null)
            {
                methodNode = allNodes.FirstOrDefault(x => x.ParentId == referenceNode.Id && x.Type == EvalNodeType.Method);
            }
            if (methodNode != null) dto.Method = methodNode.Name;

            long? finalTemplateId = targetNode.ScoringTemplateId;
            if (finalTemplateId == null && referenceNode != null) finalTemplateId = referenceNode.ScoringTemplateId;

            if (finalTemplateId.HasValue)
            {
                var modelWithItems = await _modelRepo.Include(x => x.Items)
                                                     .Where(x => x.Id == finalTemplateId.Value && !x.IsDeleted)
                                                     .FirstOrDefaultAsync();
                if (modelWithItems != null && modelWithItems.Items != null)
                {
                    dto.ScoringItems = modelWithItems.Items.Where(x => !x.IsDeleted).OrderBy(x => x.Sort)
                        .Select(x => new ScoringModelItemDto { Id = x.Id, LevelCode = x.LevelCode, Ratio = x.Ratio, Description = x.Description }).ToList();
                }
            }

            var evidence = await _evidenceRepo.FirstOrDefaultAsync(e => e.TaskId == taskId && e.NodeId == nodeId);
            if (evidence != null)
            {
                dto.EvidenceId = evidence.Id;
                dto.MyContent = evidence.Content;
                dto.FileUrls = string.IsNullOrEmpty(evidence.FileUrls) ? new List<string>() : global::System.Text.Json.JsonSerializer.Deserialize<List<string>>(evidence.FileUrls);
                dto.Status = evidence.Status;
                dto.RejectReason = evidence.RejectReason;
            }
            return dto;
        }

        /// <summary>
        /// 提交佐证材料 (核心修复：解决变量重复定义、状态校验、立即保存)
        /// </summary>
        [HttpPost]
        public async Task SubmitEvidence([FromBody] NodeFillDetailDto input)
        {
            // 1. 获取任务信息
            var task = await _taskRepo.FindOrDefaultAsync(input.TaskId);
            if (task == null) throw new Exception("任务不存在");

            // 2. 获取当前佐证记录
            var evidence = await _evidenceRepo.FirstOrDefaultAsync(e => e.TaskId == input.TaskId && e.NodeId == input.NodeId);

            // 3. 安全校验
            if (task.Status == TaskStatu.Returned)
            {
                // 【被退回状态】: 只能修改被驳回的节点
                if (evidence == null || evidence.Status != AuditStatus.Rejected)
                {
                    throw new Exception("当前任务处于【被退回】状态，您只能修改并提交被专家【驳回】的节点。");
                }
            }
            else
            {
                // 【普通状态】: 检查时间和通用状态
                if (!await IsTaskEditable(input.TaskId))
                {
                    throw new Exception("当前不在填报周期内或任务状态不允许提交。");
                }
            }

            // 4. 保存佐证数据
            if (evidence == null)
            {
                // 新增
                evidence = new TaskEvidences
                {
                    TaskId = input.TaskId,
                    NodeId = input.NodeId,
                    CreatedAt = DateTime.Now,
                    Content = input.MyContent,
                    FileUrls = global::System.Text.Json.JsonSerializer.Serialize(input.FileUrls),
                    Status = AuditStatus.Pending,
                    UpdatedAt = DateTime.Now
                };
                await _evidenceRepo.InsertNowAsync(evidence);
            }
            else
            {
                // 更新
                evidence.Content = input.MyContent;
                evidence.FileUrls = global::System.Text.Json.JsonSerializer.Serialize(input.FileUrls);

                // 如果是驳回状态修改后，重置为 Pending (待审核)
                if (evidence.Status == AuditStatus.Rejected)
                {
                    evidence.Status = AuditStatus.Pending;
                }

                evidence.UpdatedAt = DateTime.Now;
                await _evidenceRepo.UpdateNowAsync(evidence);
            }

            // 5. 更新任务主状态 (核心修改部分)
            bool statusChanged = false;

            // 情况 A: 从"未开始/待提交" -> "填报中"
            if (task.Status == TaskStatu.NotStarted || task.Status == TaskStatu.ToSubmit)
            {
                task.Status = TaskStatu.Submitting;
                statusChanged = true;
            }
            // 情况 B: 从"被退回" -> "已提交" (当且仅当所有驳回项都已修复时)
            else if (task.Status == TaskStatu.Returned)
            {
                // 检查数据库中该任务是否还有状态为 Rejected 的节点
                // 注意：当前这个 evidence 已经在上面被改为 Pending 并保存了，所以这里查出来的都是"剩余没改的"
                bool hasRemainingRejected = await _evidenceRepo.AnyAsync(e => e.TaskId == task.Id && e.Status == AuditStatus.Rejected);

                // 如果没有剩余的驳回项了，说明全部修复完毕
                if (!hasRemainingRejected)
                {
                    task.Status = TaskStatu.Submitted; // 改为已提交，等待专家审核
                    statusChanged = true;
                }
            }

            if (statusChanged)
            {
                await _taskRepo.UpdateNowAsync(task);
            }
        }

        private async Task<List<EvalNodeTreeDto>> GetNodesInternal<T>(IRepository<T> repo, long TreeId) where T : class, IEntity, IEvalNode, new()
        {
            var list = await repo.Where(x => !x.IsDeleted && x.TreeId == TreeId)
                                 .OrderBy(x => x.OrderIndex)
                                 .ToListAsync();
            return list.Adapt<List<EvalNodeTreeDto>>();
        }

        #endregion
    }
}