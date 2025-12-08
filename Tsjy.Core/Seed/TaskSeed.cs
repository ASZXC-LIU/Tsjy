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
    // 任务批次种子
    public class DistributionBatchSeed : IEntityTypeBuilder<DistributionBatch>, IEntitySeedData<DistributionBatch>
    {
        public void Configure(EntityTypeBuilder<DistributionBatch> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
        }

        public IEnumerable<DistributionBatch> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<DistributionBatch>
            {
                new DistributionBatch { Id = 1, TreeId = 202501, Name = "2025年度第一次普查", Status = PublicStatus.finalized, CreatedAt = DateTime.UtcNow }
            };
        }
    }

    // 批次名单种子
    public class BatchTargetSeed : IEntityTypeBuilder<BatchTarget>, IEntitySeedData<BatchTarget>
    {
        public void Configure(EntityTypeBuilder<BatchTarget> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
        }

        public IEnumerable<BatchTarget> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<BatchTarget>
            {
                new BatchTarget { Id = 1, BatchId = 1, OrgType = OrgType.SpecialSchool, OrgId = 1, CreatedAt = DateTime.UtcNow }
            };
        }
    }

    // 任务单种子
    public class AssignmentSeed : IEntityTypeBuilder<Assignment>, IEntitySeedData<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
        }

        public IEnumerable<Assignment> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<Assignment>
            {
                new Assignment
                {
                    Id = 1, BatchId = 1, TreeId = 202501, TargetType = OrgType.SpecialSchool, TargetId = 1,
                    Status = AssignmentStatus.Submitting, StartAt = DateTime.UtcNow, DueAt = DateTime.UtcNow.AddDays(7),
                    CreatedAt = DateTime.UtcNow
                }
            };
        }
    }
}
