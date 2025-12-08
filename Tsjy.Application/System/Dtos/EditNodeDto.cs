using Tsjy.Core.Enums; // 引用你的枚举命名空间

namespace Tsjy.Application.System.Dtos;
/// <summary>
/// 新建评价指标节点 DTO
/// </summary>
public class EditNodeDto
{
    /// <summary>
    /// 目标体系类型：special_school, inclusive_school, education_bureau
    /// </summary>
    [Required]
    public string Category { get; set; } 
// / <summary>
//     / 父节点ID (根节点父ID为0，但在创建子节点时必传>0)
//     / </summary>
    [Required]
    // 必填：父节点ID
    public long ParentId { get; set; }

    // 表单数据
    public string Code { get; set; }           // 序号 (1.1)
    /// <summary>
    /// 指标内容
    /// </summary>
    [Required]
    public string Name { get; set; }           // 指标内容
    /// <summary>
    /// 该指标满分
    /// </summary>
    public decimal? MaxScore { get; set; }     // 标准分
    /// <summary>
    /// 评分模板ID，关联 scoring_models 表
    /// </summary>
    [Required]
    public long ScoringModelId { get; set; }   // 评分模板ID
    public int OrderIndex { get; set; }        // 排序
}