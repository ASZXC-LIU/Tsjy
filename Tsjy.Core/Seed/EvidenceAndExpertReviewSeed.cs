using System;
using System.Collections.Generic;
using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;
using Tsjy.Core.MyHelper;

namespace Tsjy.Core.Seed
{
    // 佐证材料种子
    public class AssignmentEvidenceSeed : IEntityTypeBuilder<TaskEvidences>, IEntitySeedData<TaskEvidences>
    {
        public void Configure(EntityTypeBuilder<TaskEvidences> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.FileUrls).HasColumnType("json");
        }

        public IEnumerable<TaskEvidences> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<TaskEvidences>
            {
                new TaskEvidences
                {
                    Id = 1, TaskId = 1, NodeId = 3, Content = "自评报告内容...",
                    FileUrls = "[\"http://file/a.pdf\"]", Status = AuditStatus.Pending, CreatedAt = DateTime.UtcNow
                }
            };
        }
    }

    // AI 预评价种子
    public class AiPreEvaluationSeed : IEntityTypeBuilder<AiPreEvaluation>, IEntitySeedData<AiPreEvaluation>
    {
        public void Configure(EntityTypeBuilder<AiPreEvaluation> entityBuilder, DbContext dbContext, Type dbContextLocator) { entityBuilder.HasKey(u => u.Id); }

        public IEnumerable<AiPreEvaluation> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<AiPreEvaluation>
            {
                new AiPreEvaluation { Id = 1, UserId = 1, TaskId = 1, NodeId = 3, EvidenceId = 1, SuggestedScore = 4.5m, RiskLevel = "low", AnalysisReport = "AI分析通过" }
            };
        }
    }

    // 专家分配种子
    

    // 专家评分种子
    public class ExpertReviewSeed : IEntityTypeBuilder<ExpertReview>, IEntitySeedData<ExpertReview>
    {
        public void Configure(EntityTypeBuilder<ExpertReview> entityBuilder, DbContext dbContext, Type dbContextLocator) { entityBuilder.HasKey(u => u.Id); }

        public IEnumerable<ExpertReview> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<ExpertReview>
            {
                new ExpertReview { Id = 1, TaskId = 1, NodeId = 3, ReviewerId = "100", ScoreRatio = 0.8m, StandardScore = 5, FinalScore = 4.0m, CreatedAt = DateTime.UtcNow }
            };
        }
    }
}
