using System.Diagnostics.CodeAnalysis;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Tsjy.Application.System.Dtos.BatchDtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Enums;
using Tsjy.Core.Entities;

namespace Tsjy.Web.Entry.Shared;

public partial class BatchDistributeWidget
{
    [Parameter][NotNull] public BatchListDto? BatchInfo { get; set; }
    [Parameter] public Func<Task>? OnClose { get; set; }

    [Inject][NotNull] private IBasicDataService? BasicDataService { get; set; }
    [Inject][NotNull] private ISysUsersService? UsersService { get; set; }
    [Inject][NotNull] private IBatchService? BatchService { get; set; }
    [Inject][NotNull] private ToastService? ToastService { get; set; }

    private BatchDistributeDto Model { get; set; } = new();
    private int CurrentStepIndex { get; set; } = 0;

    private List<StepOption> StepItems { get; set; } = new List<StepOption>
    {
        new StepOption { Title = "选择单位", Icon = "fa-solid fa-school" },
        new StepOption { Title = "组建视导组", Icon = "fa-solid fa-users-viewfinder" },
        new StepOption { Title = "评审专家", Icon = "fa-solid fa-gavel" }
    };

    private List<SelectedItem> OrgItems { get; set; } = new();
    private List<SelectedItem> ExpertItems { get; set; } = new();
    private List<SelectedItem> ReviewExpertItems { get; set; } = new(); // 步骤3用的源数据

    private List<string> SelectedOrgIdsStr { get; set; } = new();
    private List<string> SelectedInspectionGroupStr { get; set; } = new();
    private List<string> SelectedReviewExpertsStr { get; set; } = new(); // 步骤3选中的人

    protected override async Task OnInitializedAsync()
    {
        if (BatchInfo == null) return;
        Model.BatchId = BatchInfo.Id;
        await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        // 1. 加载机构
        var allDepts = await BasicDataService.GetDepartmentsAsync();
        OrgItems = allDepts.Where(o => o.OrgType == BatchInfo.TargetType)
                           .Select(o => new SelectedItem(o.Code, o.Name)).ToList();

        // 2. 加载专家
        var allUsers = await UsersService.GetListAsync();
        // 确保 SysUser 实体中 User_type 属性与 UserRole 枚举匹配
        // 如果您的 User_type 是 string，请用 u.User_type == "Expert"
        var experts = allUsers.Where(u => u.Role == UserRole.Expert).ToList();

        if (!experts.Any())
        {
            await ToastService.Warning("警告", "未查询到专家数据！");
        }

        ExpertItems = experts.Select(u => new SelectedItem(u.IDNumber.ToString(), u.RealName)).ToList();

        // 复制一份给步骤3使用，因为Transfer操作会改变Items的状态，最好隔离
        ReviewExpertItems = experts.Select(u => new SelectedItem(u.IDNumber.ToString(), u.RealName)).ToList();
    }

    private void OnPrev()
    {
        if (CurrentStepIndex > 0) CurrentStepIndex--;
    }

    private async Task OnNext()
    {
        if (CurrentStepIndex == 0 && !SelectedOrgIdsStr.Any())
        {
            await ToastService.Error("提示", "请至少选择一个受评单位");
            return;
        }
        if (CurrentStepIndex < StepItems.Count - 1) CurrentStepIndex++;
    }

    private async Task OnSubmit()
    {
        // 校验步骤3
        if (!SelectedReviewExpertsStr.Any())
        {
            await ToastService.Error("提示", "请至少选择一位评审专家来分配任务");
            return;
        }

        Model.SelectedOrgIds = SelectedOrgIdsStr;
        Model.InspectionGroupUserIds = SelectedInspectionGroupStr;
        Model.ReviewExpertIds = SelectedReviewExpertsStr;

        try
        {
            await BatchService.DistributeAsync(Model);
            await ToastService.Success("发布成功", "任务已自动平均分配并下发！");
            if (OnClose != null) await OnClose.Invoke();
        }
        catch (Exception ex)
        {
            await ToastService.Error("发布失败", ex.Message);
        }
    }
}