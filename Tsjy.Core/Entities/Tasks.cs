using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furion.DatabaseAccessor;
using Tsjy.Core.Enums;

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

    [DisplayName("批次名称")]
    [MaxLength(255)]
    public string Name { get; set; }

    [DisplayName("状态")]
    public PublicStatus Status { get; set; } 

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}

/// <summary>
/// 批次涉及的评价对象名单
/// </summary>
[Table("batch_targets")]
public class BatchTarget : IEntity
{
    [Key]
    public long Id { get; set; }

    public long BatchId { get; set; }

    [DisplayName("机构类型")]
    public OrgType OrgType { get; set; }

    public long OrgId { get; set; }


    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}

/// <summary>
/// 具体的学校评价任务单
/// </summary>
[Table("assignments")]
public class Assignment : IEntity
{
    [Key]
    public long Id { get; set; }

    public long BatchId { get; set; }

    public long TreeId { get; set; }

    [DisplayName("对象类型")]
    public OrgType TargetType { get; set; }

    [DisplayName("学校ID")]
    public long TargetId { get; set; }

    [DisplayName("当前状态")]
    public AssignmentStatus Status { get; set; } = AssignmentStatus.Pending;

    public DateTime StartAt { get; set; } = DateTime.UtcNow;

    [DisplayName("截止时间")]
    public DateTime DueAt { get; set; }

    public DateTime? SubmittedAt { get; set; }

    [DisplayName("最终得分")]
    public decimal? FinalScore { get; set; }

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}