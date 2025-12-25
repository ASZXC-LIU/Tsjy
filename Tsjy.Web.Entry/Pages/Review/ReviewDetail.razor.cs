using System.Security.Claims;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.ReviewDtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.Review;

public partial class ReviewDetail
{
    [Parameter] public long TaskId { get; set; }
    [Inject] private IReviewService ReviewService { get; set; } // 修复注入接口
    [Inject] private TaskService TaskService { get; set; }
    [Inject] private MessageService MessageService { get; set; }
    [Inject] private NavigationManager Nav { get; set; }
    [Inject] private AuthenticationStateProvider AuthStateProvider { get; set; }

    private List<long> AssignedNodeIds { get; set; } = new();
    private int CurrentNodeIndex { get; set; } = 0;
    private int TotalNodesCount => AssignedNodeIds.Count;
    private NodeFillDetailDto? CurrentNodeDetail { get; set; }
    private List<SelectedItem> ScoringOptions { get; set; } = new();
    private long SelectedScoringItemId { get; set; }
    private string? RejectReason { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var state = await AuthStateProvider.GetAuthenticationStateAsync();
        var userId = state.User.FindFirst(ClaimTypes.Sid)?.Value;

        if (string.IsNullOrEmpty(userId)) return;

        // 1. 获取所有分配节点
        var reviews = await ReviewService.GetExpertReviewNodes(TaskId, userId);
        AssignedNodeIds = reviews.Select(r => r.NodeId).ToList();

        if (AssignedNodeIds.Any())
        {
            // 2. 默认定位到第一个 Pending 的指标
            var firstPending = reviews.FindIndex(r => r.Status == ReviewStatus.Pending);
            CurrentNodeIndex = firstPending != -1 ? firstPending : 0;

            await LoadCurrentNode();
        }
    }

    private async Task LoadCurrentNode()
    {
        if (!AssignedNodeIds.Any()) return;

        long nodeId = AssignedNodeIds[CurrentNodeIndex];
        CurrentNodeDetail = await TaskService.GetNodeFillDetail(TaskId, nodeId);

        // 绑定打分项
        ScoringOptions = CurrentNodeDetail.ScoringItems.Select(x =>
            new SelectedItem(x.Id.ToString(), $"{x.LevelCode} ({x.Ratio:P0}) - {x.Description}")).ToList();

        // 恢复已有数据
        SelectedScoringItemId = CurrentNodeDetail.ScoringItems.FirstOrDefault()?.Id ?? 0;
        RejectReason = CurrentNodeDetail.RejectReason;

        StateHasChanged();
    }

    private async Task OnNextNode()
    {
        if (CurrentNodeIndex < TotalNodesCount - 1)
        {
            CurrentNodeIndex++;
            await LoadCurrentNode();
        }
    }

    private async Task OnPrevNode()
    {
        if (CurrentNodeIndex > 0)
        {
            CurrentNodeIndex--;
            await LoadCurrentNode();
        }
    }

    private void BackToDashboard() => Nav.NavigateTo("/Review/Dashboard"); // 修复缺失方法

    private async Task OnApprove() => await SaveReview(AuditStatus.Approved);

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
            var submission = new ReviewSubmissionDto
            {
                TaskId = TaskId,
                NodeId = CurrentNodeDetail.NodeId,
                ScoringItemId = SelectedScoringItemId,
                AuditStatus = status,
                RejectReason = status == AuditStatus.Rejected ? RejectReason : null
            };

            await ReviewService.SubmitReview(submission);
            await MessageService.Show(new MessageOption { Content = "评审已提交", Color = Color.Success });

            // 自动跳转下一个
            if (CurrentNodeIndex < TotalNodesCount - 1) await OnNextNode();
            else await LoadCurrentNode(); // 刷新当前状态
        }
        catch (Exception ex)
        {
            await MessageService.Show(new MessageOption { Content = ex.Message, Color = Color.Danger });
        }
    }
}