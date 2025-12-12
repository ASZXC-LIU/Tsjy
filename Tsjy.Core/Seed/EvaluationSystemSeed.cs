using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Furion.DatabaseAccessor;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Core.Seed
{
    // 评分模板
    public class ScoringModelSeed : IEntityTypeBuilder<ScoringModel>, IEntitySeedData<ScoringModel>
    {
        public void Configure(EntityTypeBuilder<ScoringModel> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.Name).HasMaxLength(100).IsRequired();
        }
        public IEnumerable<ScoringModel> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<ScoringModel> {
                new ScoringModel { Id = 1, Name = "四级评分(A/B/C/D)" },
                new ScoringModel { Id = 2, Name = "是否合格(是/否)" },
                new ScoringModel { Id = 3, Name = "五星评价(1-5星)" }
            };
        }
    }

    public class ScoringModelItemSeed : IEntityTypeBuilder<ScoringModelItem>, IEntitySeedData<ScoringModelItem>
    {
        public void Configure(EntityTypeBuilder<ScoringModelItem> entityBuilder, DbContext dbContext, Type dbContextLocator) { entityBuilder.HasKey(u => u.Id); }
        public IEnumerable<ScoringModelItem> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<ScoringModelItem> {
                new ScoringModelItem { Id = 1, TemplateId = 1, LevelCode = "A", Ratio = 1.0m, Description = "完全符合", Sort = 1 },
                new ScoringModelItem { Id = 2, TemplateId = 1, LevelCode = "B", Ratio = 0.8m, Description = "基本符合", Sort = 2 },
                new ScoringModelItem { Id = 3, TemplateId = 1, LevelCode = "C", Ratio = 0.6m, Description = "部分符合", Sort = 3 },
                new ScoringModelItem { Id = 4, TemplateId = 1, LevelCode = "D", Ratio = 0.0m, Description = "不符合", Sort = 4 },
                new ScoringModelItem { Id = 5, TemplateId = 2, LevelCode = "是", Ratio = 1.0m, Description = "合格", Sort = 1 },
                new ScoringModelItem { Id = 6, TemplateId = 2, LevelCode = "否", Ratio = 0.0m, Description = "不合格", Sort = 2 },
            };
        }
    }

    // 1. 特教评价体系 (SpeEvalNode)
    public class SpeEvalNodeSeed : IEntityTypeBuilder<SpeEvalNode>, IEntitySeedData<SpeEvalNode>
    {
        public void Configure(EntityTypeBuilder<SpeEvalNode> entityBuilder, DbContext dbContext, Type dbContextLocator) { entityBuilder.HasKey(u => u.Id); }
        public IEnumerable<SpeEvalNode> HasData(DbContext dbContext, Type dbContextLocator)
        {
            var list = new List<SpeEvalNode>();
            long id = 10000;

            // --- 树1: 2025 特教新国标 ---
            long tree1 = 202501;
            list.Add(new SpeEvalNode { Id = id++, TreeId = tree1, ParentId = null, Path = "0", Depth = 0, Type = EvalNodeType.System, Name = "2025特教学校办学质量评价", MaxScore = 100 });
            long root1 = id - 1;

            list.Add(new SpeEvalNode { Id = id++, TreeId = tree1, ParentId = root1, Path = $"0,{root1}", Depth = 1, Type = EvalNodeType.FirstIndicator, Code = "1", Name = "办学方向", MaxScore = 20 });
            long l1 = id - 1;
            list.Add(new SpeEvalNode { Id = id++, TreeId = tree1, ParentId = l1, Path = $"0,{root1},{l1}", Depth = 2, Type = EvalNodeType.SecondIndicator, Code = "1.1", Name = "党的领导", MaxScore = 10 });
            long l1_1 = id - 1;
            list.Add(new SpeEvalNode { Id = id++, TreeId = tree1, ParentId = l1_1, Path = $"0,{root1},{l1},{l1_1}", Depth = 3, Type = EvalNodeType.Points, Code = "1.1.1", Name = "党建工作常态化", MaxScore = 10, ScoringTemplateId = 2 });

            list.Add(new SpeEvalNode { Id = id++, TreeId = tree1, ParentId = root1, Path = $"0,{root1}", Depth = 1, Type = EvalNodeType.FirstIndicator, Code = "2", Name = "教育教学", MaxScore = 40 });
            long l2 = id - 1;
            list.Add(new SpeEvalNode { Id = id++, TreeId = tree1, ParentId = l2, Path = $"0,{root1},{l2}", Depth = 2, Type = EvalNodeType.SecondIndicator, Code = "2.1", Name = "个别化教育", MaxScore = 20 });
            long l2_1 = id - 1;
            list.Add(new SpeEvalNode { Id = id++, TreeId = tree1, ParentId = l2_1, Path = $"0,{root1},{l2},{l2_1}", Depth = 3, Type = EvalNodeType.Reference, Code = "2.1.1", Name = "IEP制定规范", MaxScore = 10 });
            long l2_1_1 = id - 1;
            list.Add(new SpeEvalNode { Id = id++, TreeId = tree1, ParentId = l2_1_1, Path = $"0,{root1},{l2},{l2_1},{l2_1_1}", Depth = 4, Type = EvalNodeType.Method, Name = "查阅10份学生档案，检查IEP要素是否齐全。" });
            list.Add(new SpeEvalNode { Id = id++, TreeId = tree1, ParentId = l2_1, Path = $"0,{root1},{l2},{l2_1}", Depth = 3, Type = EvalNodeType.Points, Code = "2.1.2", Name = "IEP实施效果", MaxScore = 10, ScoringTemplateId = 1 });

            // --- 树2: 2024 历史版本 ---
            long tree2 = 202401;
            list.Add(new SpeEvalNode { Id = id++, TreeId = tree2, ParentId = null, Path = "0", Depth = 0, Type = EvalNodeType.System, Name = "2024河北省特教质量监测", MaxScore = 100 });
            long root2 = id - 1;
            list.Add(new SpeEvalNode { Id = id++, TreeId = tree2, ParentId = root2, Path = $"0,{root2}", Depth = 1, Type = EvalNodeType.FirstIndicator, Code = "A", Name = "校园安全", MaxScore = 50 });
            long la = id - 1;
            list.Add(new SpeEvalNode { Id = id++, TreeId = tree2, ParentId = la, Path = $"0,{root2},{la}", Depth = 2, Type = EvalNodeType.Points, Code = "A-1", Name = "无障碍设施", MaxScore = 50, ScoringTemplateId = 1 });

            return list;
        }
    }

    // 2. 融合教育评价体系 (IncEvalNode)
    public class IncEvalNodeSeed : IEntityTypeBuilder<IncEvalNode>, IEntitySeedData<IncEvalNode>
    {
        public void Configure(EntityTypeBuilder<IncEvalNode> entityBuilder, DbContext dbContext, Type dbContextLocator) { entityBuilder.HasKey(u => u.Id); }
        public IEnumerable<IncEvalNode> HasData(DbContext dbContext, Type dbContextLocator)
        {
            var list = new List<IncEvalNode>();
            long id = 20000;
            long treeId = 202502; // 融合树ID

            list.Add(new IncEvalNode { Id = id++, TreeId = treeId, ParentId = null, Path = "0", Depth = 0, Type = EvalNodeType.System, Name = "2025随班就读质量监测", MaxScore = 100 });
            long root = id - 1;

            list.Add(new IncEvalNode { Id = id++, TreeId = treeId, ParentId = root, Path = $"0,{root}", Depth = 1, Type = EvalNodeType.FirstIndicator, Code = "1", Name = "资源教室", MaxScore = 50 });
            long l1 = id - 1;
            list.Add(new IncEvalNode { Id = id++, TreeId = treeId, ParentId = l1, Path = $"0,{root},{l1}", Depth = 2, Type = EvalNodeType.Points, Code = "1.1", Name = "资源教师配备", MaxScore = 25, ScoringTemplateId = 2 });
            list.Add(new IncEvalNode { Id = id++, TreeId = treeId, ParentId = l1, Path = $"0,{root},{l1}", Depth = 2, Type = EvalNodeType.Points, Code = "1.2", Name = "设备使用率", MaxScore = 25, ScoringTemplateId = 1 });

            list.Add(new IncEvalNode { Id = id++, TreeId = treeId, ParentId = root, Path = $"0,{root}", Depth = 1, Type = EvalNodeType.FirstIndicator, Code = "2", Name = "融合文化", MaxScore = 50 });
            long l2 = id - 1;
            list.Add(new IncEvalNode { Id = id++, TreeId = treeId, ParentId = l2, Path = $"0,{root},{l2}", Depth = 2, Type = EvalNodeType.Points, Code = "2.1", Name = "普特融合活动", MaxScore = 50, ScoringTemplateId = 1 });

            return list;
        }
    }

    // 3. 局端评价体系 (EduEvalNode)
    public class EduEvalNodeSeed : IEntityTypeBuilder<EduEvalNode>, IEntitySeedData<EduEvalNode>
    {
        public void Configure(EntityTypeBuilder<EduEvalNode> entityBuilder, DbContext dbContext, Type dbContextLocator) { entityBuilder.HasKey(u => u.Id); }
        public IEnumerable<EduEvalNode> HasData(DbContext dbContext, Type dbContextLocator)
        {
            var list = new List<EduEvalNode>();
            long id = 30000;
            long treeId = 202503; // 局端树ID

            list.Add(new EduEvalNode { Id = id++, TreeId = treeId, ParentId = null, Path = "0", Depth = 0, Type = EvalNodeType.System, Name = "2025区域特教发展评价", MaxScore = 100 });
            long root = id - 1;

            list.Add(new EduEvalNode { Id = id++, TreeId = treeId, ParentId = root, Path = $"0,{root}", Depth = 1, Type = EvalNodeType.FirstIndicator, Code = "1", Name = "经费保障", MaxScore = 60 });
            long l1 = id - 1;
            list.Add(new EduEvalNode { Id = id++, TreeId = treeId, ParentId = l1, Path = $"0,{root},{l1}", Depth = 2, Type = EvalNodeType.Points, Code = "1.1", Name = "生均公用经费标准", MaxScore = 60, ScoringTemplateId = 1 });

            list.Add(new EduEvalNode { Id = id++, TreeId = treeId, ParentId = root, Path = $"0,{root}", Depth = 1, Type = EvalNodeType.FirstIndicator, Code = "2", Name = "入学率", MaxScore = 40 });
            long l2 = id - 1;
            list.Add(new EduEvalNode { Id = id++, TreeId = treeId, ParentId = l2, Path = $"0,{root},{l2}", Depth = 2, Type = EvalNodeType.Points, Code = "2.1", Name = "义务教育入学率", MaxScore = 40, ScoringTemplateId = 1 });

            return list;
        }
    }
}