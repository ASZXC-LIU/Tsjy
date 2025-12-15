using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furion.DatabaseAccessor;
using Tsjy.Core.Enums;

namespace Tsjy.Core.Entities;

/// <summary>
/// 视导小组
/// </summary>
[Table("inspection_teams")]
public class InspectionTeam : IEntity
{
    [Key]
    public long Id { get; set; }

    public long BatchId { get; set; }

    [DisplayName("小组名称")]
    [MaxLength(100)]
    public string Name { get; set; }

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}

/// <summary>
/// 小组成员
/// </summary>
[Table("inspection_team_members")]
public class InspectionTeamMember : IEntity
{
    [Key]
    public long Id { get; set; }

    public long TeamId { get; set; }
    public string UserId { get; set; }

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}

/// <summary>
/// 视导行程安排
/// </summary>
[Table("inspection_schedules")]
public class InspectionSchedule : IEntity
{
    [Key]
    public long Id { get; set; }

    [DisplayName("关联任务")]
    public long AssignmentId { get; set; }

    [DisplayName("负责小组")]
    public long TeamId { get; set; }

    public DateTime VisitStartAt { get; set; }
    public DateTime VisitEndAt { get; set; }

    [DisplayName("状态")]
    public InspectionScheduleStatus Status { get; set; } // scheduled, in_progress, completed

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}

/// <summary>
/// 视导员现场取证记录
/// </summary>
[Table("inspection_logs")]
public class InspectionLog : IEntity
{
    [Key]
    public long Id { get; set; }

    public long ScheduleId { get; set; }
    public long NodeId { get; set; }


    [DisplayName("现场记录")]
    public string Findings { get; set; }

    [DisplayName("现场素材")]
    [Column(TypeName = "json")]
    public string EvidenceFiles { get; set; } // 录音/照片

    public long CreatedBy { get; set; }
    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}