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

    // 辅助属性：是否启用（用于绑定 Switch）
    public bool IsEnabled { get; set; }

    // 新增：任务开始时间
    public DateTime? StartAt { get; set; }

    // 新增：任务截止时间
    public DateTime? DueAt { get; set; }
}

public class BatchInputDto
{
    public long Id { get; set; }

    [Required(ErrorMessage = "请输入批次名称")]
    public string Name { get; set; }

    public PublicStatus Status { get; set; } = PublicStatus.NotStarted;

    // 如果有其他字段如 TreeId 也可以在这里添加
}