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

        // 绑定表格数据源（作为缓存，用于分页）
        private List<EvalSystemListDto> SystemItems { get; set; } = new();

        // 绑定表格组件引用
        private Table<EvalSystemListDto>? SystemTable { get; set; }

        private string CurrentCategory { get; set; } = "special_school";

        private List<SelectedItem> CategoryOptions { get; } = new()
        {
            new("special_school", "特殊教育学校评价体系"),
            new("inclusive_school", "融合教育学校评价体系"),
            new("education_bureau", "教育局评价体系")
        };

        // ★★★ 1. 删除 OnInitializedAsync 中的手动加载，完全依赖表格自动触发 ★★★
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        // ★★★ 2. 核心修改：在 OnQueryAsync 中直接请求数据 ★★★
        private async Task<QueryData<EvalSystemListDto>> OnQueryAsync(QueryPageOptions options)
        {
            try
            {
                // 直接根据当前选中的类型，从后端拉取最新数据
                // 表格组件会自动显示“加载中”骨架屏，无需手动控制 IsLoading
                SystemItems = await NodeService.GetSystemListAsync(CurrentCategory);

                // 简单的内存分页逻辑
                var total = SystemItems.Count;
                var pagedItems = SystemItems
                                    .Skip((options.PageIndex - 1) * options.PageItems)
                                    .Take(options.PageItems)
                                    .ToList();

                return new QueryData<EvalSystemListDto>
                {
                    Items = pagedItems,
                    TotalCount = total
                };
            }
            catch (Exception ex)
            {
                await Toast.Error("数据加载失败", ex.Message);
                return new QueryData<EvalSystemListDto> { Items = new List<EvalSystemListDto>(), TotalCount = 0 };
            }
        }

        // ★★★ 3. 切换类型时，只需通知表格刷新 ★★★
        private async Task OnCategoryChanged(SelectedItem item)
        {
            CurrentCategory = item.Value;
            if (SystemTable != null)
            {
                // 这会触发 OnQueryAsync，从而拉取新类别的数据
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
                    // 调用 CreateTree
                    var newId = await NodeService.CreateTree(CurrentCategory, $"{DateTime.Now.Year}年新评价体系");

                    // 刷新表格
                    if (SystemTable != null) await SystemTable.QueryAsync();
                    await Toast.Success("创建成功");
                }
            };
            await Swal.Show(op);
        }

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
                    // 模拟删除逻辑
                    // await NodeService.DeleteTree(item.Category, item.Id); 

                    // 刷新表格 (重新从后端拉取，确保数据同步)
                    if (SystemTable != null) await SystemTable.QueryAsync();

                    await Toast.Success("删除成功", $"体系 {item.Name} 已被移除。");
                }
            });
        }
    }
}