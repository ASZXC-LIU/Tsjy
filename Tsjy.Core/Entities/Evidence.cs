using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furion.DatabaseAccessor;
using Tsjy.Core.Enums;

namespace Tsjy.Core.Entities;

/// <summary>
/// 指标佐证材料 (学校填写的)
/// </summary>
[Table("task_evidences")]
public class TaskEvidences : IEntity
{
    [Key]
    public long Id { get; set; }

    [DisplayName("任务ID")]
    public long TaskId { get; set; }

    [DisplayName("指标ID")]
    public long NodeId { get; set; }

    [DisplayName("自评说明")]
    public string Content { get; set; }

    [DisplayName("文件列表")]
    [Column(TypeName = "json")]
    public string FileUrls { get; set; } // ["url1", "url2"]

    [DisplayName("审核状态")]
    public AuditStatus Status { get; set; } = AuditStatus.Pending;

    [DisplayName("驳回意见")]
    [MaxLength(512)]
    public string RejectReason { get; set; }

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}

/// <summary>
/// AI 预评价分析
/// </summary>
[Table("ai_pre_evaluations")]
public class AiPreEvaluation : IEntity
{
    [Key]
    public long Id { get; set; }
    public long UserId { get; set; }
    public long TaskId { get; set; }
    public long NodeId { get; set; }
    public long EvidenceId { get; set; }

    [DisplayName("AI建议得分")]
    public decimal? SuggestedScore { get; set; }

    [DisplayName("风险等级")]
    public string RiskLevel { get; set; } // low, medium, high

    [DisplayName("分析报告")]
    public string AnalysisReport { get; set; }

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}