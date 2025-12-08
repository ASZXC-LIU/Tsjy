using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service;
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

        // 编辑弹窗绑定的 DTO
        private ScoringModelDto EditModel { get; set; } = new();
        [Inject]
        [NotNull]
        private SwalService? Swal { get; set; } // 注入 Swal 用于弹窗
        /// <summary>
        /// 表格查询数据
        /// </summary>
        private async Task<QueryData<ScoringModel>> OnQueryAsync(QueryPageOptions options)
        {
            // 获取全量列表（后端做了 IsDeleted 过滤）
            // 如果数据量大，建议后端改为分页接口，这里演示用 GetList
            var items = await ScoringService.GetList();

            // 处理前端搜索/排序/分页
            // BootstrapBlazor 提供了 QueryHelper 来在内存中处理这些，适合中小数据量
            var total = items.Count;
            var pagedItems = items.Skip((options.PageIndex - 1) * options.PageItems).Take(options.PageItems).ToList();

            return new QueryData<ScoringModel>
            {
                Items = pagedItems,
                TotalCount = total
            };
        }

        /// <summary>
        /// 点击“编辑”按钮时触发
        /// </summary>
        private async Task<bool> OnEditAsync(ScoringModel model)
        {
            if (model.Id > 0)
            {
                // 编辑模式：从后端拉取详情（包含 Items）
                try
                {
                    EditModel = await ScoringService.GetDetail(model.Id);
                }
                catch (Exception ex)
                {
                    await Toast.Error("加载失败", ex.Message);
                    return false;
                }
            }
            else
            {
                // 新增模式：初始化一个空的 DTO，并默认给一行数据方便填写
                EditModel = new ScoringModelDto
                {
                    Items = new List<ScoringModelItemDto>
                    {
                        new ScoringModelItemDto { Ratio = 1.0m, Description = "" }, // 默认给个 A
                        new ScoringModelItemDto { Ratio = 0.8m, Description = "" }  // 默认给个 B
                    }
                };
            }
            return true;
        }

        /// <summary>
        /// 点击弹窗“保存”时触发
        /// </summary>
        private async Task<bool> OnSaveAsync(ScoringModel model, ItemChangedType changedType)
        {
            try
            {
                // 简单的表单校验
                if (string.IsNullOrWhiteSpace(EditModel.Name))
                {
                    await Toast.Error("提示", "模板名称不能为空");
                    return false;
                }
                if (EditModel.Items == null || !EditModel.Items.Any())
                {
                    await Toast.Error("提示", "请至少配置一个评分等级");
                    return false;
                }

                // 调用后端 API
                await ScoringService.Save(EditModel);

                await Toast.Success("保存成功");

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
                // 1. 检查选中的项
                if (!items.Any()) return false;

                // 2. 循环删除
                foreach (var item in items)
                {
                    // 建议：在 Service 层增加一个 CheckIsUsed 方法
                    // var isUsed = await ScoringService.IsModelUsed(item.Id);
                    // if (isUsed) throw new Exception($"模板 {item.Name} 正在被指标使用，无法删除！");

                    await ScoringService.Delete(item.Id);
                }

                await Toast.Success("删除成功");
                return true; // 返回 true 会让表格自动刷新 UI
            }
            catch (Exception ex)
            {
                // 3. 重点：如果是外键冲突，给用户明确提示
                if (ex.InnerException != null && ex.InnerException.Message.Contains("FOREIGN KEY"))
                {
                    await Swal.Show(new SwalOption()
                    {
                        Category = SwalCategory.Error,
                        Title = "无法删除",
                        Content = "该评分模板正在被评价指标使用，请先解除关联或删除对应指标后再试。"
                    });
                }
                else
                {
                    await Toast.Error("删除失败", ex.Message);
                }
                return false; // 返回 false，表格不会移除该行
            }
        }

        #region 弹窗内的子表操作

        /// <summary>
        /// 增加一行
        /// </summary>
        private void OnAddItem()
        {
            // 自动推断下一个系数：比如现在有 1.0, 0.8，下一个自动填 0.6
            decimal nextRatio = 0;
            if (EditModel.Items.Any())
            {
                var min = EditModel.Items.Min(x => x.Ratio);
                nextRatio = min >= 0.2m ? min - 0.2m : 0;
            }
            else
            {
                nextRatio = 1.0m;
            }

            EditModel.Items.Add(new ScoringModelItemDto { Ratio = nextRatio });
        }

        /// <summary>
        /// 删除一行
        /// </summary>
        private void OnRemoveItem(ScoringModelItemDto item)
        {
            EditModel.Items.Remove(item);
        }

        #endregion
    }
}