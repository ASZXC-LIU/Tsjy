using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Diagnostics.CodeAnalysis;
using Tsjy.Application.System.Dtos.History;
using Tsjy.Application.System.IService;

namespace Tsjy.Web.Entry.Pages.School;

public partial class HistoryEvaluation
{
    [Inject]
    [NotNull]
    private IHistoryService? HistoryService { get; set; }

    [Inject]
    [NotNull]
    private NavigationManager? NavigationManager { get; set; }

    [Inject]
    [NotNull]
    private AuthenticationStateProvider? AuthenticationStateProvider { get; set; }

    [NotNull]
    private Chart? LineChart { get; set; }

    // 移除了 TaskItems，因为表格已删除
    private HistoryTaskDto BestScore { get; set; } = new();
    private List<ChartDataDto> TrendData { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        // 1. 获取当前用户的身份状态
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        // 2. 提取 OrgId
        var orgId = user.FindFirst("OrgId")?.Value;

        if (!string.IsNullOrEmpty(orgId))
        {
            // 3. 启用数据获取
            BestScore = await HistoryService.GetBestScoreAsync(orgId);
            TrendData = await HistoryService.GetScoreTrendAsync(orgId);

        }
    }

    private Task<ChartDataSource> OnInit()
    {
        var ds = new ChartDataSource();
        ds.Options.Responsive = true;
        ds.Options.MaintainAspectRatio = false;

        // 设置 X 轴标签
        ds.Labels = TrendData.Select(x => x.Label).ToList();

        var dataset = new ChartDataset()
        {
            Label = "考核得分",
            Data = TrendData.Select(x => (object)x.Score).ToList(),
            BackgroundColor = new string[] { "rgba(13, 110, 253, 0.2)" },
            BorderColor = new string[] { "#0d6efd" },
            Fill = true,
            Tension = 0.4f,
            PointRadius = 5,
            PointHoverRadius = 7
        };

        ds.Data.Add(dataset);

        return Task.FromResult(ds);
    }

    // 移除了 OnFill 和 OnViewDetail 方法
}