using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;
using Tsjy.Application.System.Dtos.BatchDtos;
using Tsjy.Application.System.IService;

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
    private SwalService? SwalService { get; set; }

    private List<BatchListDto> Items { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        await LoadData();
    }

    private async Task LoadData()
    {
        Items = await BatchService.GetListAsync();
    }

    private async Task OnStatusChanged(BatchListDto item, bool val)
    {
        item.IsEnabled = val;
        await BatchService.UpdateStatusAsync(item.Id, val);
        await ToastService.Success("操作成功", $"批次 {item.Name} 状态已更新");
    }

    /// <summary>
    /// 保存方法 (重命名为 OnSave 以匹配 Lambda 调用)
    /// </summary>
    protected async Task<bool> OnSave(BatchListDto item, ItemChangedType changedType)
    {
        if (changedType == ItemChangedType.Update)
        {
            var input = new BatchInputDto
            {
                Id = item.Id,
                Name = item.Name,
                Status = item.Status
            };

            await BatchService.UpdateAsync(input);
            await LoadData();
            await ToastService.Success("提示", "修改成功");
            return true;
        }
        return false;
    }

    private async Task OnDelete(BatchListDto item)
    {
        var ret = await SwalService.ShowModal(new SwalOption()
        {
            Category = SwalCategory.Warning,
            Title = "删除确认",
            Content = $"确定要删除批次【{item.Name}】吗？此操作不可恢复。",
            ShowClose = true
        });

        if (ret)
        {
            await BatchService.DeleteAsync(item.Id);
            await LoadData();
            await ToastService.Success("提示", "删除成功");
        }
    }
}