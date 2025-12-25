using System.Security.Claims;
using System.IO;
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

    [Inject] private IReviewService ReviewService { get; set; }
    [Inject] private TaskService TaskService { get; set; }
    [Inject] private FileService FileService { get; set; }
    [Inject] private MessageService MessageService { get; set; }
    [Inject] private NavigationManager Nav { get; set; }
    [Inject] private AuthenticationStateProvider AuthStateProvider { get; set; }
    [Inject] private SwalService SwalService { get; set; }

    // ✅ 新增：AI 服务（真调用）
    [Inject] private IAiAssistService AiAssistService { get; set; }

   
    private List<long> AssignedNodeIds { get; set; } = new();
    private int CurrentNodeIndex { get; set; } = 0;
    private int TotalNodesCount => AssignedNodeIds.Count;

    private NodeFillDetailDto? CurrentNodeDetail { get; set; }

    private List<SelectedItem> ScoringOptions { get; set; } = new();
    private long SelectedScoringItemId { get; set; }
    private string? RejectReason { get; set; }

    private bool ShowAiResult { get; set; } = false;
    private string AiResult { get; set; } = "";

    private string CurrentPerspective { get; set; } = "School"; // School / Inspection

    private List<SelectedItem> EvidenceFileOptions { get; set; } = new();
    private string? SelectedEvidenceUrl { get; set; }

    private void SwitchPerspective(string perspective)
    {
        CurrentPerspective = perspective;
        RefreshEvidenceOptions();
        StateHasChanged();
    }

    protected override async Task OnInitializedAsync()
    {
        var state = await AuthStateProvider.GetAuthenticationStateAsync();
        var userId = state.User.FindFirst(ClaimTypes.Sid)?.Value;

        if (string.IsNullOrEmpty(userId)) return;

        var reviews = await ReviewService.GetExpertReviewNodes(TaskId, userId);
        AssignedNodeIds = reviews.Select(r => r.NodeId).ToList();

        if (AssignedNodeIds.Any())
        {
            var firstPending = reviews.FindIndex(r => r.Status == ReviewStatus.Pending);
            CurrentNodeIndex = firstPending != -1 ? firstPending : 0;

            await LoadCurrentNode();
        }
    }

    private async Task LoadCurrentNode()
    {
        if (!AssignedNodeIds.Any()) return;

        CurrentPerspective = "School";
        ShowAiResult = false;
        AiResult = "";

        long nodeId = AssignedNodeIds[CurrentNodeIndex];

        // 1) 指标详情
        CurrentNodeDetail = await TaskService.GetNodeFillDetail(TaskId, nodeId);

        // 2) 强制从目录读取该指标 PDF（只会是该 nodeId 的文件）
        CurrentNodeDetail.FileUrls = await FileService.GetEvidenceList(TaskId, nodeId);

      

        // 4) 评分项
        ScoringOptions = CurrentNodeDetail.ScoringItems.Select(x =>
            new SelectedItem(x.Id.ToString(), $"{x.LevelCode} ({x.Ratio:P0}) - {x.Description}")).ToList();

        // 5) 文件下拉
        RefreshEvidenceOptions();

        // 6) 恢复已有评分/驳回
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

    private void BackToDashboard() => Nav.NavigateTo("/Review/Dashboard");

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
            if (CurrentNodeDetail == null) return;

            var submission = new ReviewSubmissionDto
            {
                TaskId = TaskId,
                NodeId = CurrentNodeDetail.NodeId,
                ScoringItemId = SelectedScoringItemId,
                AuditStatus = status,
                RejectReason = status == AuditStatus.Rejected ? RejectReason : null,
                MaxScore = CurrentNodeDetail.MaxScore
            };

            await ReviewService.SubmitReview(submission);

            if (CurrentNodeIndex < TotalNodesCount - 1)
            {
                await MessageService.Show(new MessageOption { Content = "评审已保存", Color = Color.Success });
                await OnNextNode();
            }
            else
            {
                await LoadCurrentNode();
                // 3. 调用 Service 检查：是不是所有专家都评完了？
                bool isAllGlobalCompleted = await TaskService.AreAllReviewsCompleted(TaskId);

                if (isAllGlobalCompleted)
                {
                    // 4. 如果全局都评完了，调用 Service 进行结算
                    await TaskService.CompleteTaskAndSettleScore(TaskId);

                    // 弹窗提示：任务彻底完成
                    await SwalService.Show(new SwalOption()
                    {
                        Category = SwalCategory.Success,
                        Title = "任务圆满完成",
                        Content = "所有专家的评审均已提交，系统已自动计算并结算最终得分！",
                        ShowClose = false,
                        ConfirmButtonText = "返回工作台",
                        OnConfirmAsync = async () =>
                        {
                            BackToDashboard();
                            await Task.CompletedTask;
                        }
                    });
                }
                else
                {
                    // 只是当前专家评完了，但还有其他专家没评完
                    await SwalService.Show(new SwalOption()
                    {
                        Category = SwalCategory.Success,
                        Title = "您的评审已完成",
                        Content = "您已完成所有指标的评审，等待其他专家完成后系统将自动结算。",
                        ShowClose = false,
                        ConfirmButtonText = "返回工作台",
                        OnConfirmAsync = async () =>
                        {
                            BackToDashboard();
                            await Task.CompletedTask;
                        }
                    });
                }
                await LoadCurrentNode();
            }
        }
        catch (Exception ex)
        {
            await MessageService.Show(new MessageOption { Content = ex.Message, Color = Color.Danger });
        }
    }

    private async Task OnAiAssistClick()
    {
        if (CurrentNodeDetail == null) return;

        ShowAiResult = true;
        AiResult = "AI 正在读取当前指标信息与 PDF 佐证材料并进行评分建议，请稍后...";
        StateHasChanged();

        try
        {
            var ai = await AiAssistService.ExpertAssistAsync(TaskId, CurrentNodeDetail.NodeId);

            var sb = new System.Text.StringBuilder();
            sb.AppendLine("【AI 辅助评分建议】");
            sb.AppendLine($"- 推荐等级：{ai.RecommendedLevelCode ?? "（无）"}");
            sb.AppendLine($"- 推荐 ScoringItemId：{ai.RecommendedScoringItemId?.ToString() ?? "（无）"}");
            if (ai.RecommendedScore.HasValue) sb.AppendLine($"- 建议分：{ai.RecommendedScore}");
            sb.AppendLine($"- 置信度：{ai.Confidence:P0}");
            sb.AppendLine();
            sb.AppendLine("【关键依据】");
            foreach (var k in ai.KeyEvidence.Take(10)) sb.AppendLine($"- {k}");
            sb.AppendLine();
            sb.AppendLine("【缺失/风险点】");
            foreach (var m in ai.MissingEvidence.Take(10)) sb.AppendLine($"- {m}");
            sb.AppendLine();
            sb.AppendLine("【解释】");
            sb.AppendLine(ai.Explanation);

            AiResult = sb.ToString();
        }
        catch (Exception ex)
        {
            AiResult = $"AI 调用失败：{ex.Message}";
        }

        StateHasChanged();
    }

    private void RefreshEvidenceOptions()
    {
        if (CurrentNodeDetail == null)
        {
            EvidenceFileOptions = new();
            SelectedEvidenceUrl = null;
            return;
        }

        var files = CurrentPerspective == "School"
            ? CurrentNodeDetail.FileUrls
            : CurrentNodeDetail.InspectionFileUrls;

        EvidenceFileOptions = files?.Select(url => new SelectedItem(url, Path.GetFileName(url))).ToList()
            ?? new List<SelectedItem>();

        // 防呆：保持已选值，不存在则选第一个
        if (EvidenceFileOptions.Count == 0)
        {
            SelectedEvidenceUrl = null;
            return;
        }

        if (string.IsNullOrWhiteSpace(SelectedEvidenceUrl) ||
            !EvidenceFileOptions.Any(x => x.Value == SelectedEvidenceUrl))
        {
            SelectedEvidenceUrl = EvidenceFileOptions[0].Value;
        }
    }
}
