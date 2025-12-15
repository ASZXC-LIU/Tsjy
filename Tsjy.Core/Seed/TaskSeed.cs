using System;
using System.Collections.Generic;
using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Core.Seed
{
    // 1. 任务批次 (Batch - 带时间)
    public class DistributionBatchSeed : IEntityTypeBuilder<DistributionBatch>, IEntitySeedData<DistributionBatch>
    {
        public void Configure(EntityTypeBuilder<DistributionBatch> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
        }

        public IEnumerable<DistributionBatch> HasData(DbContext dbContext, Type dbContextLocator)
        {
            var list = new List<DistributionBatch>();
            long id = 10000;

            // 批次1: 特教普查 (特教树 202501)
            list.Add(new DistributionBatch { Id = id++, TreeId = 202501, Name = "2025年特教学校春季普查", Status = PublicStatus.InProgress, StartAt = DateTime.UtcNow.AddDays(-10), DueAt = DateTime.UtcNow.AddDays(20) });

            // 批次2: 融合监测 (融合树 202502)
            list.Add(new DistributionBatch { Id = id++, TreeId = 202502, Name = "海淀区随班就读质量监测", Status = PublicStatus.NotStarted, StartAt = DateTime.UtcNow.AddDays(5), DueAt = DateTime.UtcNow.AddDays(35) });

            // 批次3: 局端评估 (局端树 202503)
            list.Add(new DistributionBatch { Id = id++, TreeId = 202503, Name = "2025区域特教发展绩效评价", Status = PublicStatus.InProgress, StartAt = DateTime.UtcNow.AddDays(-2), DueAt = DateTime.UtcNow.AddDays(15) });

            // 批次4: 历史任务 (特教树 202401)
            list.Add(new DistributionBatch { Id = id++, TreeId = 202401, Name = "2024年终考核存档", Status = PublicStatus.Finished, StartAt = DateTime.UtcNow.AddYears(-1), DueAt = DateTime.UtcNow.AddYears(-1).AddDays(30) });

            return list;
        }
    }

    

    // 3. 任务单 (Tasks - 移除了StartAt/DueAt的赋值)
    public class TaskSeed : IEntityTypeBuilder<Tasks>, IEntitySeedData<Tasks>
    {
        public void Configure(EntityTypeBuilder<Tasks> entityBuilder, DbContext dbContext, Type dbContextLocator) { entityBuilder.HasKey(u => u.Id); }
        public IEnumerable<Tasks> HasData(DbContext dbContext, Type dbContextLocator)
        {
            long id = 30000;
            return new List<Tasks>
            {
                // 特教任务
                new Tasks { Id = id++, BatchId = 10000, TreeId = 202501, TargetType = OrgType.SpecialSchool, TargetId = "110105_SPE_01", Status = TaskStatu.Submitting },
                new Tasks { Id = id++, BatchId = 10000, TreeId = 202501, TargetType = OrgType.SpecialSchool, TargetId = "130100_SPE_01", Status = TaskStatu.Submitted, SubmittedAt = DateTime.UtcNow.AddDays(-1) },

                // 融合任务
                new Tasks { Id = id++, BatchId = 10001, TreeId = 202502, TargetType = OrgType.InclusiveSchool, TargetId = "110108_INC_01", Status = TaskStatu.Pending },

                // 局端任务
                new Tasks { Id = id++, BatchId = 10002, TreeId = 202503, TargetType = OrgType.EducationBureau, TargetId = "110105_EDU", Status = TaskStatu.Reviewing, SubmittedAt = DateTime.UtcNow.AddDays(-2) },

                // 历史任务 (已完成)
                new Tasks { Id = id++, BatchId = 10003, TreeId = 202401, TargetType = OrgType.SpecialSchool, TargetId = "130400_SPE_01", Status = TaskStatu.Finished, SubmittedAt = DateTime.UtcNow.AddYears(-1), FinalScore = 88.5m }
            };
        }
    }
}