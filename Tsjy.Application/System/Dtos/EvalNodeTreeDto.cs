using System.ComponentModel;
using Tsjy.Core.Enums; // 引用你的枚举命名空间

namespace Tsjy.Application.System.Dtos;

public class EvalNodeTreeDto
{
    public long Id { get; set; }

    public long? ParentId { get; set; }
    public long? TreeId { get; set; }
    public string Name { get; set; }

    public string Code { get; set; }
    public long? ScoringTemplateId { get; set; }
    public EvalNodeType Type { get; set; } // 节点类型

    public decimal? MaxScore { get; set; } // 最高分（可选，用于树上展示分值）

    public int OrderIndex { get; set; } // 排序字段

    // 关键字段：用于存储递归的子节点列表
    public List<EvalNodeTreeDto> Children { get; set; } = new();
}

public class EvalSystemListDto
{
    public long Id { get; set; } // 体系ID (即根节点的ID)
    public string Name { get; set; } // 体系名称
    public string Category { get; set; } // 体系类型 (special_school, etc.)
    public int NodeCount { get; set; } // (可选) 该体系下有多少个指标

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}