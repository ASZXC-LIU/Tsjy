using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using Furion.DatabaseAccessor;
using Tsjy.Core.Enums;
using Microsoft.EntityFrameworkCore;
namespace Tsjy.Core.Entities;

/// <summary>
/// 任务分发批次
/// </summary>
[Table("distribution_batches")]
public class DistributionBatch : IEntity
{
    [Key]
    public long Id { get; set; }

    [DisplayName("评价体系ID")]
    public long TreeId { get; set; }
    // ★★★ 新增：直接存储该批次针对的机构类型 ★★★
    [DisplayName("适用对象类型")]
    public OrgType TargetType { get; set; }
    [DisplayName("批次名称")]
    [MaxLength(255)]
    public string Name { get; set; }

    [DisplayName("状态")]
    public PublicStatus Status { get; set; }

    public bool IsDeleted { get; set; } = false;
    // --- 原有字段作为总时间 (可选保留或计算) ---
    public DateTime StartAt { get; set; } = DateTime.UtcNow;
    [DisplayName("截止时间")]
    public DateTime DueAt { get; set; }

    // ★★★ 新增：三个阶段的时间控制 ★★★

    [DisplayName("填报开始时间")]
    public DateTime? UploadStart { get; set; }
    [DisplayName("填报截止时间")]
    public DateTime? UploadEnd { get; set; }

    [DisplayName("评审开始时间")]
    public DateTime? ReviewStart { get; set; }
    [DisplayName("评审截止时间")]
    public DateTime? ReviewEnd { get; set; }

    [DisplayName("视导开始时间")]
    public DateTime? InspectionStart { get; set; }
    [DisplayName("视导截止时间")]
    public DateTime? InspectionEnd { get; set; }
    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}


/// <summary>
/// 具体的学校评价任务单
/// </summary>
[Table("tasks")]
public class Tasks : IEntity
{
    [Key]
    public long Id { get; set; }

    public long BatchId { get; set; }

    public long TreeId { get; set; }

    [DisplayName("对象类型")]
    public OrgType TargetType { get; set; }

    [DisplayName("学校ID")]
    public string TargetId { get; set; }

    [DisplayName("当前状态")]
    public TaskStatu Status { get; set; } = TaskStatu.Pending;

  

    public DateTime? SubmittedAt { get; set; }

    [DisplayName("最终得分")]
    public decimal? FinalScore { get; set; }

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}