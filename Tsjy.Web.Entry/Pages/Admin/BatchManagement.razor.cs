using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;
using Tsjy.Application.System.Dtos.BatchDtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.Admin;

public partial class BatchManagement
{
    [Inject]
    [NotNull]
    private IBatchService? BatchService { get; set; }

    [Inject]
    [NotNull]
    private ToastService? ToastService { get; set; }
    [Inject]
    [NotNull]
    private DialogService? DialogService { get; set; } // 注入 DialogService
    private OrgType? SearchOrgType { get; set; }

    // 含义：是否查看未启用(已删除)的批次
    private bool ShowInactiveBatches { get; set; } = false;

    [NotNull]
    private Table<BatchListDto>? BatchTable { get; set; }


    /// <summary>
    /// 点击【新建批次】按钮
    /// </summary>
   
    private async Task OnCreateBatch()
    {
        // 弹出 TaskDistribute 组件
        // ★★★ 修复1: 将 ShowModal 改为 Show ★★★
        await DialogService.Show(new ResultDialogOption()
        {
            Title = "新建评价批次",
            // 使用 Show 方法时，ComponentParameters 可能不会自动生效，
            // 依赖 BodyTemplate 手动传递参数是更灵活的做法 (您下面已经写了)
            BodyTemplate = builder =>
            {
                builder.OpenComponent<TaskDistribute>(0);
                // 传递参数
                builder.AddAttribute(1, nameof(TaskDistribute.Model), new BatchInputDto());

                // 传递回调
                builder.AddAttribute(2, nameof(TaskDistribute.OnClose), new Func<Task>(async () => {
                    // 关闭弹窗逻辑需结合 Dialog 的 Close 方法，或者依靠 TaskDistribute 内部逻辑
                    // 这里的简单做法是刷新表格
                    await BatchTable.QueryAsync();
                }));

                builder.CloseComponent();
            },
            // 如果希望隐藏默认的“保存/关闭”按钮，完全由组件内部控制
            // ShowFooter = false 
        });
    }
    /// <summary>
    /// 点击【名单管理】按钮
    /// </summary>
    private async Task OnAssignTargets(BatchListDto batch)
    {
        // 暂时只显示一个弹窗占位
        // ★★★ 修复2: 将 ModalDialogOption 改为 DialogOption ★★★
        await DialogService.Show(new DialogOption()
        {
            Title = $"管理名单 - {batch.Name}",
            BodyTemplate = builder =>
            {
                builder.AddContent(0, "这里将放置名单选择功能（待开发）...");
            },
            Size = Size.Large
        });
    }

    private async Task<QueryData<BatchListDto>> OnQueryAsync(QueryPageOptions options)
    {
        // 传入 ShowInactiveBatches 作为 includeDeleted 参数
        // true: 查看所有（包含未启用/已删除）； false: 只看启用
        var items = await BatchService.GetListAsync(SearchOrgType, ShowInactiveBatches);

        if (!string.IsNullOrEmpty(options.SearchText))
        {
            items = items.Where(i => i.Name.Contains(options.SearchText, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        var total = items.Count;
        var pagedItems = items.Skip((options.PageIndex - 1) * options.PageItems)
                              .Take(options.PageItems)
                              .ToList();

        return new QueryData<BatchListDto>()
        {
            Items = pagedItems,
            TotalCount = total
        };
    }

    private async Task CheckProgress(long batchId)
    {
        await ToastService.Information("提示", $"正在查看批次 {batchId} 的进度...");
    }

    private async Task OnStatusChanged(BatchListDto item, bool val)
    {
        // val 为 true (启用) => 对应 IsDeleted = false
        await BatchService.UpdateStatusAsync(item.Id, val);

        // 更新本地状态以立即反映在 UI (DTO 中 IsEnabled 封装了 !IsDeleted)
        item.IsEnabled = val;

        await ToastService.Success("操作成功", $"批次状态已更新为 {(val ? "启用" : "禁用")}");

        // 如果当前是“只看启用”模式，并且用户点了禁用，刷新表格让该行消失
        if (!ShowInactiveBatches && !val)
        {
            await BatchTable.QueryAsync();
        }
    }
}