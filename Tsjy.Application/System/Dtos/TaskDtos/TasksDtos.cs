using System.ComponentModel.DataAnnotations;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Dtos
{
    /// <summary>
    /// 单位/用户 简要信息 DTO (用于选择列表)
    /// </summary>
    //public class SysUserTargetDto
    //{
    //    // ★★★ 必须是 string，对应 Departments.Code ★★★
    //    public string TargetId { get; set; }

    //    public string OrgName { get; set; }  // 单位名称

    //    // 下面这些字段对于“选单位”来说不是必须的，可以留空，或者用来显示单位负责人
    //    public string RealName { get; set; } // 比如：单位联系人
    //    public string UserName { get; set; }
    //    public string Phone { get; set; }
    //}

    /// <summary>
    /// 管理员分发任务的表单模型
    /// </summary>
    //public class DistributeTaskDto
    //{
    //    [Required(ErrorMessage = "请选择评价体系")]
    //    public long TreeId { get; set; }

    //    [Required(ErrorMessage = "任务名称不能为空")]
    //    public string BatchName { get; set; }

    //    [Required(ErrorMessage = "请选择单位类型")]
    //    public OrgType TargetType { get; set; }

    //    // ★★★ 这里的 ID 是机构的代码 (Code)，所以必须是 string ★★★
    //    public List<string> SelectedTargetIds { get; set; } = new();

    //    public DateTime StartAt { get; set; } = DateTime.Now;
    //    public DateTime DueAt { get; set; } = DateTime.Now.AddDays(30);
    //}

    /// <summary>
    /// 学校端：我的任务列表项
    /// </summary>
    public class SchoolTaskListDto
    {
        public long TaskId { get; set; }
        public string BatchName { get; set; } // 任务名称
        public TaskStatu Status { get; set; }
        public DateTime? UploadStart { get; set; }
        public DateTime? UploadEnd { get; set; }
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
        public List<ScoringModelItemDto> ScoringItems { get; set; } = new();
        // --- 填报内容 ---
        public string MyContent { get; set; }
        public List<string> FileUrls { get; set; } = new();
        //巡视组材料
        public string InspectionContent { get; set; } // 对应 InspectionLog.Findings
        public List<string> InspectionFileUrls { get; set; } = new(); // 对应 InspectionLog.EvidenceFiles
        public long EvidenceId { get; set; }
        public AuditStatus Status { get; set; }
        public string RejectReason { get; set; }
    }
}