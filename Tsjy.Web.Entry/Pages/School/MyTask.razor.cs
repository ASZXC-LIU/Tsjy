using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.School;

public partial class MyTask
{
    [Inject] private TaskService TaskService { get; set; }
    [Inject] private AuthenticationStateProvider AuthStateProvider { get; set; }

    private List<SchoolTaskListDto> Tasks { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        // 获取当前用户 ID
        // 注意：这里需要你确保 AuthenticationStateProvider 配置正确，且能获取到 UserId
        var authState = await AuthStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        // 简单模拟：假设 Claim 中存了 UserId，或者通过 Name 查找
        // 实际项目中建议封装一个 UserContextService 来统一获取
        if (user.Identity != null && user.Identity.IsAuthenticated)
        {
            // 假设 ClaimTypes.NameIdentifier 存的是 Int64 的 ID
            var userIdStr = user.FindFirst(c => c.Type == System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (long.TryParse(userIdStr, out var myId))
            {
                Tasks = await TaskService.GetMyTasks(myId);
            }
            else
            {
                // 如果拿不到 ID，临时硬编码方便调试，或者跳转登录
                // myId = 1; 
                // Tasks = await TaskService.GetMyTasks(myId);
            }
        }
    }

    private Color GetStatusColor(TaskStatu status)
    {
        return status switch
        {
            TaskStatu.Pending => Color.Secondary,
            TaskStatu.Sent => Color.Info,
            TaskStatu.Submitting => Color.Primary,
            TaskStatu.Submitted => Color.Warning,
            TaskStatu.Reviewing => Color.Warning,
            TaskStatu.Finished => Color.Success,
            TaskStatu.Returned => Color.Danger,
            _ => Color.Primary
        };
    }
}