using System;
using System.Collections.Generic;
using BootstrapBlazor.Components;
using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;
using Tsjy.Core.MyHelper;

namespace Tsjy.Core.Seed
{

        // 评分模板主表种子
        public class ScoringModelSeed : IEntityTypeBuilder<ScoringModel>, IEntitySeedData<ScoringModel>
        {
            public void Configure(EntityTypeBuilder<ScoringModel> entityBuilder, DbContext dbContext, Type dbContextLocator)
            {
                entityBuilder.HasKey(u => u.Id);
                entityBuilder.Property(u => u.Name).HasMaxLength(100).IsRequired();
            }

            public IEnumerable<ScoringModel> HasData(DbContext dbContext, Type dbContextLocator)
            {
                return new List<ScoringModel>
            {
                new ScoringModel { Id = 1, Name = "通用四级评分标准(A/B/C/D)", CreatedAt = DateTime.UtcNow }
            };
            }
        }

        // 评分模板明细种子
        public class ScoringModelItemSeed : IEntityTypeBuilder<ScoringModelItem>, IEntitySeedData<ScoringModelItem>
        {
            public void Configure(EntityTypeBuilder<ScoringModelItem> entityBuilder, DbContext dbContext, Type dbContextLocator)
            {
                entityBuilder.HasKey(u => u.Id);
                entityBuilder.Property(u => u.LevelCode).HasMaxLength(20).IsRequired();
            }

            public IEnumerable<ScoringModelItem> HasData(DbContext dbContext, Type dbContextLocator)
            {
                return new List<ScoringModelItem>
            {
                new ScoringModelItem { Id = 1, TemplateId = 1, LevelCode = "A", Ratio = 1.0m, Description = "完全符合指标要求，佐证材料详实", Sort = 1, CreatedAt = DateTime.UtcNow },
                new ScoringModelItem { Id = 2, TemplateId = 1, LevelCode = "B", Ratio = 0.8m, Description = "基本符合，存在少量非关键性缺失", Sort = 2, CreatedAt = DateTime.UtcNow },
                new ScoringModelItem { Id = 3, TemplateId = 1, LevelCode = "C", Ratio = 0.6m, Description = "部分符合，存在明显问题或材料不足", Sort = 3, CreatedAt = DateTime.UtcNow },
                new ScoringModelItem { Id = 4, TemplateId = 1, LevelCode = "D", Ratio = 0.0m, Description = "不符合要求或未开展此项工作", Sort = 4, CreatedAt = DateTime.UtcNow }
            };
            }
        }
    

    // 特教评价指标种子 (SpeEvalNode)
    public class SpeEvalNodeSeed : IEntityTypeBuilder<SpeEvalNode>, IEntitySeedData<SpeEvalNode>
    {
        public void Configure(EntityTypeBuilder<SpeEvalNode> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
        }

        public IEnumerable<SpeEvalNode> HasData(DbContext dbContext, Type dbContextLocator)
        {
            long treeId = 202501;
            return new List<SpeEvalNode>
            {
                new SpeEvalNode { Id = 1, TreeId = treeId, ParentId = null, Path = "0", Depth = 0, Type = EvalNodeType.System, Name = "河北省特教评价2025", MaxScore = 100 },
                new SpeEvalNode { Id = 2, TreeId = treeId, ParentId = 1, Path = "0,1", Depth = 1, Type = EvalNodeType.FirstIndicator, Code = "1", Name = "办学方向", MaxScore = 20 },
                new SpeEvalNode { Id = 3, TreeId = treeId, ParentId = 2, Path = "0,1,2", Depth = 2, Type = EvalNodeType.Points, Code = "1.1", Name = "坚持办学方向", MaxScore = 5, ScoringTemplateId = 1 }
            };
        }
    }

    // 融合教育与教育局指标 (简单示例，结构同上)
    public class IncEvalNodeSeed : IEntityTypeBuilder<IncEvalNode>, IEntitySeedData<IncEvalNode>
    {
        public void Configure(EntityTypeBuilder<IncEvalNode> entityBuilder, DbContext dbContext, Type dbContextLocator) { entityBuilder.HasKey(u => u.Id); }
        public IEnumerable<IncEvalNode> HasData(DbContext dbContext, Type dbContextLocator)
        {
            long treeId = 202501;
            return new List<IncEvalNode> { 
                new IncEvalNode { Id = 1, TreeId = treeId, ParentId = null, Path = "0", Depth = 0, Type = EvalNodeType.System, Name = "河北省特教评价2025", MaxScore = 100 },
                new IncEvalNode { Id = 2, TreeId = treeId, ParentId = 1, Path = "0,1", Depth = 1, Type = EvalNodeType.FirstIndicator, Code = "1", Name = "办学方向", MaxScore = 20 },
                new IncEvalNode { Id = 3, TreeId = treeId, ParentId = 2, Path = "0,1,2", Depth = 2, Type = EvalNodeType.Points, Code = "1.1", Name = "坚持办学方向", MaxScore = 5, ScoringTemplateId = 1 } };
        }
    }

    public class EduEvalNodeSeed : IEntityTypeBuilder<EduEvalNode>, IEntitySeedData<EduEvalNode>
    {
        public void Configure(EntityTypeBuilder<EduEvalNode> entityBuilder, DbContext dbContext, Type dbContextLocator) { entityBuilder.HasKey(u => u.Id); }
        public IEnumerable<EduEvalNode> HasData(DbContext dbContext, Type dbContextLocator)
        {
            long treeId = 202501;
            return new List<EduEvalNode> {
                 new EduEvalNode { Id = 1, TreeId = treeId, ParentId = null, Path = "0", Depth = 0, Type = EvalNodeType.System, Name = "河北省特教评价2025", MaxScore = 100 },
                new EduEvalNode { Id = 2, TreeId = treeId, ParentId = 1, Path = "0,1", Depth = 1, Type = EvalNodeType.FirstIndicator, Code = "1", Name = "办学方向", MaxScore = 20 },
                new EduEvalNode { Id = 3, TreeId = treeId, ParentId = 2, Path = "0,1,2", Depth = 2, Type = EvalNodeType.Points, Code = "1.1", Name = "坚持办学方向", MaxScore = 5, ScoringTemplateId = 1 } };
        }
    }
}
