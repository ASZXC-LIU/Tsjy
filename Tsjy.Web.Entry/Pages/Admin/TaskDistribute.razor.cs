using System.Diagnostics.CodeAnalysis;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Tsjy.Application.System.Dtos.BatchDtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.Admin;

public partial class TaskDistribute
{
    [Inject]
    [NotNull]
    private IBatchService? BatchService { get; set; }
    // 新增：注入 EvalNodeService 用于查询体系列表
    [Inject]
    [NotNull]
    private EvalNodeService? NodeService { get; set; }
    [Inject]
    [NotNull]
    private ToastService? ToastService { get; set; }

    // ★★★ 关键修复：公开 Model 属性供外部传参 ★★★
    [Parameter]
    public BatchInputDto Model { get; set; } = new();

    // ★★★ 关键修复：公开 OnClose 回调供外部关闭弹窗 ★★★
    [Parameter]
    public Func<Task>? OnClose { get; set; }
    // 下拉框数据源
    private List<SelectedItem> OrgTypeItems { get; set; } = new();
    private List<SelectedItem> TreeItems { get; set; } = new();

    protected override void OnInitialized()
    {
        // 初始化机构类型下拉框
        OrgTypeItems = typeof(OrgType).ToSelectList().ToList();
    }


    /// <summary>
    /// 当机构类型改变时，加载对应的评价体系
    /// </summary>
    private async Task OnOrgTypeChanged(OrgType? type)
    {
        // 1. 更新模型
        Model.TargetType = type;

        // 2. 清空已选的体系
        Model.TreeId = null;
        TreeItems.Clear();

        if (type.HasValue)
        {
            // 3. 映射 OrgType 到 category 字符串 (与 EvalNodeService 约定一致)
            string category = type.Value switch
            {
                OrgType.SpecialSchool => "special_school",
                OrgType.InclusiveSchool => "inclusive_school",
                OrgType.EducationBureau => "education_bureau",
                _ => ""
            };

            if (!string.IsNullOrEmpty(category))
            {
                // 4. 调用服务获取体系列表
                var systems = await NodeService.GetSystemListAsync(category);

                // 5. 转换为下拉框选项 (Value=Id, Text=Name)
                TreeItems = systems.Select(x => new SelectedItem(x.Id.ToString(), x.Name)).ToList();
            }
        }
    }


    private async Task OnValidSubmit(EditContext context)
    {
        try
        {
            if (Model.Id > 0)
            {
                await BatchService.UpdateAsync(Model);
                await ToastService.Success("提示", "修改成功");
            }
            else
            {
                await BatchService.CreateAsync(Model);
                await ToastService.Success("提示", "创建成功");
            }

            // 触发关闭回调（BatchManagement 会在此回调中刷新表格）
            if (OnClose != null)
            {
                await OnClose.Invoke();
            }
        }
        catch (Exception ex)
        {
            await ToastService.Error("错误", ex.Message);
        }
    }
}