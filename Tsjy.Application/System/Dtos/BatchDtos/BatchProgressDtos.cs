using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Dtos.BatchDtos;

public class BatchProgressDetailDto
{
    public long BatchId { get; set; }

    // 1. 单位填报进度列表
    public List<OrgProgressDto> OrgProgresses { get; set; } = new();

    // 2. 专家评审进度列表
    public List<ExpertProgressDto> ExpertProgresses { get; set; } = new();

    // 3. 视导组情况
    public List<InspectionGroupDto> InspectionGroups { get; set; } = new();
}

public class OrgProgressDto
{
    public string TargetId { get; set; } // 机构代码
    public string OrgName { get; set; }
    public TaskStatu Status { get; set; }
    public DateTime? SubmittedAt { get; set; }
}

public class ExpertProgressDto
{
    public string ExpertId { get; set; }
    public string ExpertName { get; set; }

    // 任务统计
    public int TotalTasks { get; set; }     // 该专家负责的总指标数(或总学校数，看统计维度)
    public int CompletedTasks { get; set; } // 已打分数量

    public double ProgressRate { get; set; }
}

public class InspectionGroupDto
{
    public long TeamId { get; set; }
    public string TeamName { get; set; }
    public List<string> MemberNames { get; set; } = new(); // 组员姓名列表

    // 视导任务状态 (假设视导是按学校安排日程的)
    public int ScheduledCount { get; set; } // 已安排数
    public int FinishedCount { get; set; }  // 已完成数
}