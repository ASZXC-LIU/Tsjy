using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization; // 必须引用这个
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

    // 注入身份验证状态提供程序
    [Inject]
    [NotNull]
    private AuthenticationStateProvider? AuthenticationStateProvider { get; set; }

    [NotNull]
    private Chart? LineChart { get; set; }

    private List<HistoryTaskDto> TaskItems { get; set; } = new();
    private HistoryTaskDto BestScore { get; set; } = new();
    private List<ChartDataDto> TrendData { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        // 1. 获取当前用户的身份状态
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        // 2. 提取 OrgId (确保 Claim 名称与你存入 Token 时的一致，注意区分大小写)
        var orgId = user.FindFirst("OrgId")?.Value;

        if (!string.IsNullOrEmpty(orgId))
        {
            // 3. 将 orgId 传给后端
            //TaskItems = await HistoryService.GetHistoryListAsync(orgId);
            //BestScore = await HistoryService.GetBestScoreAsync(orgId);
            //TrendData = await HistoryService.GetScoreTrendAsync(orgId);
        }
        else
        {
            // 处理未登录或没有 OrgId 的情况（可选：跳转登录或显示空）
            // NavigationManager.NavigateTo("/login");
        }
    }

    private Task<ChartDataSource> OnInit()
    {
        var ds = new ChartDataSource();
        ds.Options.Responsive = true;
        ds.Options.MaintainAspectRatio = false;

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

    private void OnFill(HistoryTaskDto item)
    {
        NavigationManager.NavigateTo($"/School/DoTask/{item.Id}");
    }

    private void OnViewDetail(HistoryTaskDto item)
    {
        NavigationManager.NavigateTo($"/School/TaskDetail/{item.Id}");
    }
}