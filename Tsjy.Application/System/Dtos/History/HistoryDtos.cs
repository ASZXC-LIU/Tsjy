namespace Tsjy.Application.System.Dtos.History;

public class HistoryTaskDto
{
    public long Id { get; set; }

    // 批次名称
    public string BatchName { get; set; }

    // 体系版本 (如果无法直接获取，暂时用批次名代替或留空)
    public string Version { get; set; }

    // 状态文本
    public string Status { get; set; }

    // 状态枚举值（用于前端判断颜色）
    public string StatusCode { get; set; }

    // 最终得分
    public decimal? FinalScore { get; set; } // 注意：数据库是 decimal?

    // 排名
    public string Rank { get; set; }

    // 年份
    public int Year { get; set; }
}
public sealed class HistoryEvalTrendPointDto
{
    public DateTime Date { get; set; }          // 该点日期（按天聚合就用当天 00:00）
    public int UploadCount { get; set; }        // 当天上传/提交次数
    public int ApprovedCount { get; set; }      // 当天审核通过次数
    public int RejectedCount { get; set; }      // 当天审核驳回次数
}
public class ChartDataDto
{
    public string Label { get; set; }
    public decimal Score { get; set; }
}