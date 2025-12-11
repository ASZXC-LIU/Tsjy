using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.Admin;

public partial class TaskDistribute
{
    [Inject] private TaskService TaskService { get; set; }
    [Inject] private EvalNodeService EvalNodeService { get; set; }
    [Inject] private MessageService MessageService { get; set; }

    private DistributeTaskDto Model { get; set; } = new();
    private DateTimeRangeValue DateRange { get; set; } = new() { Start = DateTime.Now, End = DateTime.Now.AddMonths(1) };

    private List<SelectedItem> OrgTypeItems { get; set; } = new();
    private List<SelectedItem> TreeItems { get; set; } = new();

    // 目标列表现在是 SysUserTargetDto
    private List<SysUserTargetDto> TargetList { get; set; } = new();
    private List<SysUserTargetDto> SelectedTargets { get; set; } = new();
    private bool IsLoadingTargets { get; set; }

    protected override void OnInitialized()
    {
        OrgTypeItems = typeof(OrgType).ToSelectList().ToList();
    }

    private async Task OnTypeChanged(SelectedItem item)
    {
        if (Enum.TryParse<OrgType>(item.Value, out var type))
        {
            IsLoadingTargets = true;
            StateHasChanged();

            string category = type switch
            {
                OrgType.SpecialSchool => "special_school",
                OrgType.InclusiveSchool => "inclusive_school",
                OrgType.EducationBureau => "education_bureau",
                _ => ""
            };

            if (!string.IsNullOrEmpty(category))
            {
                var systems = await EvalNodeService.GetSystemListAsync(category);
                TreeItems = systems.Select(x => new SelectedItem(x.Id.ToString(), x.Name)).ToList();
            }
            else TreeItems.Clear();

            TargetList = await TaskService.GetTargetsByType(type);
            IsLoadingTargets = false;
            StateHasChanged();
        }
    }

    private async Task OnSubmit(EditContext context)
    {
        if (!SelectedTargets.Any())
        {
            await MessageService.Show(new MessageOption { Content = "请至少选择一个单位", Color = Color.Warning });
            return;
        }

        // SelectedTargets 中的 TargetId 已经是 OrgId
        Model.SelectedTargetIds = SelectedTargets.Select(x => x.TargetId).ToList();
        Model.StartAt = DateRange.Start;
        Model.DueAt = DateRange.End;

        await TaskService.PublishTask(Model);
        await MessageService.Show(new MessageOption { Content = "发布成功", Color = Color.Success });

        Model = new DistributeTaskDto();
        SelectedTargets.Clear();
    }
}