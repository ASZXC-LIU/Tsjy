using Tsjy.Core.Entities;
using System.Collections.Generic;

namespace Tsjy.Application.System.Dtos.BatchDtos;

/// <summary>
/// 任务分发提交对象
/// </summary>
public class BatchDistributeDto
{
    /// <summary>
    /// 批次ID
    /// </summary>
    public long BatchId { get; set; }

    /// <summary>
    /// 步骤1：选中的机构ID集合 (受评单位)
    /// </summary>
    public List<string> SelectedOrgIds { get; set; } = new();

    /// <summary>
    /// 步骤2：视导组成员ID集合 (用户ID)
    /// </summary>
    public List<string> InspectionGroupUserIds { get; set; } = new();

    /// <summary>
    /// 步骤3：指标与专家的对应关系
    /// </summary>
    public List<NodeExpertRelationDto> ExpertAllocations { get; set; } = new();
}

/// <summary>
/// 节点与专家分配关系
/// </summary>
public class NodeExpertRelationDto
{
    public long NodeId { get; set; }       // 二级指标ID
    public string NodeName { get; set; }   // 指标名称
    public string Code { get; set; }       // 指标编号

    // 分配的专家ID集合 (绑定 MultiSelect)
    // 修复：MultiSelect 绑定 List<string> 最为稳定
    public List<string> SelectedExpertIds { get; set; } = new();
}