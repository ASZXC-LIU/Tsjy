using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Service; // 引用 Service
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.Admin;

public partial class TaskDistribute
{
    [Inject] private TaskService TaskService { get; set; }
    [Inject] private EvalNodeService EvalNodeService { get; set; } // 用于获取体系列表
    [Inject] private MessageService MessageService { get; set; }

    private DistributeTaskDto Model { get; set; } = new();
    private DateTimeRangeValue DateRange { get; set; } = new()
    {
        Start = DateTime.Today,
        End = DateTime.Today.AddMonths(1)
    };

    // 下拉框数据源
    private List<SelectedItem> OrgTypeItems { get; set; } = new();
    private List<SelectedItem> TreeItems { get; set; } = new();

    // 表格数据源
    private List<SysUserDto> TargetList { get; set; } = new();
    private List<SysUserDto> SelectedTargets { get; set; } = new();
    private bool IsLoadingTargets { get; set; } = false;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        // 初始化单位类型下拉框 (利用 BootstrapBlazor 扩展方法或手动转换枚举)
        OrgTypeItems = typeof(OrgType).ToSelectList().ToList();
    }

    /// <summary>
    /// 当单位类型改变时：1.加载对应的评价体系 2.加载对应的单位列表
    /// </summary>
    private async Task OnOrgTypeChanged(SelectedItem item)
    {
        if (Enum.TryParse<OrgType>(item.Value, out var type))
        {
            Model.TargetType = type;
            IsLoadingTargets = true;
            StateHasChanged();

            try
            {
                // 1. 加载评价体系 (将枚举转换为字符串传给 Service)
                var category = type.ToString(); // 需要确保 Service 支持这个字符串映射，或者调整 Service 接收枚举
                // 注意：这里假设 EvalNodeService.GetSystemListAsync 接收字符串，你需要根据实际情况调整映射逻辑
                // 例如: SpecialSchool -> "special_school"
                var systemCategory = type switch
                {
                    OrgType.SpecialSchool => "special_school",
                    OrgType.InclusiveSchool => "inclusive_school",
                    OrgType.EducationBureau => "education_bureau",
                    _ => ""
                };

                if (!string.IsNullOrEmpty(systemCategory))
                {
                    var systems = await EvalNodeService.GetSystemListAsync(systemCategory);
                    TreeItems = systems.Select(s => new SelectedItem(s.Id.ToString(), s.Name)).ToList();
                }
                else
                {
                    TreeItems.Clear();
                }

                // 2. 加载单位列表
                TargetList = await TaskService.GetTargetsByType(type);
                SelectedTargets.Clear(); // 切换类型清空选中
            }
            finally
            {
                IsLoadingTargets = false;
                StateHasChanged();
            }
        }
    }

    private async Task OnSubmit(EditContext context)
    {
        if (!SelectedTargets.Any())
        {
            await MessageService.Show(new MessageOption
            {
                Content = "请至少选择一个被评价单位！",
                Color = Color.Warning,
                Icon = "fa fa-exclamation-triangle"
            });
            return;
        }

        if (Model.TreeId == 0)
        {
            await MessageService.Show(new MessageOption { Content = "请选择一个评价体系！", Color = Color.Warning });
            return;
        }

        // 填充 DTO
        Model.SelectedTargetIds = SelectedTargets.Select(x => x.Id).ToList();
        Model.StartAt = DateRange.Start;
        Model.DueAt = DateRange.End;

        // 调用服务
        await TaskService.PublishTask(Model);

        await MessageService.Show(new MessageOption
        {
            Content = "任务发布成功！",
            Color = Color.Success
        });

        // 重置表单或跳转
        Model = new DistributeTaskDto();
        TargetList.Clear();
        SelectedTargets.Clear();
    }
}