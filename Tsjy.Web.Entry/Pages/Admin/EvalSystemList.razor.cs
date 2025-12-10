using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Service;
namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class EvalSystemList
    {
        [Inject]
        [NotNull]
        private EvalNodeService? NodeService { get; set; }

        [Inject]
        [NotNull]
        private SwalService? Swal { get; set; }
        [Inject]
        [NotNull]
        private ToastService? Toast { get; set; }
        [Inject]
        [NotNull]
        private NavigationManager? Nav { get; set; }

        private List<EvalSystemListDto> SystemItems { get; set; } = new();
        private bool IsLoading { get; set; } = false;

        // 绑定表格数据源，用于手动刷新
        private Table<EvalSystemListDto>? SystemTable { get; set; }

        private string CurrentCategory { get; set; } = "special_school";

        private List<SelectedItem> CategoryOptions { get; } = new()
        {
            new("special_school", "特殊教育学校评价体系"),
            new("inclusive_school", "融合教育学校评价体系"),
            new("education_bureau", "教育局评价体系")
        };

        protected override async Task OnInitializedAsync()
        {
            await LoadData();
        }

        // 加载所有根节点（根体系列表）
        private async Task LoadData()
        {
            if (IsLoading) return;

            IsLoading = true;
            try
            {
                SystemItems = await NodeService.GetSystemListAsync(CurrentCategory);
            }
            finally
            {
                IsLoading = false;
                // 确保 UI 刷新
                StateHasChanged();
            }
        }

        // ★★★ 新增：表格查询事件 (手动从内存分页) ★★★
        private Task<QueryData<EvalSystemListDto>> OnQueryAsync(QueryPageOptions options)
        {
            // 简单实现内存分页
            var total = SystemItems.Count;
            var pagedItems = SystemItems
                                .Skip((options.PageIndex - 1) * options.PageItems)
                                .Take(options.PageItems)
                                .ToList();

            return Task.FromResult(new QueryData<EvalSystemListDto>
            {
                Items = pagedItems,
                TotalCount = total
            });
        }


        private async Task OnCategoryChanged(SelectedItem item)
        {
            if (IsLoading) return;
            CurrentCategory = item.Value;
            await LoadData();
            if (SystemTable != null)
            {
                await SystemTable.QueryAsync();
            }
        }

        private async Task OnCreateSystem()
        {
            var op = new SwalOption()
            {
                Category = SwalCategory.Question,
                Title = "新建体系",
                Content = $"确定要在 **{CategoryOptions.FirstOrDefault(x => x.Value == CurrentCategory)?.Text}** 下创建一个新的空白体系吗？",
                IsConfirm = true,

                OnConfirmAsync = async () =>
                {
                    // 调用 CreateTree，它返回根节点的 ID
                    var newId = await NodeService.CreateTree(CurrentCategory, $"{DateTime.Now.Year}年新评价体系");
                    await SystemTable!.QueryAsync(); // 刷新列表

                   
                }
            };
            await Swal.Show(op);
        }

        // ★★★ 新增：跳转到构建器页面（查看/编辑）★★★
        private void OnEditSystem(EvalSystemListDto item)
        {
            Nav.NavigateTo($"/Admin/EvalBuilder/{item.Category}/{item.Id}");
        }

        private async Task OnDelete(EvalSystemListDto item)
        {
            await Swal.Show(new SwalOption()
            {
                Category = SwalCategory.Warning,
                Title = "警告",
                Content = $"确定要删除体系 **{item.Name}** 吗？这将清空该体系下所有指标和数据，操作不可逆。",
                IsConfirm = true,
                OnConfirmAsync = async () =>
                {
                    // 假设 NodeService 中 DeleteTree 方法已实现
                    // await NodeService.DeleteTree(item.Category, item.Id); 

                    // 【临时模拟删除】如果你的后端删除方法尚未实现，请先注释掉真实的调用
                    // 假设删除成功，刷新列表
                    await LoadData();
                    await SystemTable!.QueryAsync();
                    await Toast.Success("删除成功", $"体系 {item.Name} 已被移除。");
                }
            });
        }

        // 移除 OnSaveAsync, OnDeleteAsync, OnEditAsync 等，因为我们不使用 Table 的默认弹窗
    }
}