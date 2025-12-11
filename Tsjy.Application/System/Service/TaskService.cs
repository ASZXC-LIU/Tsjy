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
    public class TaskService : IDynamicApiController, ITransient
    {
        private readonly IRepository<DistributionBatch> _batchRepo;
        private readonly IRepository<BatchTarget> _batchTargetRepo;
        private readonly IRepository<Tasks> _taskRepo;
        private readonly IRepository<AssignmentEvidence> _evidenceRepo;
        private readonly IRepository<Departments> _orgRepo;
        // 修改：注入 SysUsers 仓储
        private readonly IRepository<SysUsers> _userRepo;

        private readonly IRepository<SpeEvalNode> _speRepo;
        private readonly IRepository<IncEvalNode> _incRepo;
        private readonly IRepository<EduEvalNode> _eduRepo;

        public TaskService(
            IRepository<DistributionBatch> batchRepo,
            IRepository<BatchTarget> batchTargetRepo,
            IRepository<Tasks> taskRepo,
            IRepository<AssignmentEvidence> evidenceRepo,
            IRepository<SysUsers> userRepo,
            IRepository<Departments> orgRepo, // Update
            IRepository<SpeEvalNode> speRepo,
            IRepository<IncEvalNode> incRepo,
            IRepository<EduEvalNode> eduRepo)
        {
            _batchRepo = batchRepo;
            _batchTargetRepo = batchTargetRepo;
            _taskRepo = taskRepo;
            _evidenceRepo = evidenceRepo;
            _userRepo = userRepo;
            _orgRepo = orgRepo;
            _speRepo = speRepo;
            _incRepo = incRepo;
            _eduRepo = eduRepo;
        }

        #region 管理员：分发任务

        /// <summary>
        /// 获取待选单位列表 (根据类型)
        /// </summary>
        public async Task<List<SysUserTargetDto>> GetTargetsByType(OrgType type)
        {

            var query = from u in _userRepo.AsQueryable()
                        join o in _orgRepo.AsQueryable() on u.OrgId equals o.Code
                        where !u.IsDeleted && u.Role == UserRole.SchoolUser
                        // 如果机构表里也有 type 字段，可以在这里加筛选： && o.Type == type
                        select new SysUserTargetDto
                        {
                            TargetId = u.OrgId,
                            IDNumber = u.IDNumber,

                            // ★★★ 关键：获取机构表的名字 ★★★
                            OrgName = o.Name,

                            // 优先显示用户真实姓名，没有则显示账号
                            RealName = string.IsNullOrEmpty(u.RealName) ? u.UserName : u.RealName,
                            UserName = u.UserName,
                            Phone = u.Phone
                        };

            return await query.ToListAsync();
        }

        /// <summary>
        /// 发布任务
        /// </summary>
        [HttpPost]
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

            // input.SelectedTargetIds 此时存的是 OrgId
            foreach (var orgId in input.SelectedTargetIds)
            {
                // 记录批次目标
                batchTargets.Add(new BatchTarget
                {
                    BatchId = batchEntity.Entity.Id,
                    OrgId = orgId, // 存 OrgId
                    CreatedAt = DateTime.Now
                });

                // 生成任务单
                tasks.Add(new Tasks
                {
                    BatchId = batchEntity.Entity.Id,
                    TreeId = input.TreeId,
                    TargetType = input.TargetType,
                    TargetId = orgId, // 存 OrgId
                    Status = TaskStatu.Pending,
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
        /// <param name="myOrgId">当前登录用户的 OrgId</param>
        public async Task<List<SchoolTaskListDto>> GetMyTasks(string myOrgId)
        {
            // 查找 TargetId 等于我的 OrgId 的任务
            var tasks = await _taskRepo.AsQueryable()
                .Where(t => t.TargetId == myOrgId && !t.IsDeleted)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            if (!tasks.Any()) return new List<SchoolTaskListDto>();

            var batchIds = tasks.Select(t => t.BatchId).Distinct().ToList();
            var batches = await _batchRepo.Where(b => batchIds.Contains(b.Id))
                                          .ToDictionaryAsync(b => b.Id, b => b.Name);

            return tasks.Select(t => new SchoolTaskListDto
            {
                TaskId = t.Id,
                BatchName = batches.ContainsKey(t.BatchId) ? batches[t.BatchId] : "未知任务",
                Status = t.Status,
                DueAt = t.DueAt,
                FinalScore = t.FinalScore
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
            if (evidence.Status == AuditStatus.Rejected) evidence.Status = AuditStatus.Pending;
            evidence.UpdatedAt = DateTime.Now;

            await _evidenceRepo.UpdateAsync(evidence);

            var task = await _taskRepo.FindOrDefaultAsync(input.TaskId);
            if (task.Status == TaskStatu.Pending || task.Status == TaskStatu.Sent || task.Status == TaskStatu.Returned)
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
            return list.Adapt<List<EvalNodeTreeDto>>();
        }
        #endregion
    }
}