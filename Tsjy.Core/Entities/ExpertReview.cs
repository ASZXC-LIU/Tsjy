using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Tsjy.Core.Enums;

namespace Tsjy.Core.Entities;

/// <summary>
/// 专家评审任务分配
/// </summary>

/// <summary>
/// 专家评分明细表 (兼具任务分配表的功能)
/// <para>预生成模式：任务发布时即插入数据，Score 为 NULL</para>
/// </summary>
[Table("expert_reviews")]
[Index(nameof(ReviewerId))] // 场景：专家查询“我的所有任务”
[Index(nameof(TaskId))]     // 场景：查询“某所学校的得失分情况”
[Index(nameof(NodeId))]     // 场景：统计“某个指标的全省得分率”
// 可选的高级优化：复合索引，专家查询待办任务时极快
[Index(nameof(ReviewerId), nameof(Status))]
public class ExpertReview : IEntity
{
    [Key]
    public long Id { get; set; }

    public long TaskId { get; set; }
    public long NodeId { get; set; }
    public string ReviewerId { get; set; }

    [DisplayName("所选系数")]
    public decimal? ScoreRatio { get; set; }

    [DisplayName("标准分")]
    public decimal StandardScore { get; set; }

    [DisplayName("最终得分")]
    public decimal? FinalScore { get; set; }
    [DisplayName("评审状态")]
    public ReviewStatus Status { get; set; } = ReviewStatus.Pending;

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}