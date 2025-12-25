using System.Security.Claims;
using BootstrapBlazor.Components;
using Furion;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.ReviewDtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service;
namespace Tsjy.Web.Entry.Pages.Review;

public partial class ExpertDashboard
{
    [Inject] private IReviewService ReviewService { get; set; }
    [Inject] private NavigationManager Nav { get; set; }
    [Inject] private AuthenticationStateProvider AuthStateProvider { get; set; }
    [Inject] private ToastService ToastService { get; set; }
    private List<ExpertTaskListDto>? TaskList { get; set; }
    private List<ExpertTaskListDto> AllTasks { get; set; } = new();
    private IEnumerable<ExpertTaskListDto> FilteredTasks => AllTasks
        .Where(t => string.IsNullOrEmpty(SearchText) || t.BatchName.Contains(SearchText) || t.SchoolName.Contains(SearchText))
        .Where(t => StatusFilter == "全部" || GetButtonState(t).Text == StatusFilter);

    private IEnumerable<ExpertTaskListDto> PagedTasks => FilteredTasks
        .Skip((PageIndex - 1) * PageItems)
        .Take(PageItems);
    private string SearchText { get; set; } = "";
    private string StatusFilter { get; set; } = "全部";
    private int PageIndex { get; set; } = 1;
    private int PageItems { get; set; } = 6;
    private int PageCount => (int)Math.Ceiling((double)FilteredTasks.Count() / PageItems);

    private List<SelectedItem> StatusItems = new()
    {
        new("全部", "全部"), new("进行中", "进行中"), new("未开始", "未开始"), new("已结束", "已结束"), new("已完成", "已完成")
    };



    protected override async Task OnInitializedAsync()
    {
        var state = await AuthStateProvider.GetAuthenticationStateAsync();
        // 获取当前登录专家的用户ID
       
        var userId = state.User.FindFirst(ClaimTypes.Sid)?.Value;
        if (!string.IsNullOrEmpty(userId))
        {
            // 使用 ReviewService 代替 TaskService
            AllTasks = await ReviewService.GetExpertTasks(userId);
        }
        else
        {
            // 处理用户ID为空的情况
             
        }
    }


    // 处理搜索和筛选
    private async Task OnSearch(string val)
    {
        PageIndex = 1;
        StateHasChanged(); // ★ 必须：通知 UI 刷新 FilteredTasks
        await Task.CompletedTask;
    }
    private Task OnFilterChanged(string val) { PageIndex = 1; return Task.CompletedTask; }
    private void OnReset() { SearchText = ""; StatusFilter = "全部"; PageIndex = 1; StateHasChanged(); }

    private async Task OnPageClick(int pageIndex)
    {
        PageIndex = pageIndex;
        StateHasChanged(); // ★ 必须：通知 UI 重新计算 PagedTasks 并渲染
        await Task.CompletedTask;
    }


    private (string Text, Color BtnColor, string BtnClass, bool IsActiveWindow) GetButtonState(ExpertTaskListDto task)
    {
        var now = DateTime.Now;
        // 如果全部评审完成
        if (task.TotalCount > 0 && task.ReviewedCount == task.TotalCount)
            return ("已完成", Color.Success, "bg-success", true);

        // 判断时间窗口
        if (task.ReviewStart.HasValue && now < task.ReviewStart.Value)
            return ("未开始", Color.Secondary, "bg-secondary", false);

        if (task.ReviewEnd.HasValue && now > task.ReviewEnd.Value)
            return ("已结束", Color.Danger, "bg-danger", false);

        return ("进行中", Color.Primary, "bg-primary", true);
    }

    // --- 修改点 2: 弹窗校验逻辑 ---
    private async Task HandleReviewClick(ExpertTaskListDto task)
    {
        var state = GetButtonState(task);

        if (!state.IsActiveWindow)
        {
            await ToastService.Show(new ToastOption()
            {
                Category = ToastCategory.Warning,
                Title = "无法进入评审",
                Content = $"当前评审状态为【{state.Text}】，请在规定时间内操作。"
            });
            return;
        }

        // 只有在评审时间内或已完成的情况下才允许跳转
        Nav.NavigateTo($"/Review/ReviewDetail/{task.TaskId}");
    }
    private int GetProgress(ExpertTaskListDto task)
    {
        if (task.TotalCount == 0) return 0;
        return (int)((double)task.ReviewedCount / task.TotalCount * 100);
    }
  
    //private void OnStartReview(long taskId)
    //{
    //    // 跳转至详情页
    //    Nav.NavigateTo($"/Review/ReviewDetail/{taskId}");
    //}
}