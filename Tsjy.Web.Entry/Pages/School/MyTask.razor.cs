using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.ComponentModel;
using System.Reflection;
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
        var state = await AuthStateProvider.GetAuthenticationStateAsync();
        var user = state.User;

        // 尝试获取 OrgId
        var orgIdClaim = user.FindFirst("OrgId");

        if (orgIdClaim != null)
        {
            Tasks = await TaskService.GetMyTasks(orgIdClaim.Value);
        }
        else
        {
            // 如果没找到 OrgId，这里可以做一些处理，比如查询用户表获取
            // 目前先保持为空列表
        }
    }

    /// <summary>
    /// 获取状态对应的颜色
    /// </summary>
    private Color GetStatusColor(TaskStatu status) => status switch
    {
        TaskStatu.Pending => Color.Secondary,
        TaskStatu.Sent => Color.Info,
        TaskStatu.Submitting => Color.Primary,
        TaskStatu.Submitted => Color.Warning,
        TaskStatu.Reviewing => Color.Warning,
        TaskStatu.Returned => Color.Danger,
        TaskStatu.Finished => Color.Success,
        _ => Color.Info
    };

    /// <summary>
    /// 获取枚举的描述文本
    /// </summary>
    private string GetDescription(TaskStatu status)
    {
        var type = status.GetType();
        var fieldInfo = type.GetField(status.ToString());

        if (fieldInfo != null)
        {
            var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
            if (attrs != null && attrs.Length > 0)
            {
                return attrs[0].Description;
            }
        }

        return status.ToString();
    }
}