// Tsjy.Application/System/Dtos/InspectionDtos/InspectorTaskDto.cs
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Dtos.InspectionDtos;

public class InspectorTaskDto
{
    public long ScheduleId { get; set; } // 视导行程ID (操作的核心Key)
    public long TaskId { get; set; }     // 关联的考评任务ID (用于加载指标树)
    public string TaskName { get; set; }
    public string SchoolName { get; set; } // 受评单位
    public string TeamName { get; set; }   // 所属小组
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public InspectionScheduleStatus Status { get; set; }
}

public class InspectionLogInputDto
{
    public long ScheduleId { get; set; }
    public long NodeId { get; set; }
    public string Findings { get; set; } // 现场文字记录
    public List<string> FileUrls { get; set; } = new(); // 文件的URL列表
}