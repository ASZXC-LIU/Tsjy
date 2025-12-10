using System.ComponentModel.DataAnnotations;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Dtos
{
    // 分发任务表单
    public class DistributeTaskDto
    {
        [Required(ErrorMessage = "请选择评价体系")]
        public long TreeId { get; set; }

        [Required(ErrorMessage = "任务名称不能为空")]
        public string BatchName { get; set; }

        [Required(ErrorMessage = "请选择单位类型")]
        public OrgType TargetType { get; set; }

        public List<long> SelectedTargetIds { get; set; } = new(); // 选中的学校/单位ID

        public DateTime StartAt { get; set; } = DateTime.Now;
        public DateTime DueAt { get; set; } = DateTime.Now.AddDays(30);
    }

    // 学校端任务列表视图
    public class SchoolTaskListDto
    {
        public long TaskId { get; set; }
        public string BatchName { get; set; } // 批次/任务名称
        public TaskStatu Status { get; set; }
        public DateTime DueAt { get; set; }
        public decimal? FinalScore { get; set; }
        public int Progress { get; set; }
    }

    // 填报界面的树节点状态（带完成状态）
    public class TaskNodeTreeDto : EvalNodeTreeDto
    {
        public bool IsCompleted { get; set; } // 是否已填报
        public AuditStatus AuditStatus { get; set; } // 审核状态
    }

    // 节点填报详情（右侧区域显示的内容）
    public class NodeFillDetailDto
    {
        public long NodeId { get; set; }
        public long TaskId { get; set; }

        // 用于显示的层级信息
        public string FirstIndicator { get; set; }
        public string SecondIndicator { get; set; }
        public string ReferencePoint { get; set; }
        public string PointName { get; set; }
        public string Method { get; set; }
        public decimal? MaxScore { get; set; }
        public string Description { get; set; }

        // 填报内容
        public string MyContent { get; set; }
        public List<string> FileUrls { get; set; } = new();
        public long EvidenceId { get; set; }
        public AuditStatus Status { get; set; }
        public string RejectReason { get; set; }
    }
}