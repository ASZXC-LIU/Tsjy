using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Diagnostics.CodeAnalysis;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.School;

public partial class MyTask
{
    [Inject] private TaskService TaskService { get; set; }
    [Inject] private AuthenticationStateProvider AuthStateProvider { get; set; }
    [Inject] private NavigationManager Nav { get; set; }

    [NotNull]
    private Table<SchoolTaskListDto>? TaskTable { get; set; }

    // 筛选选项
    private List<SelectedItem> FilterItems { get; set; } = new List<SelectedItem>
    {
        new SelectedItem("All", "全部"),
        new SelectedItem("Unfinished", "待处理"),
        new SelectedItem("Finished", "已完结")
    };

    private string CurrentFilter { get; set; } = "All";
    private List<SchoolTaskListDto>? AllTasksCache { get; set; }

    /// <summary>
    /// 表格数据查询回调
    /// </summary>
    private async Task<QueryData<SchoolTaskListDto>> OnQueryAsync(QueryPageOptions options)
    {
        // 1. 缓存策略：仅第一次加载时查询数据库
        if (AllTasksCache == null)
        {
            var state = await AuthStateProvider.GetAuthenticationStateAsync();
            var orgId = state.User.FindFirst("OrgId")?.Value;

            if (!string.IsNullOrEmpty(orgId))
            {
                AllTasksCache = await TaskService.GetMyTasks(orgId);
            }
            else
            {
                AllTasksCache = new List<SchoolTaskListDto>();
            }
        }

        var items = AllTasksCache.AsEnumerable();

        // 2. 内存筛选
        if (CurrentFilter == "Unfinished")
        {
            items = items.Where(t => t.Status == TaskStatu.Pending ||
                                     t.Status == TaskStatu.Sent ||
                                     t.Status == TaskStatu.Submitting ||
                                     t.Status == TaskStatu.Returned);
        }
        else if (CurrentFilter == "Finished")
        {
            items = items.Where(t => t.Status == TaskStatu.Submitted ||
                                     t.Status == TaskStatu.Reviewing ||
                                     t.Status == TaskStatu.Finished);
        }

        // 3. 内存分页
        var total = items.Count();
        var pagedItems = items.Skip((options.PageIndex - 1) * options.PageItems)
                              .Take(options.PageItems)
                              .ToList();

        return new QueryData<SchoolTaskListDto>
        {
            Items = pagedItems,
            TotalCount = total
        };
    }

    /// <summary>
    /// 筛选下拉框变化时刷新表格
    /// </summary>
    private async Task OnFilterChanged(string val)
    {
        if (TaskTable != null)
        {
            await TaskTable.QueryAsync();
        }
    }

    // --- 业务操作 ---

    private bool CanFill(TaskStatu status)
    {
        return status == TaskStatu.Pending ||
               status == TaskStatu.Sent ||
               status == TaskStatu.Submitting ||
               status == TaskStatu.Returned;
    }

    private void OnFill(SchoolTaskListDto item)
    {
        Nav.NavigateTo($"/School/DoTask/{item.TaskId}");
    }

    private void OnView(SchoolTaskListDto item)
    {
        Nav.NavigateTo($"/School/DoTask/{item.TaskId}");
    }

    // --- UI 辅助方法 (修复报错的关键部分) ---

    // 格式化时间
    private string Fmt(DateTime? d) => d.HasValue ? d.Value.ToString("yyyy-MM-dd") : "未设置";

    // 判断是否临近截止 (例如小于3天)
    private bool IsUrgent(SchoolTaskListDto item)
    {
        if (!item.UploadEnd.HasValue) return false;
        // 如果已经提交了，就不紧急
        if (!CanFill(item.Status)) return false;

        var daysLeft = (item.UploadEnd.Value - DateTime.Now).TotalDays;
        return daysLeft >= 0 && daysLeft <= 3;
    }

    // 获取任务图标框的 CSS 类 (UI美化用)
    private string GetIconClass(TaskStatu status) => status switch
    {
        TaskStatu.Pending or TaskStatu.Sent => "pending",
        TaskStatu.Submitting or TaskStatu.Returned => "active",
        _ => "finished"
    };

    // 获取状态胶囊的 CSS 类 (UI美化用)
    private string GetStatusClass(TaskStatu status) => status switch
    {
        TaskStatu.Pending or TaskStatu.Sent => "status-pending",
        TaskStatu.Submitting => "status-active",
        TaskStatu.Returned => "status-danger", // 被退回是红色
        TaskStatu.Submitted or TaskStatu.Reviewing => "status-warning", // 审核中是黄色
        TaskStatu.Finished => "status-success",
        _ => "status-pending"
    };

    // 获取状态图标 (UI美化用)
    private string GetStatusIcon(TaskStatu status) => status switch
    {
        TaskStatu.Pending => "fa-regular fa-clock",
        TaskStatu.Submitting => "fa-solid fa-pen-nib",
        TaskStatu.Returned => "fa-solid fa-triangle-exclamation",
        TaskStatu.Submitted => "fa-solid fa-paper-plane",
        TaskStatu.Finished => "fa-solid fa-check-circle",
        _ => "fa-solid fa-circle-info"
    };
}