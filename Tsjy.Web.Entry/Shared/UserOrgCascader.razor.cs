using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection; // 必须引用
using System.Diagnostics.CodeAnalysis;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Shared;

/// <summary>
/// 用户所属单位级联选择器
/// </summary>
public partial class UserOrgCascader
{
    // 修改 1: 注入 IServiceScopeFactory 而不是直接注入 Service
    [Inject]
    [NotNull]
    private IServiceScopeFactory? ScopeFactory { get; set; }

    /// <summary>
    /// 绑定的 OrgId (对应 Model.OrgId)
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    public EventCallback<string?> ValueChanged { get; set; }

    /// <summary>
    /// 绑定的 OrgType (对应 Model.OrgType)
    /// </summary>
    [Parameter]
    public OrgType OrgType { get; set; }

    [Parameter]
    public EventCallback<OrgType> OrgTypeChanged { get; set; }

    /// <summary>
    /// 当前选中的单位名称 (用于回显时如果列表里没有该单位，手动补全显示)
    /// </summary>
    [Parameter]
    public string? CurrentOrgName { get; set; }

    // 内部数据源
    private List<SelectedItem> OrgTypeItems { get; set; } = new();
    private List<SelectedItem> OrgItems { get; set; } = new();

    protected override void OnInitialized()
    {
        // 初始化类型下拉框 (枚举转换不需要数据库，可直接执行)
        OrgTypeItems = typeof(OrgType).ToSelectList().ToList();
    }

    protected override async Task OnParametersSetAsync()
    {
        // 只有当列表为空时才加载，避免重复请求
        if (OrgItems.Count == 0)
        {
            await LoadOrgList(OrgType);
        }
    }

    private async Task OnOrgTypeChanged(OrgType type)
    {
        OrgType = type;
        if (OrgTypeChanged.HasDelegate)
        {
            await OrgTypeChanged.InvokeAsync(type);
        }

        Value = "";
        if (ValueChanged.HasDelegate)
        {
            await ValueChanged.InvokeAsync("");
        }

        await LoadOrgList(type);
    }

    private async Task OnOrgIdChanged(string val)
    {
        Value = val;
        if (ValueChanged.HasDelegate)
        {
            await ValueChanged.InvokeAsync(val);
        }
    }

    // 修改 2: 使用独立 Scope 执行数据库查询
    private async Task LoadOrgList(OrgType type)
    {
        // 创建一个新的作用域
        using var scope = ScopeFactory.CreateScope();

        // 从新作用域中获取 DepartmentsService
        // 这样 Service 内部使用的 DbContext 就是全新的，不会与主页面冲突
        var deptService = scope.ServiceProvider.GetRequiredService<DepartmentsService>();

        // 执行查询
        OrgItems = await deptService.GetOrgSelectListAsync(type);

        // 回显补全逻辑
        if (!string.IsNullOrEmpty(Value) && !OrgItems.Any(x => x.Value == Value))
        {
            OrgItems.Add(new SelectedItem(Value, CurrentOrgName ?? "未知单位"));
        }

        // 强制刷新组件 UI
        StateHasChanged();
    }
}