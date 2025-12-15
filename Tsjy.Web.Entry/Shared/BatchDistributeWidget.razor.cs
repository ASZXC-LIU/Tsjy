using System.Diagnostics.CodeAnalysis;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Tsjy.Application.System.Dtos.BatchDtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Enums;
using Tsjy.Core.Entities;

namespace Tsjy.Web.Entry.Pages.Admin.Components;

public partial class BatchDistributeWidget
{
    // ---------------- 参数 ----------------
    [Parameter]
    [NotNull]
    public BatchListDto? BatchInfo { get; set; }

    [Parameter]
    public Func<Task>? OnClose { get; set; }

    // ---------------- 注入服务 ----------------
    [Inject]
    [NotNull]
    private IBasicDataService? BasicDataService { get; set; }

    [Inject]
    [NotNull]
    private ISysUsersService? UsersService { get; set; }

    [Inject]
    [NotNull]
    private IEvalNodeService? NodeService { get; set; }

    [Inject]
    [NotNull]
    private IBatchService? BatchService { get; set; }

    [Inject]
    [NotNull]
    private ToastService? ToastService { get; set; }

    // ---------------- 内部状态 ----------------
    private BatchDistributeDto Model { get; set; } = new();
    private int CurrentStepIndex { get; set; } = 0;

    // 步骤定义
    private List<StepItem> StepItems { get; set; } = new List<StepItem>
    {
        new StepItem { Title = "选择单位", Icon = "fa-solid fa-school" },
        new StepItem { Title = "组建视导组", Icon = "fa-solid fa-users-viewfinder" },
        new StepItem { Title = "专家指标分工", Icon = "fa-solid fa-list-check" }
    };

    // 数据源
    private List<SelectedItem> OrgItems { get; set; } = new();
    private List<SelectedItem> ExpertItems { get; set; } = new();
    private List<SelectedItem> ExpertSelectItems { get; set; } = new();

    // Transfer组件绑定的是字符串List
    private List<string> SelectedOrgIdsStr { get; set; } = new();
    private List<string> SelectedInspectionGroupStr { get; set; } = new();

    // ---------------- 生命周期 ----------------
    protected override async Task OnInitializedAsync()
    {
        if (BatchInfo == null) return;
        Model.BatchId = BatchInfo.Id;

        await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        // 1. 加载机构列表 - 修复：使用 BasicDataService.GetDepartmentsAsync
        var allDepts = await BasicDataService.GetDepartmentsAsync();

        // 过滤：只显示符合当前批次 OrgType 的单位
        OrgItems = allDepts.Where(o => o.OrgType == BatchInfo.TargetType)
                           // Transfer 的 Value 绑定 Code 或 Id，这里假设用 Code 作为唯一标识
                           .Select(o => new SelectedItem(o.Code, o.Name))
                           .ToList();

        // 2. 加载专家列表
        var allUsers = await UsersService.GetListAsync();
        // 假设 User_type 为字符串 "Expert"
        var experts = allUsers.Where(u => u.User_type == "Expert").ToList();

        ExpertItems = experts.Select(u => new SelectedItem(u.Id.ToString(), u.Name)).ToList();

        // 复制一份给 Step 3 的下拉框使用
        ExpertSelectItems = ExpertItems.ToList();
    }

    // ---------------- 步骤导航逻辑 ----------------
    private void OnPrev()
    {
        if (CurrentStepIndex > 0) CurrentStepIndex--;
    }

    private async Task OnNext()
    {
        // 校验步骤 1
        if (CurrentStepIndex == 0)
        {
            if (!SelectedOrgIdsStr.Any())
            {
                await ToastService.Error("提示", "请至少选择一个受评单位");
                return;
            }
        }

        // 校验步骤 2
        if (CurrentStepIndex == 1)
        {
            // 进入步骤 3 前，预加载指标数据
            await LoadSecondIndicators();
        }

        if (CurrentStepIndex < StepItems.Count - 1)
        {
            CurrentStepIndex++;
        }
    }

    // ---------------- 核心逻辑：加载二级指标 ----------------
    private async Task LoadSecondIndicators()
    {
        if (Model.ExpertAllocations.Any()) return;

        // 获取该体系下的所有节点
        var nodes = await NodeService.GetListAsync(BatchInfo.TreeId);

        // 筛选二级指标 (根据业务逻辑可能是 Depth=2 或 Type=SecondIndicator)
        var secondNodes = nodes.Where(x => x.Type == EvalNodeType.SecondIndicator)
                               .OrderBy(x => x.Code)
                               .ToList();

        Model.ExpertAllocations = secondNodes.Select(n => new NodeExpertRelationDto
        {
            NodeId = n.Id,
            NodeName = n.Name,
            Code = n.Code,
            SelectedExpertIds = new List<string>()
        }).ToList();
    }

    // ---------------- 提交逻辑 ----------------
    private async Task OnSubmit()
    {
        // 1. 填充 DTO
        Model.SelectedOrgIds = SelectedOrgIdsStr;
        Model.InspectionGroupUserIds = SelectedInspectionGroupStr;

        try
        {
            // 2. 调用 Service 提交 
            // 注意：请确保 IBatchService 中已添加 DistributeAsync 方法
            await BatchService.DistributeAsync(Model);

            await ToastService.Success("发布成功", "任务已成功下发！");

            if (OnClose != null)
            {
                await OnClose.Invoke();
            }
        }
        catch (Exception ex)
        {
            await ToastService.Error("发布失败", ex.Message);
        }
    }
}