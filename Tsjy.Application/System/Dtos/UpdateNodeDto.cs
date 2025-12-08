using System.ComponentModel.DataAnnotations;

namespace Tsjy.Application.System.Dtos;

/// <summary>
/// 更新节点信息 DTO
/// </summary>
public class UpdateNodeDto
{
    /// <summary>
    /// 节点主键 ID
    /// </summary>
    [Required]
    public long Id { get; set; }

    /// <summary>
    /// 体系类型 (用于确定操作哪张表)
    /// </summary>
    [Required]
    public string Category { get; set; }

    /// <summary>
    /// 序号 (如 1.1)
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// 指标名称
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// 标准分
    /// </summary>
    public decimal? MaxScore { get; set; }

    /// <summary>
    /// 评分模板ID
    /// </summary>
    public long? ScoringModelId { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int OrderIndex { get; set; }

    // 注意：这里故意不包含 ParentId。
    // 修改父节点属于“移动/剪切”操作，涉及复杂的 Path/Depth 递归更新，不建议在普通编辑中处理。
}