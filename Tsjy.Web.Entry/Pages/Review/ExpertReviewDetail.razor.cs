using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.Review;

public partial class ExpertReviewDetail
{
    [Parameter] public long TaskId { get; set; }
    [Inject] private TaskService TaskService { get; set; }
    [Inject] private MessageService MessageService { get; set; }
    [Inject] private NavigationManager Nav { get; set; }

    private List<TreeViewItem<TaskNodeTreeDto>> TreeItems { get; set; } = new();
    private NodeFillDetailDto? CurrentNodeDetail { get; set; }
    private List<SelectedItem> ScoringOptions { get; set; } = new();
    private long SelectedScoringItemId { get; set; }
    private string? RejectReason { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await LoadTree();
    }

    private async Task LoadTree()
    {
        var nodes = await TaskService.GetTaskTree(TaskId);
        // 专家端树逻辑：显示审核状态
        TreeItems = nodes.Where(x => x.Type == EvalNodeType.Points)
                         .Select(n => new TreeViewItem<TaskNodeTreeDto>(n)
                         {
                             Text = $"{n.Code} {n.Name}",
                             Icon = GetNodeIcon(n.AuditStatus),
                             Template = CreateNodeTemplate(n)
                         }).ToList();
    }

    private async Task OnNodeClick(TreeViewItem<TaskNodeTreeDto> item)
    {
        CurrentNodeDetail = await TaskService.GetNodeFillDetail(TaskId, item.Value.Id);
        RejectReason = CurrentNodeDetail.RejectReason;

        // 转换为RadioList可用的SelectedItem
        ScoringOptions = CurrentNodeDetail.ScoringItems.Select(x => new SelectedItem(x.Id.ToString(), $"{x.LevelCode} ({x.Ratio:P0}) - {x.Description}")).ToList();

        StateHasChanged();
    }

    private async Task OnApprove()
    {
        if (SelectedScoringItemId == 0)
        {
            await MessageService.Show(new MessageOption { Content = "请选择评分等级", Color = Color.Warning });
            return;
        }
        await SaveReview(AuditStatus.Approved);
    }

    private async Task OnReject()
    {
        if (string.IsNullOrWhiteSpace(RejectReason))
        {
            await MessageService.Show(new MessageOption { Content = "驳回必须填写建议内容", Color = Color.Danger });
            return;
        }
        await SaveReview(AuditStatus.Rejected);
    }

    private async Task SaveReview(AuditStatus status)
    {
        try
        {
            // 此处调用之前设计的 SubmitReview 逻辑
            // 注意：需在 TaskService 中补全此方法
            // await TaskService.SubmitReview(TaskId, CurrentNodeDetail.NodeId, SelectedScoringItemId, status == AuditStatus.Rejected ? RejectReason : null);

            await MessageService.Show(new MessageOption { Content = "评审提交成功", Color = Color.Success });
            await LoadTree(); // 刷新树图标
            CurrentNodeDetail = null; // 归位
        }
        catch (Exception ex)
        {
            await MessageService.Show(new MessageOption { Content = ex.Message, Color = Color.Danger });
        }
    }

    private string GetNodeIcon(AuditStatus status) => status switch
    {
        AuditStatus.Approved => "fa-solid fa-circle-check text-success",
        AuditStatus.Rejected => "fa-solid fa-circle-xmark text-danger",
        _ => "fa-solid fa-circle-dot text-secondary"
    };

    // 沿用 School 端的渲染模板
    private RenderFragment<TaskNodeTreeDto> CreateNodeTemplate(TaskNodeTreeDto node) => (TaskNodeTreeDto item) => (builder) => { /* ... 逻辑同 DoTask ... */ };
}