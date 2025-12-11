using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furion.DatabaseAccessor;
using Tsjy.Core.Enums;

namespace Tsjy.Core.Entities;
/// <summary>
/// 评分模板主表
/// </summary>
[Table("scoring_templates")]
public class ScoringModel :  IEntity
{
    [Key] // 主键
    public long Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } // 模板名称

  

    public bool IsDeleted { get; set; } = false; // 软删除
    public List<ScoringModelItem> Items { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

   
}

/// <summary>
/// 评分模板明细表 (存具体选项)
/// </summary>
[Table("scoring_template_items")]
public class ScoringModelItem :  IEntity
{
    [Key]
    public long Id { get; set; }

    public long TemplateId { get; set; } // 外键

    [MaxLength(20)]
    public string LevelCode { get; set; } // A, B, C...

    public decimal Ratio { get; set; } // 系数: 1.0, 0.8

    [MaxLength(500)]
    public string Description { get; set; } // 描述

    public int Sort { get; set; } // 排序
    public bool IsDeleted { get; set; } = false; // 软删除
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

/// <summary>
/// 评价体系指标节点
/// </summary>
[Table("spe_eval_nodes")]
public class SpeEvalNode : IEntity, IEvalNode
{
    [Key]
    public long Id { get; set; }

    [DisplayName("体系版本ID")]
    public long TreeId { get; set; }

    [DisplayName("父节点ID")]
    public long? ParentId { get; set; }

    [DisplayName("层级路径")]
    [MaxLength(512)]
    public string Path { get; set; }
    [DisplayName("深度")]
    public int Depth { get; set; }

    [DisplayName("节点类型")]
    public EvalNodeType Type { get; set; } // 'system','first_indicator','second_indicator','reference','points','method'

    [DisplayName("序号")]
    [MaxLength(64)]
    public string Code { get; set; } // 如 1.1.1

    [DisplayName("指标内容")]
    public string Name { get; set; }

    [DisplayName("最高分值")]
    public decimal? MaxScore { get; set; }

 

    [DisplayName("评分模板ID")]
    public long? ScoringTemplateId { get; set; }

    public int OrderIndex { get; set; } = 0;

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}

/// <summary>
/// 评价体系指标节点
/// </summary>
[Table("inc_eval_nodes")]
public class IncEvalNode : IEntity, IEvalNode
{
    [Key]
    public long Id { get; set; }

    [DisplayName("体系版本ID")]
    public long TreeId { get; set; }

    [DisplayName("父节点ID")]
    public long? ParentId { get; set; }

    [DisplayName("层级路径")]
    [MaxLength(512)]
    public string Path { get; set; }
    [DisplayName("深度")]
    public int Depth { get; set; }

    [DisplayName("节点类型")]
    public EvalNodeType Type { get; set; } // 'system','first_indicator','second_indicator','reference','points','method'

    [DisplayName("序号")]
    [MaxLength(64)]
    public string Code { get; set; } // 如 1.1.1

    [DisplayName("指标内容")]
    public string Name { get; set; }

    [DisplayName("最高分值")]
    public decimal? MaxScore { get; set; }



    [DisplayName("评分模板ID")]
    public long? ScoringTemplateId { get; set; }

    public int OrderIndex { get; set; } = 0;

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}

/// <summary>
/// 评价体系指标节点
/// </summary>
[Table("edu_eval_nodes")]
public class EduEvalNode : IEntity, IEvalNode
{
    [Key]
    public long Id { get; set; }

    [DisplayName("体系版本ID")]
    public long TreeId { get; set; }

    [DisplayName("父节点ID")]
    public long? ParentId { get; set; }

    [DisplayName("层级路径")]
    [MaxLength(512)]
    public string Path { get; set; }
    [DisplayName("深度")]
    public int Depth { get; set; }

    [DisplayName("节点类型")]
    public EvalNodeType Type { get; set; } // 'system','first_indicator','second_indicator','reference','points','method'

    [DisplayName("序号")]
    [MaxLength(64)]
    public string Code { get; set; } // 如 1.1.1

    [DisplayName("指标内容")]
    public string Name { get; set; }

    [DisplayName("最高分值")]
    public decimal? MaxScore { get; set; }



    [DisplayName("评分模板ID")]
    public long? ScoringTemplateId { get; set; }

    public int OrderIndex { get; set; } = 0;

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}