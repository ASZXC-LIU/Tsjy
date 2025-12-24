using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service;
using Tsjy.Application.System.Dtos.ReviewDtos;
namespace Tsjy.Web.Entry.Pages.Review;

public partial class ExpertDashboard
{
    [Inject] private IReviewService ReviewService { get; set; }
    [Inject] private NavigationManager Nav { get; set; }
    [Inject] private AuthenticationStateProvider AuthStateProvider { get; set; }

    private List<ExpertTaskListDto>? TaskList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var state = await AuthStateProvider.GetAuthenticationStateAsync();
        // 获取当前登录专家的用户ID
        var userId = state.User.FindFirst("IDNumber")?.Value;

        if (!string.IsNullOrEmpty(userId))
        {
            // 使用 ReviewService 代替 TaskService
            TaskList = await ReviewService.GetExpertTasks(userId);
        }
        else
        {
            // 处理用户ID为空的情况
             
        }
    }

    private int GetProgress(ExpertTaskListDto task)
    {
        if (task.TotalCount == 0) return 0;
        return (int)((double)task.ReviewedCount / task.TotalCount * 100);
    }

    private void OnStartReview(long taskId)
    {
        // 跳转至详情页
        Nav.NavigateTo($"/Expert/ReviewDetail/{taskId}");
    }
}