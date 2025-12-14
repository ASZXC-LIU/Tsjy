using System.Diagnostics.CodeAnalysis;
using BootstrapBlazor.Components;
using Furion.DatabaseAccessor;
using Mapster;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Entities;

namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class ScoringModels
    {
        [Inject]
        [NotNull]
        private IScoringModelService? ScoringService { get; set; }

        [Inject]
        [NotNull]
        private ToastService? Toast { get; set; }

        [Inject]
        private IServiceScopeFactory? ScopeFactory { get; set; }

        [Inject]
        [NotNull]
        private SwalService? Swal { get; set; }

        // 编辑弹窗绑定的 DTO
        private ScoringModelDto EditModel { get; set; } = new();

        /// <summary>
        /// 表格查询数据
        /// </summary>
        private async Task<QueryData<ScoringModel>> OnQueryAsync(QueryPageOptions options)
        {
            // 1. 获取全量数据
            // 注意：对于只有几百条数据的“配置表”，一次性取回再内存分页是最高效的，无需改后端接口
            var items = await ScoringService.GetList();

            // 2. 处理搜索 (如果启用了 ShowSearch)
            if (!string.IsNullOrEmpty(options.SearchText))
            {
                items = items.Where(i => i.Name.Contains(options.SearchText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // 3. 处理排序
            if (!string.IsNullOrEmpty(options.SortName))
            {
                // 简单的内存排序
                if (options.SortName == nameof(ScoringModel.UpdatedAt))
                {
                    items = options.SortOrder == SortOrder.Asc
                        ? items.OrderBy(i => i.UpdatedAt).ToList()
                        : items.OrderByDescending(i => i.UpdatedAt).ToList();
                }
            }

            // 4. 处理分页
            var total = items.Count;
            var pagedItems = items.Skip((options.PageIndex - 1) * options.PageItems)
                                  .Take(options.PageItems)
                                  .ToList();

            return new QueryData<ScoringModel>
            {
                Items = pagedItems,
                TotalCount = total, // 关键：必须返回总数，Table 才能计算出有多少页
                IsFiltered = !string.IsNullOrEmpty(options.SearchText),
                IsSorted = !string.IsNullOrEmpty(options.SortName)
            };
        }

        /// <summary>
        /// 点击“新建”按钮时触发
        /// </summary>
        private Task<ScoringModel> OnAddAsync()
        {
            // 初始化默认 DTO，提供一个友好的默认模板
            EditModel = new ScoringModelDto
            {
                Items = new List<ScoringModelItemDto>
                {
                    new ScoringModelItemDto { Ratio = 1.0m, Description = "优秀" },
                    new ScoringModelItemDto { Ratio = 0.8m, Description = "良好" },
                    new ScoringModelItemDto { Ratio = 0.6m, Description = "及格" }
                }
            };

            return Task.FromResult(new ScoringModel());
        }

        /// <summary>
        /// 点击“编辑”按钮时触发
        /// </summary>
        private async Task<bool> OnEditAsync(ScoringModel model)
        {
            try
            {
                // 使用 Scope 获取带有 Include 的完整实体
                using var scope = ScopeFactory!.CreateScope();
                var repo = scope.ServiceProvider.GetRequiredService<IRepository<ScoringModel>>();

                var entity = await repo.Include(u => u.Items)
                                       .FirstOrDefaultAsync(u => u.Id == model.Id);

                if (entity == null) return false;

                // 映射到 EditModel 供弹窗绑定
                EditModel = entity.Adapt<ScoringModelDto>();
                return true;
            }
            catch (Exception ex)
            {
                await Toast.Error("加载失败", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 点击弹窗“保存”时触发 (已修复 Bug)
        /// </summary>
        private async Task<bool> OnSaveAsync(ScoringModel item, ItemChangedType changedType)
        {
            try
            {
                // 核心逻辑：
                // 我们不使用参数中的 item (它是 Table 的 TItem)，
                // 而是使用绑定了弹窗表单的 EditModel (DTO)。

                // 1. 设置 ID
                if (changedType == ItemChangedType.Update)
                {
                    // 确保 DTO ID 正确
                    EditModel.Id = item.Id;
                }
                else
                {
                    EditModel.Id = 0;
                }

                // 2. 调用 Service 保存 DTO
                await ScoringService.Save(EditModel);

                await Toast.Success("保存成功", "模板已更新");
                return true;
            }
            catch (Exception ex)
            {
                await Toast.Error("保存失败", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 点击“删除”按钮时触发
        /// </summary>
        private async Task<bool> OnDeleteAsync(IEnumerable<ScoringModel> items)
        {
            try
            {
                if (!items.Any()) return false;

                foreach (var item in items)
                {
                    await ScoringService.Delete(item.Id);
                }

                await Toast.Success("删除成功");
                return true;
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException.Message.Contains("FOREIGN KEY"))
                {
                    await Swal.Show(new SwalOption()
                    {
                        Category = SwalCategory.Error,
                        Title = "无法删除",
                        Content = "该评分模板正在被评价指标使用，请先解除关联。"
                    });
                }
                else
                {
                    await Toast.Error("删除失败", ex.Message);
                }
                return false;
            }
        }

        /// <summary>
        /// UI 辅助：根据等级代码返回 Bootstrap 颜色样式
        /// </summary>
        private string GetBadgeColor(string levelCode)
        {
            return levelCode switch
            {
                "A" => "bg-primary-subtle text-primary border-primary-subtle", // 浅蓝
                "B" => "bg-success-subtle text-success border-success-subtle", // 浅绿
                "C" => "bg-warning-subtle text-warning border-warning-subtle", // 浅黄
                "D" => "bg-danger-subtle text-danger border-danger-subtle",    // 浅红
                _ => "bg-light text-secondary border-secondary-subtle"         // 灰色
            };
        }
    }
}