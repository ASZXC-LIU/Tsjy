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
    /// <summary>
    /// 搜索用的机构类型
    /// </summary>
    private OrgType? SearchOrgType { get; set; }

    /// <summary>
    /// 表格组件引用，用于刷新
    /// </summary>
    [NotNull]
    private Table<BatchListDto>? BatchTable { get; set; }
    /// <summary>
    /// 数据查询方法 (接管数据加载)
    /// </summary>
    private async Task<QueryData<BatchListDto>> OnQueryAsync(QueryPageOptions options)
    {
        // 1. 获取所有数据
        // 注意：如果 IBatchService 将来支持分页查询，应优先使用分页接口
        var items = await BatchService.GetListAsync(SearchOrgType);

        // 2. 内存中进行搜索过滤
        if (!string.IsNullOrEmpty(options.SearchText))
        {
            items = items.Where(i => i.Name.Contains(options.SearchText, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // 3. 内存分页
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
    /// <summary>
    /// 查看进度点击事件
    /// </summary>
    private async Task CheckProgress(long batchId)
    {
        // TODO: 这里写具体的跳转逻辑或弹窗逻辑
        await ToastService.Information("提示", $"正在查看批次 {batchId} 的进度...");
    }
    /// <summary>
    /// 保存方法 (新增/编辑)
    /// </summary>
    private async Task<bool> OnSaveAsync(BatchListDto item, ItemChangedType changedType)
    {
        // 目前 IBatchService 似乎只提供了 UpdateAsync，未提供 Add 接口
        // 如果需要新增功能，请确保 Service 层有对应方法
        if (changedType == ItemChangedType.Update)
        {
            var input = new BatchInputDto
            {
                Id = item.Id,
                Name = item.Name,
                Status = item.Status
            };

            await BatchService.UpdateAsync(input);
            await ToastService.Success("提示", "修改成功");
            return true;
        }
        else if (changedType == ItemChangedType.Add)
        {
            // 如果后续实现了 CreateAsync，请在这里调用
            await ToastService.Warning("提示", "暂不支持新增批次，请联系管理员");
            return false;
        }

        return false;
    }

    /// <summary>
    /// 删除方法
    /// </summary>
    private async Task<bool> OnDeleteAsync(IEnumerable<BatchListDto> items)
    {
        foreach (var item in items)
        {
            await BatchService.DeleteAsync(item.Id);
        }
        await ToastService.Success("提示", "删除成功");
        return true;
    }

    /// <summary>
    /// 状态切换处理
    /// </summary>
    private async Task OnStatusChanged(BatchListDto item, bool val)
    {
        // 1. 调用 Service 更新
        await BatchService.UpdateStatusAsync(item.Id, val);

        // 2. 更新本地对象状态 (IsEnabled setter 会自动更新 Status 枚举)
        item.IsEnabled = val;

        await ToastService.Success("操作成功", $"批次 {item.Name} 状态已更新");
    }
}