using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
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
        // 修改：注入 SysUsers 仓储
        private readonly IRepository<SysUsers> _userRepo;

        private readonly IRepository<SpeEvalNode> _speRepo;
        private readonly IRepository<IncEvalNode> _incRepo;
        private readonly IRepository<EduEvalNode> _eduRepo;
        private readonly IRepository<ScoringModelItem> _scoringItemRepo;
        public TaskService(
            IRepository<ScoringModelItem> scoringItemRepo,
            IRepository<DistributionBatch> batchRepo,
            IRepository<Tasks> taskRepo,
            IRepository<TaskEvidences> evidenceRepo,
            IRepository<SysUsers> userRepo,
            IRepository<Departments> orgRepo, // Update
            IRepository<SpeEvalNode> speRepo,
            IRepository<IncEvalNode> incRepo,
            IRepository<EduEvalNode> eduRepo)
        {
            _scoringItemRepo = scoringItemRepo;
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

        public async Task<bool> IsTaskEditable(long taskId)
        {
            var task = await _taskRepo.FindOrDefaultAsync(taskId);
            if (task == null) return false;

            // 1. 状态校验：适配新枚举
            // 允许：待提交、填报中、被退回
            bool isStatusAllow = task.Status == TaskStatu.ToSubmit ||
                                 task.Status == TaskStatu.Submitting ||
                                 task.Status == TaskStatu.Returned;

            if (!isStatusAllow) return false;

            // 2. 时间校验 (保持不变)
            var batch = await _batchRepo.FindOrDefaultAsync(task.BatchId);
            if (batch != null)
            {
                var now = DateTime.Now;
                if (batch.UploadStart.HasValue && now < batch.UploadStart.Value) return false;
                // 注意：虽然有自动结束逻辑，但这里保留时间检查作为双重保险
                if (batch.UploadEnd.HasValue && now > batch.UploadEnd.Value) return false;
            }

            return true;
        }

        /// <summary>
        /// 获取我的任务列表
        /// </summary>
        /// <param name="myOrgId">当前登录用户的 OrgId</param>
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
                if (batches.TryGetValue(task.BatchId, out var batch))
                {
                    // Logic A: 自动开始
                    // 如果是 "未开始" 且 时间已到 -> 变为 "待提交"
                    if (task.Status == TaskStatu.NotStarted && batch.UploadStart.HasValue && now >= batch.UploadStart.Value)
                    {
                        task.Status = TaskStatu.ToSubmit;
                        _taskRepo.Update(task);
                        needSave = true;
                    }

                    // Logic B: 自动结束 (响应您的新需求)
                    // 当时间超过 截止时间，且状态仍在 "填报中" (或 "待提交")，则自动结束。
                    if (batch.UploadEnd.HasValue && now > batch.UploadEnd.Value)
                    {
                        // 只要是还没提交的状态，统统结束
                        if (task.Status == TaskStatu.Submitting || task.Status == TaskStatu.ToSubmit)
                        {
                            task.Status = TaskStatu.Finished; // 自动变为 已完成 (或视需求改为 Submitted)
                            _taskRepo.Update(task);
                            needSave = true;
                        }
                    }
                }
            }

            if (needSave)
            {
                await _taskRepo.Context.SaveChangesAsync();
            }
            // 3. 组装 DTO
            return tasks.Select(t =>
            {
                // 尝试获取对应的 Batch
                var batch = batches.ContainsKey(t.BatchId) ? batches[t.BatchId] : null;

                return new SchoolTaskListDto
                {
                    TaskId = t.Id,
                    BatchName = batch?.Name ?? "未知任务", // 如果 batch 不为空则取 Name
                    Status = t.Status,

                    // ★★★ 核心修复：赋值时间 ★★★
                    UploadStart = batch?.UploadStart,
                    UploadEnd = batch?.UploadEnd,

                    FinalScore = t.FinalScore
                };
            }).ToList();
        }

        /// <summary>
        /// 获取任务详情树 (带填报状态)
        /// </summary>
        public async Task<List<TaskNodeTreeDto>> GetTaskTree(long taskId)
        {
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

        /// <summary>
        /// 获取单个节点的详细填报信息
        /// </summary>
        public async Task<NodeFillDetailDto> GetNodeFillDetail(long taskId, long nodeId)
        {
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

            var current = targetNode;
            while (current.ParentId != null)
            {
                var parent = allNodes.FirstOrDefault(x => x.Id == current.ParentId);
                if (parent == null) break;
                if (parent.Type == EvalNodeType.Reference) dto.ReferencePoint = parent.Name;
                else if (parent.Type == EvalNodeType.SecondIndicator) dto.SecondIndicator = parent.Name;
                else if (parent.Type == EvalNodeType.FirstIndicator) dto.FirstIndicator = parent.Name;
                current = parent;
            }

            var methodNode = allNodes.FirstOrDefault(x => x.ParentId == nodeId && x.Type == EvalNodeType.Method);
            if (methodNode != null) dto.Method = methodNode.Name;


            if (targetNode.ScoringTemplateId.HasValue)
            {
                var items = await _scoringItemRepo.Where(x => x.TemplateId == targetNode.ScoringTemplateId.Value && !x.IsDeleted)
                                                  .OrderBy(x => x.Sort)
                                                  .ToListAsync();
                dto.ScoringItems = items.Select(x => new ScoringModelItemDto
                {
                    Id = x.Id,
                    LevelCode = x.LevelCode,
                    Ratio = x.Ratio,
                    Description = x.Description
                }).ToList();
            }

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

        [HttpPost]
        public async Task SubmitEvidence([FromBody] NodeFillDetailDto input)
        {

            // --- 新增：强制时间与状态校验 ---
            if (!await IsTaskEditable(input.TaskId))
            {
                throw new Exception("当前不在填报周期内或任务状态不允许提交，操作已拒绝。");
            }
            // -----------------------------

            var evidence = await _evidenceRepo.FirstOrDefaultAsync(e => e.TaskId == input.TaskId && e.NodeId == input.NodeId);
           
            if (evidence == null)
            {
                evidence = new TaskEvidences
                {
                    TaskId = input.TaskId,
                    NodeId = input.NodeId,
                    CreatedAt = DateTime.Now
                };
                await _evidenceRepo.InsertAsync(evidence);
            }

            evidence.Content = input.MyContent;
            evidence.FileUrls = global::System.Text.Json.JsonSerializer.Serialize(input.FileUrls);
            if (evidence.Status == AuditStatus.Rejected) evidence.Status = AuditStatus.Pending;
            evidence.UpdatedAt = DateTime.Now;

            await _evidenceRepo.UpdateAsync(evidence);

            var task = await _taskRepo.FindOrDefaultAsync(input.TaskId);
            if (task.Status == TaskStatu.NotStarted || task.Status == TaskStatu.ToSubmit || task.Status == TaskStatu.Returned)
            {
                task.Status = TaskStatu.Submitting;
                await _taskRepo.UpdateAsync(task);
            }
        }

        private async Task<List<EvalNodeTreeDto>> GetNodesInternal<T>(IRepository<T> repo, long TreeId) where T : class, IEntity, IEvalNode, new()
        {
            var list = await repo.Where(x => !x.IsDeleted && x.TreeId == TreeId)
                                 .OrderBy(x => x.OrderIndex)
                                 .ToListAsync();
            Console.WriteLine("1111");
            Console.WriteLine("1111");
            Console.WriteLine("1111");
            return list.Adapt<List<EvalNodeTreeDto>>();
        }



        
        #endregion
    }
}