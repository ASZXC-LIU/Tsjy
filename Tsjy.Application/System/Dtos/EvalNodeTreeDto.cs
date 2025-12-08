using Tsjy.Core.Enums; // 引用你的枚举命名空间

namespace Tsjy.Application.System.Dtos;

public class EvalNodeTreeDto
{
    public long Id { get; set; }

    public long? ParentId { get; set; }
    public long? TreeId { get; set; }
    public string Name { get; set; }

    public string Code { get; set; }
    public long? ScoringModelId { get; set; }
    public EvalNodeType Type { get; set; } // 节点类型

    public decimal? MaxScore { get; set; } // 最高分（可选，用于树上展示分值）

    public int OrderIndex { get; set; } // 排序字段

    // 关键字段：用于存储递归的子节点列表
    public List<EvalNodeTreeDto> Children { get; set; } = new();
}