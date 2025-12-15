using System.Diagnostics.CodeAnalysis;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Tsjy.Application.System.Dtos.BatchDtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Enums;
using Tsjy.Web.Entry.Shared;

namespace Tsjy.Web.Entry.Pages.Admin;

public partial class BatchManagement
{
    [Inject]
    [NotNull]
    private IBatchService? BatchService { get; set; }

    [Inject]
    [NotNull]
    private DialogService? DialogService { get; set; }

    [Inject]
    [NotNull]
    private ToastService? ToastService { get; set; }

    [Inject]
    [NotNull]
    private SwalService? SwalService { get; set; }

    private Table<BatchListDto>? Table { get; set; }

    private List<SelectedItem> OrgTypeItems { get; set; } = new();
    // 搜索模型实例
    private BatchSearchModel SearchModel { get; set; } = new();
    protected override void OnInitialized()
    {
        base.OnInitialized();
        // 初始化下拉框
        OrgTypeItems = typeof(OrgType).ToSelectList(new SelectedItem("", "全部类型")).ToList();
    }

    private async Task<QueryData<BatchListDto>> OnQueryAsync(QueryPageOptions options)
    {
        // 1. 获取所有数据 (建议改为分页查询接口)
        
        var allData = await BatchService.GetListAsync(SearchModel.TargetType);
        var items = allData.AsEnumerable();

        // 2. 处理 Table 自带的搜索框 (options.SearchText)
        if (!string.IsNullOrEmpty(options.SearchText))
        {
            items = items.Where(i => i.Name.Contains(options.SearchText, StringComparison.OrdinalIgnoreCase));
        }

        // 3. 处理自定义高级搜索 (SearchTemplate 中的 context)
        // 关键修复：从 options.SearchModel 获取强类型对象
        var searchModel = options.SearchModel as BatchListDto;
        if (searchModel != null)
        {
            if (!string.IsNullOrEmpty(searchModel.Name))
            {
                items = items.Where(i => i.Name.Contains(searchModel.Name, StringComparison.OrdinalIgnoreCase));
            }

            // 注意：枚举默认值可能是第一个选项，需要根据实际业务判断
            // 这里假设如果不选或选了默认值，就不进行过滤
            // 由于 Select 组件如果选了 "全部类型" (Value=""), 则不会赋值给 OrgType
            // 但如果 searchModel.TargetType 是 OrgType 类型，它总会有一个值。
            // 建议：在 BatchListDto 中将 TargetType 设为 OrgType? (可空)，或者在搜索时检查
            // 简单起见，这里暂不处理 TargetType 过滤，或者您需要确保 BatchListDto.TargetType 是可空的
        }

        // 4. 处理排序
        //if (!string.IsNullOrEmpty(options.SortName))
        //{
        //    if (options.SortName == nameof(BatchListDto.StartAt))
        //    {
        //        items = options.SortOrder == SortOrder.Asc ? items.OrderBy(i => i.StartAt) : items.OrderByDescending(i => i.StartAt);
        //    }
        //    // ... 其他列排序
        //}

        // 5. 分页
        var total = items.Count();
        var pagedItems = items.Skip((options.PageIndex - 1) * options.PageItems)
                              .Take(options.PageItems)
                              .ToList();

        return new QueryData<BatchListDto>
        {
            Items = pagedItems,
            TotalCount = total
        };
    }

    private Task OnSearch()
    {
        return Table!.QueryAsync();
    }

    private Task OnReset()
    {
        SearchModel.Name = null;
        SearchModel.TargetType = null;
        return Table!.QueryAsync();
    }

    private async Task OnAdd()
    {
        await ShowEditDialog(new BatchInputDto());
    }

    private async Task OnEdit(BatchListDto item)
    {
        // 调用新加的 GetDetailAsync
        var detail = await BatchService.GetDetailAsync(item.Id);
        await ShowEditDialog(detail);
    }

    private async Task ShowEditDialog(BatchInputDto model)
    {
        await DialogService.Show(new DialogOption
        {
            Title = model.Id > 0 ? "编辑批次" : "新建批次",
            // 使用 Component 属性加载组件
            Component = BootstrapDynamicComponent.CreateComponent<TaskDistribute>(new Dictionary<string, object?>
            {
                { nameof(TaskDistribute.Model), model },
                { nameof(TaskDistribute.OnClose), new Func<Task>(async () =>
                  {
                      // 关键修复：DialogService 没有 Close() 方法。
                      // 我们不需要在这里手动 Close，因为 TaskDistribute 内部的按钮或 Dialog 框架会处理。
                      // 如果您想通过代码关闭当前弹窗，通常需要在 TaskDistribute 内部接收 DialogOption 并调用其 CloseDialogAsync
                      
                      // 简单做法：这里只负责刷新表格。关闭动作为 TaskDistribute 内部逻辑（如果它是模态框）。
                      // 如果 TaskDistribute 是作为 Dialog Body 显示的，点击其内部按钮时，
                      // 应该调用 [CascadingParameter] Func<Task> OnCloseAsync 来关闭自己。
                      
                      // 假设您在 TaskDistribute.razor.cs 里处理了关闭逻辑，这里只负责刷新：
                      await Table!.QueryAsync();
                  })
                }
            })
        });
    }

    private async Task OnDelete(BatchListDto item)
    {
        var ret = await SwalService.ShowModal(new SwalOption
        {
            Title = "确认删除?",
            Content = $"是否确定删除批次“{item.Name}”？此操作不可恢复。",
            Category = SwalCategory.Warning,
        });

        if (ret)
        {
            await BatchService.DeleteAsync(item.Id);
            await ToastService.Success("提示", "删除成功");
            await Table!.QueryAsync();
        }
    }
    private async Task OnDistribute(BatchListDto item)
    {
        await DialogService.Show(new DialogOption
        {
            Title = $"任务发布向导 - {item.Name}",
            Size = Size.ExtraLarge, // 推荐使用特大号弹窗
            Component = BootstrapDynamicComponent.CreateComponent<BatchDistributeWidget>(new Dictionary<string, object?>
        {
            { nameof(BatchDistributeWidget.BatchInfo), item },
            { nameof(BatchDistributeWidget.OnClose), new Func<Task>(async () =>
              {
                  // 刷新列表
                  await Table!.QueryAsync();
              })
            }
        })
        });
    }

    /// <summary>
    /// 显示时间排期详情弹窗 (组件化版)
    /// </summary>
    private async Task ShowScheduleInfo(BatchListDto item)
    {
        await DialogService.Show(new DialogOption
        {
            Title = $"{item.Name} - 时间安排",
            // 使用组件渲染内容
            Component = BootstrapDynamicComponent.CreateComponent<BatchScheduleWidget>(new Dictionary<string, object?>
            {
                // 传递参数给组件
                { nameof(BatchScheduleWidget.BatchInfo), item }
            })
        });
    }
    public class BatchSearchModel
    {
        public string? Name { get; set; }
        public OrgType? TargetType { get; set; }
    }
}