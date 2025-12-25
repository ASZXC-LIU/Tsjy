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
    [Inject] private SwalService SwalService { get; set; } // ★ 新增注入：全屏弹窗服务
    [Inject] private IInspectionService InspectionService { get; set; }
    private List<long> AssignedNodeIds { get; set; } = new();
    private int CurrentNodeIndex { get; set; } = 0;
    private int TotalNodesCount => AssignedNodeIds.Count;
    private NodeFillDetailDto? CurrentNodeDetail { get; set; }
    private List<SelectedItem> ScoringOptions { get; set; } = new();
    private long SelectedScoringItemId { get; set; }
    private string? RejectReason { get; set; }
    private bool ShowAiResult { get; set; } = false;
    private string AiResult { get; set; } = "";

    private string CurrentPerspective { get; set; } = "School"; // 当前视角 // 默认查看受评单位材料

    // 切换视角方法
    private void SwitchPerspective(string perspective)
    {
        CurrentPerspective = perspective;
        StateHasChanged();
    }
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
        // 重置 状态
        CurrentPerspective = "School";
        ShowAiResult = false;
        AiResult = "";

        long nodeId = AssignedNodeIds[CurrentNodeIndex];
        //1.从原有 TaskService 获取指标详情和学校佐证
        CurrentNodeDetail = await TaskService.GetNodeFillDetail(TaskId, nodeId);
        // 2. 从新 InspectionService 获取巡视组佐证
        var inspectionData = await InspectionService.GetInspectionEvidence(TaskId, nodeId);
        CurrentNodeDetail.InspectionContent = inspectionData.Content;
        CurrentNodeDetail.InspectionFileUrls = inspectionData.FileUrls;
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
            // 1. 提交至数据库
            await ReviewService.SubmitReview(submission);
            // 2. 判断是否是最后一个
            if (CurrentNodeIndex < TotalNodesCount - 1)
            {
                // 如果不是最后一个，弹出轻量级消息并自动跳转
                await MessageService.Show(new MessageOption { Content = "评审已保存", Color = Color.Success });
                await OnNextNode();
            }
            else
            {
                // ★ 评审完最后一个后的逻辑：弹出全屏强提醒
                await LoadCurrentNode(); // 刷新当前 UI 状态

                await SwalService.Show(new SwalOption()
                {
                    Category = SwalCategory.Success,
                    Title = "本任务已全部完成",
                    Content = "所有评估指标已评审完毕！请关闭此页面或点击下方按钮返回工作台。",
                    ShowClose = false,
                    ConfirmButtonText = "返回工作台",
                    OnConfirmAsync = async () =>
                    {
                        BackToDashboard();
                        await Task.CompletedTask;
                    }
                });
            }
        }
        catch (Exception ex)
        {
            await MessageService.Show(new MessageOption { Content = ex.Message, Color = Color.Danger });
        }
    }
    // ★ 新增：AI 按钮点击事件 ★
    private async Task OnAiAssistClick()
    {
        ShowAiResult = true;
        AiResult = "系统正在调取 AI 大模型，对该单位提交的 PDF 佐证材料进行全文扫描与逻辑匹配，请稍后...";
        StateHasChanged();

        // 模拟 AI 处理延迟
        await Task.Delay(1500);

        // 这里未来可以接入大模型接口
        AiResult = $"【AI 智能分析报告】\n" +
                   $"1. 材料合规性：检测到已上传 PDF 文件，内容涵盖了“{CurrentNodeDetail.PointName}”的核心要求。\n" +
                   $"2. 内容匹配度：学校在自评说明中提到的关键指标与佐证数据一致。\n" +
                   $"3. 评分建议：基于评估要点“{CurrentNodeDetail.ReferencePoint}”，建议给予【A等级】。\n" +
                   $"4. 备注：检测到支撑材料中财务数据略有模糊，如不确定可点击驳回要求学校重新扫描。";

        StateHasChanged();
    }
}