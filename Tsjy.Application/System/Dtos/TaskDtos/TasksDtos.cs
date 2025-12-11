using System.ComponentModel.DataAnnotations;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Dtos
{
    /// <summary>
    /// 单位/用户 简要信息 DTO (用于选择列表)
    /// </summary>
    public class SysUserTargetDto
    {
        // 这里返回 OrgId 作为选择的值，因为任务是发给 Org 的
        public string TargetId { get; set; }
        public string OrgName { get; set; }
        public string IDNumber { get; set; } // 用户身份证/主键
        public string RealName { get; set; }     // 显示名称 (RealName 或 UserName)
        public string UserName { get; set; }  // 账号
        public string Phone { get; set; }
    }

    /// <summary>
    /// 管理员分发任务的表单模型
    /// </summary>
    public class DistributeTaskDto
    {
        [Required(ErrorMessage = "请选择评价体系")]
        public long TreeId { get; set; }

        [Required(ErrorMessage = "任务名称不能为空")]
        public string BatchName { get; set; }

        [Required(ErrorMessage = "请选择单位类型")]
        public OrgType TargetType { get; set; }

        // 选中的 OrgId 列表 (注意：这里存的是 OrgId)
        public List<string> SelectedTargetIds { get; set; } = new();

        public DateTime StartAt { get; set; } = DateTime.Now;
        public DateTime DueAt { get; set; } = DateTime.Now.AddDays(30);
    }

    /// <summary>
    /// 学校端：我的任务列表项
    /// </summary>
    public class SchoolTaskListDto
    {
        public long TaskId { get; set; }
        public string BatchName { get; set; } // 任务名称
        public TaskStatu Status { get; set; }
        public DateTime DueAt { get; set; }
        public decimal? FinalScore { get; set; }
    }

    /// <summary>
    /// 填报界面：左侧树节点
    /// </summary>
    public class TaskNodeTreeDto : EvalNodeTreeDto
    {
        public bool IsCompleted { get; set; } // 是否已填报
        public AuditStatus AuditStatus { get; set; } // 审核状态
    }

    /// <summary>
    /// 填报界面：右侧填报详情
    /// </summary>
    public class NodeFillDetailDto
    {
        public long NodeId { get; set; }
        public long TaskId { get; set; }

        // --- 上下文信息 ---
        public string FirstIndicator { get; set; }
        public string SecondIndicator { get; set; }
        public string ReferencePoint { get; set; }
        public string PointName { get; set; }
        public string Method { get; set; }
        public decimal? MaxScore { get; set; }

        // --- 填报内容 ---
        public string MyContent { get; set; }
        public List<string> FileUrls { get; set; } = new();
        public long EvidenceId { get; set; }
        public AuditStatus Status { get; set; }
        public string RejectReason { get; set; }
    }
}