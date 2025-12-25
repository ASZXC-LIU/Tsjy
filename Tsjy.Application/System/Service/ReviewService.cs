using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.ReviewDtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Service
{
    /// <summary>
    /// 专家评审业务服务
    /// </summary>
    public class ReviewService : IScoped, ITransient, IReviewService
    {
        private readonly IRepository<ExpertReview> _expertReviewRepo;
        private readonly IRepository<Tasks> _taskRepo;
        private readonly IRepository<DistributionBatch> _batchRepo;
        private readonly IRepository<Departments> _orgRepo;
        private readonly IRepository<TaskEvidences> _evidenceRepo;
        private readonly IRepository<ScoringModelItem> _scoringItemRepo;

        public ReviewService(
            IRepository<ExpertReview> expertReviewRepo,
            IRepository<Tasks> taskRepo,
            IRepository<DistributionBatch> batchRepo,
            IRepository<Departments> orgRepo,
            IRepository<TaskEvidences> evidenceRepo,
            IRepository<ScoringModelItem> scoringItemRepo)
        {
            _expertReviewRepo = expertReviewRepo;
            _taskRepo = taskRepo;
            _batchRepo = batchRepo;
            _orgRepo = orgRepo;
            _evidenceRepo = evidenceRepo;
            _scoringItemRepo = scoringItemRepo;
        }

        /// <summary>
        /// 获取分配给专家的任务进度列表
        /// </summary>
        public async Task<List<ExpertTaskListDto>> GetExpertTasks(string expertId)
        {
            // 1. 查找分配给该专家的所有评审项
            var reviews = await _expertReviewRepo.AsQueryable()
                .Where(x => x.ReviewerId == expertId && !x.IsDeleted)
                .ToListAsync();

            if (!reviews.Any()) return new List<ExpertTaskListDto>();

            // 2. 获取任务及关联信息
            var taskIds = reviews.Select(r => r.TaskId).Distinct().ToList();
            var tasks = await _taskRepo.Where(t => taskIds.Contains(t.Id)).ToListAsync();
            var batchIds = tasks.Select(t => t.BatchId).Distinct().ToList();
            var batches = await _batchRepo.Where(b => batchIds.Contains(b.Id)).ToDictionaryAsync(b => b.Id, b => b);

            // 获取机构映射（假设 Task.TargetId 对应 Departments.Code 或 Id）
            var orgs = await _orgRepo.AsQueryable().ToListAsync();
            var orgDict = orgs.ToDictionary(o => o.Code, o => o.Name);

            // 3. 组装 DTO
            return tasks.Select(t => {
                var taskReviews = reviews.Where(r => r.TaskId == t.Id).ToList();
                var batch = batches.GetValueOrDefault(t.BatchId);
                return new ExpertTaskListDto
                {
                    TaskId = t.Id,
                    BatchName = batch?.Name ?? "未知任务",
                    SchoolName = orgDict.GetValueOrDefault(t.TargetId) ?? "未知单位",
                    UploadEnd = batch?.UploadEnd,
                    ReviewedCount = taskReviews.Count(r => r.Status == ReviewStatus.Submitted),
                    TotalCount = taskReviews.Count
                };
            }).ToList();
        }

        /// <summary>
        /// 提交专家评审结论
        /// </summary>
    
        public async Task SubmitReview([FromBody] ReviewSubmissionDto input)
        {
            // 1. 更新专家打分记录
            var scoringItem = await _scoringItemRepo.FindOrDefaultAsync(input.ScoringItemId);
            if (scoringItem == null) throw new Exception("评分标准不存在");

            var review = await _expertReviewRepo.FirstOrDefaultAsync(x => x.TaskId == input.TaskId && x.NodeId == input.NodeId);
            if (review == null) throw new Exception("评审分配不存在");

            review.ScoreRatio = scoringItem.Ratio;
            review.FinalScore = review.StandardScore * scoringItem.Ratio;
            review.Status = ReviewStatus.Submitted;
            review.UpdatedAt = DateTime.Now;
            await _expertReviewRepo.UpdateNowAsync(review);

            // 2. 同步更新学校提交的佐证状态
            var evidence = await _evidenceRepo.FirstOrDefaultAsync(e => e.TaskId == input.TaskId && e.NodeId == input.NodeId);
            if (evidence != null)
            {
                evidence.Status = input.AuditStatus;
                evidence.RejectReason = input.AuditStatus == AuditStatus.Rejected ? input.RejectReason : null;
                evidence.UpdatedAt = DateTime.Now;
                await _evidenceRepo.UpdateNowAsync(evidence);
            }
        }

        public async Task<List<ExpertReviewNodeDto>> GetExpertReviewNodes(long taskId, string expertId)
        {
            // 查询该专家在该任务下分配的所有评审记录
            var reviews = await _expertReviewRepo.AsQueryable()
                .Where(x => x.TaskId == taskId && x.ReviewerId == expertId && !x.IsDeleted)
                .OrderBy(x => x.Id) // 维持一个稳定的顺序
                .ToListAsync();

            return reviews.Select(r => new ExpertReviewNodeDto
            {
                NodeId = r.NodeId,
                Status = r.Status
            }).ToList();
        }
    }
}