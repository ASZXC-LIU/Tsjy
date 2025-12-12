using System.ComponentModel.DataAnnotations;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Dtos.BatchDtos;

public class BatchListDto
{
    public long Id { get; set; }

    public string Name { get; set; }

    public PublicStatus Status { get; set; }

    // 覆盖机构数量
    public int OrgCount { get; set; }

    public DateTime CreatedAt { get; set; }

    // 修改：新增 IsDeleted，用于控制启用/禁用 (IsDeleted = true 即为禁用)
    public bool IsDeleted { get; set; }
    // 辅助属性：是否启用（用于绑定 Switch）
    // 辅助属性：UI绑定用的“是否启用”，逻辑取反
    public bool IsEnabled
    {
        get => !IsDeleted;
        set => IsDeleted = !value;
    }
    // 新增：任务开始时间
    public DateTime? StartAt { get; set; }

    // 新增：任务截止时间
    public DateTime? DueAt { get; set; }
    // ★★★ 新增：用于列表展示 ★★★
    public OrgType TargetType { get; set; } // 对象类型枚举
    public string TreeName { get; set; }    // 评价体系名称
    public long TreeId { get; set; }        // 体系ID(用于查询名称)
}

public class BatchInputDto
{
    public long Id { get; set; }

    [Required(ErrorMessage = "请输入批次名称")]
    public string Name { get; set; }
    [Required(ErrorMessage = "请选择适用机构类型")]
    public OrgType? TargetType { get; set; }

    // 新增：评价体系ID
    [Required(ErrorMessage = "请选择评价体系")]
    public long? TreeId { get; set; }
    public PublicStatus Status { get; set; } = PublicStatus.NotStarted;
    public DateTime? StartAt { get; set; } = DateTime.Now;
    public DateTime? DueAt { get; set; } = DateTime.Now.AddDays(7);
    // 如果有其他字段如 TreeId 也可以在这里添加
}