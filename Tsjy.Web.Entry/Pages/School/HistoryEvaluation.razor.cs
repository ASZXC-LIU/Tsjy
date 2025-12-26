using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Diagnostics.CodeAnalysis;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.History;
using Tsjy.Application.System.IService;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.School;

public partial class HistoryEvaluation
{
    [Inject]
    [NotNull]
    private IHistoryService? HistoryService { get; set; }

    [Inject]
    [NotNull]
    private ITaskService? TaskService { get; set; } // 注入任务服务

    [Inject]
    [NotNull]
    private NavigationManager? NavigationManager { get; set; }

    [Inject]
    [NotNull]
    private AuthenticationStateProvider? AuthenticationStateProvider { get; set; }

    [NotNull]
    private Chart? LineChart { get; set; }

    // 数据模型
    private HistoryTaskDto BestScore { get; set; } = new();
    private List<ChartDataDto> TrendData { get; set; } = new();

    // 任务列表
    private List<SchoolTaskListDto> AllTasks { get; set; } = new();
    private List<SchoolTaskListDto> ActiveTasks { get; set; } = new();
    private List<SchoolTaskListDto> FinishedTasks { get; set; } = new();

    // KPI 统计
    private int TotalTasks => FinishedTasks.Count;
    private double AvgScore => FinishedTasks.Any(x => x.FinalScore.HasValue)
        ? (double)FinishedTasks.Average(x => x.FinalScore.Value)
        : 0;
    private decimal? LastScore => FinishedTasks.OrderByDescending(x => x.UploadEnd).FirstOrDefault()?.FinalScore;
    private int PendingCount => ActiveTasks.Count;

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        var orgId = user.FindFirst("OrgId")?.Value;
        var userId = user.FindFirst("UserId")?.Value;

        if (!string.IsNullOrEmpty(orgId))
        {
            // 1. 获取图表和最高分数据
            BestScore = await HistoryService.GetBestScoreAsync(orgId);
            TrendData = await HistoryService.GetScoreTrendAsync(orgId);
        }

        if (!string.IsNullOrEmpty(userId))
        {
            // 2. 获取所有任务用于列表和待办
            AllTasks = await TaskService.GetMyTasks(userId);

            // 拆分为进行中和已归档
            // 假设 TaskStatu.Completed 或 FinalScore 有值视为归档
            ActiveTasks = AllTasks.Where(x => x.Status != TaskStatu.Finished).ToList();
            FinishedTasks = AllTasks.Where(x => x.Status == TaskStatu.Finished && x.FinalScore.HasValue)
                                    .OrderByDescending(x => x.UploadEnd)
                                    .ToList();
        }
    }

    private Task<ChartDataSource> OnInit()
    {
        return Task.FromResult(GenerateDataSource());
    }

    private ChartDataSource GenerateDataSource()
    {
        var ds = new ChartDataSource();
        ds.Options.Responsive = true;
        ds.Options.MaintainAspectRatio = false;

        if (TrendData == null || !TrendData.Any())
        {
            ds.Labels = new List<string> { "暂无数据" };
            return ds;
        }

        ds.Labels = TrendData.Select(x => x.Label).ToList();
        var dataset = new ChartDataset()
        {
            Label = "考核得分",
            Data = TrendData.Select(x => (object)x.Score).ToList(),
            BackgroundColor = new string[] { "rgba(13, 110, 253, 0.2)" },
            BorderColor = new string[] { "#0d6efd" },
            Fill = true,
            Tension = 0.4f,
            PointRadius = 4
        };
        ds.Data.Add(dataset);
        return ds;
    }

    private void OnDoTask(long taskId)
    {
        // 跳转到填报页面
        NavigationManager.NavigateTo($"/School/DoTask/{taskId}");
    }
}