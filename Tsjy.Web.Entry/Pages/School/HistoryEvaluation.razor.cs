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

    private HistoryTaskDto BestScore { get; set; } = new();
    private List<ChartDataDto> TrendData { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        var orgId = user.FindFirst("OrgId")?.Value;

        if (!string.IsNullOrEmpty(orgId))
        {
            // 1. 获取数据
            BestScore = await HistoryService.GetBestScoreAsync(orgId);
            TrendData = await HistoryService.GetScoreTrendAsync(orgId);

           
        }
    }

    /// <summary>
    /// Chart 组件初始化回调
    /// </summary>
    private Task<ChartDataSource> OnInit()
    {
        return Task.FromResult(GenerateDataSource());
    }

    /// <summary>
    /// 生成图表数据源
    /// </summary>
    private ChartDataSource GenerateDataSource()
    {
        var ds = new ChartDataSource();

        ds.Options.Responsive = true;
        ds.Options.MaintainAspectRatio = false;

        // 【优化】建议 Y 轴范围为 0-100，这样即使只有85分，也会显示在图表上方而不是顶格
        // 如果您的版本报错 CS1061，请注释掉下面这两行
 

        if (TrendData == null || !TrendData.Any())
        {
            ds.Labels = new List<string> { "暂无数据" };
            return ds;
        }

        // 设置 X 轴
        ds.Labels = TrendData.Select(x => x.Label).ToList();

        // 设置数据集
        var dataset = new ChartDataset()
        {
            Label = "考核得分",
            // 数据转换
            Data = TrendData.Select(x => (object)x.Score).ToList(),

            // 【格式修复】颜色必须是 string[]
            BackgroundColor = new string[] { "rgba(13, 110, 253, 0.2)" },
            BorderColor = new string[] { "#0d6efd" },

            Fill = true,
            Tension = 0.4f,
            PointRadius = 4,
            PointHoverRadius = 6
        };

        ds.Data.Add(dataset);

        return ds;
    }
}