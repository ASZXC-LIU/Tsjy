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
   // ==========================================
    // 1. 评分模板主表种子 (Master)
    // ==========================================
    public class ScoringModelSeed : IEntityTypeBuilder<ScoringModel>, IEntitySeedData<ScoringModel>
    {
        public void Configure(EntityTypeBuilder<ScoringModel> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.Name).IsRequired().HasMaxLength(100);
            
            // ★★★ 核心配置：显式指定一对多关系 ★★★
            // 这样 EF Core 即使没有 [Navigate] 也能正确处理级联
            entityBuilder.HasMany(u => u.Items)
                         .WithOne()
                         .HasForeignKey(u => u.ModelId)
                         .OnDelete(DeleteBehavior.Cascade);
        }

        public IEnumerable<ScoringModel> HasData(DbContext dbContext, Type dbContextLocator)
        {
            // 固定时间，防止每次迁移都检测到变更
            var fixTime = DateTime.Parse("2025-01-01 00:00:00");
            
            return new List<ScoringModel>
            {
                // ID=1: 标准四级制
                new ScoringModel 
                { 
                    Id = 1, 
                    Name = "标准四级制 (A/B/C/D)", 
                    IsDeleted = false, 
                    CreatedAt = fixTime, 
                    UpdatedAt = fixTime 
                },
                // ID=2: 符合性判断
                new ScoringModel 
                { 
                    Id = 2, 
                    Name = "符合性判断 (是/否)", 
                    IsDeleted = false, 
                    CreatedAt = fixTime, 
                    UpdatedAt = fixTime 
                }
            };
        }
    }

    // ==========================================
    // 2. 评分模板明细表种子 (Detail)
    // ==========================================
    public class ScoringModelItemSeed : IEntityTypeBuilder<ScoringModelItem>, IEntitySeedData<ScoringModelItem>
    {
        public void Configure(EntityTypeBuilder<ScoringModelItem> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.LevelCode).HasMaxLength(20);
            entityBuilder.Property(u => u.Description).HasMaxLength(500);
        }

        public IEnumerable<ScoringModelItem> HasData(DbContext dbContext, Type dbContextLocator)
        {
            var fixTime = DateTime.Parse("2025-01-01 00:00:00");
            
            return new List<ScoringModelItem>
            {
                // --- 关联 ModelId = 1 (标准四级制) ---
                new ScoringModelItem { Id = 1, ModelId = 1, LevelCode = "A", Ratio = 1.0m, Description = "优秀/落实到位", Sort = 0, CreatedAt = fixTime, UpdatedAt = fixTime, IsDeleted = false },
                new ScoringModelItem { Id = 2, ModelId = 1, LevelCode = "B", Ratio = 0.8m, Description = "良好/基本落实", Sort = 1, CreatedAt = fixTime, UpdatedAt = fixTime, IsDeleted = false },
                new ScoringModelItem { Id = 3, ModelId = 1, LevelCode = "C", Ratio = 0.6m, Description = "合格/部分落实", Sort = 2, CreatedAt = fixTime, UpdatedAt = fixTime, IsDeleted = false },
                new ScoringModelItem { Id = 4, ModelId = 1, LevelCode = "D", Ratio = 0.0m, Description = "不合格/未落实", Sort = 3, CreatedAt = fixTime, UpdatedAt = fixTime, IsDeleted = false },

                // --- 关联 ModelId = 2 (符合性判断) ---
                new ScoringModelItem { Id = 5, ModelId = 2, LevelCode = "A", Ratio = 1.0m, Description = "符合/是", Sort = 0, CreatedAt = fixTime, UpdatedAt = fixTime, IsDeleted = false },
                new ScoringModelItem { Id = 6, ModelId = 2, LevelCode = "B", Ratio = 0.0m, Description = "不符合/否", Sort = 1, CreatedAt = fixTime, UpdatedAt = fixTime, IsDeleted = false }
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
                new SpeEvalNode { Id = 3, TreeId = treeId, ParentId = 2, Path = "0,1,2", Depth = 2, Type = EvalNodeType.Points, Code = "1.1", Name = "坚持办学方向", MaxScore = 5, ScoringModelId = 1 }
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
                new IncEvalNode { Id = 3, TreeId = treeId, ParentId = 2, Path = "0,1,2", Depth = 2, Type = EvalNodeType.Points, Code = "1.1", Name = "坚持办学方向", MaxScore = 5, ScoringModelId = 1 } };
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
                new EduEvalNode { Id = 3, TreeId = treeId, ParentId = 2, Path = "0,1,2", Depth = 2, Type = EvalNodeType.Points, Code = "1.1", Name = "坚持办学方向", MaxScore = 5, ScoringModelId = 1 } };
        }
    }
}
