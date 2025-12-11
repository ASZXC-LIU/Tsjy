using System.ComponentModel;

namespace Tsjy.Core.Enums;

/// <summary>
/// 用户角色
/// </summary>
public enum UserRole
{
    [Description("系统管理员")] Admin,
    [Description("专家")] Expert,
    [Description("评价单位")] SchoolUser,

}

/// <summary>
/// 机构类型
/// </summary>
public enum OrgType
{
    [Description("特殊教育学校")] SpecialSchool,
    [Description("融合教育学校")] InclusiveSchool,
    [Description("教育局")] EducationBureau,
    [Description("其他")] Other
}

/// <summary>
/// 行政级别
/// </summary>
public enum RegionLevel
{
    [Description("省")] Province,
    [Description("市")] City,
    [Description("县/区")] District
}

/// <summary>
/// 评价体系节点类型
/// </summary>
public enum EvalNodeType
{
    [Description("体系根节点")] System,
    [Description("一级指标")] FirstIndicator,
    [Description("二级指标")] SecondIndicator,
    [Description("河北省评估参考点")] Reference,
    [Description("评估要点 (实际打分项)")] Points,
    [Description("评估方法")] Method        // 
                  // 
}

/// <summary>
/// 给评价单位的任务/作业状态流程
/// </summary>
public enum TaskStatu
{
    [Description("待发")] Pending,
    [Description("已下发")] Sent,
    [Description("填报中")] Submitting,
    [Description("已提交")] Submitted,
    [Description("评审中")] Reviewing,
    [Description("被退回")] Returned,
    [Description("已完成")] Finished
}

/// <summary>
/// 单个指标审核状态
/// </summary>
public enum AuditStatus
{
    [Description("待审核")] Pending,
    [Description("通过")] Approved,
    [Description("驳回")] Rejected
}

/// <summary>
/// 巡视任务状态
/// </summary>
public enum InspectionScheduleStatus
{
    [Description("已安排")] Scheduled,
    [Description("正在进行")] InProgress,
    [Description("已完成")] Finished
}

/// <summary>
/// 评审专家评审状态
/// </summary>
public enum ReviewStatus
{
    [Description("待审核")] Pending,
    [Description("草稿 (评审员点了一半没提交)")] Draft,
    [Description("已提交")] Submitted
}

/// <summary>
/// 评审专家评审状态
/// </summary>
public enum PublicStatus
{
    [Description("未开始")]  NotStarted,
    [Description("正在进行")] InProgress,
    [Description("已经结束")] Finished
}