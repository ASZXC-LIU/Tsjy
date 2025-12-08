using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;
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

        // 表格引用，用于刷新
        private Table<ScoringModel>? ScoringTable { get; set; }

        // 弹窗引用
        private Modal? EditModal { get; set; }

        private string ModalTitle { get; set; } = "新建评分模板";

        // 当前编辑的 DTO
        private ScoringModelDto EditModel { get; set; } = new();

        /// <summary>
        /// 查询数据（列表）
        /// </summary>
        private async Task<QueryData<ScoringModel>> OnQueryAsync(QueryPageOptions options)
        {
            var items = await ScoringService.GetList();
            return new QueryData<ScoringModel>
            {
                Items = items,
                TotalCount = items.Count
            };
        }

        /// <summary>
        /// 新建
        /// </summary>
        private Task OnCreateClick()
        {
            ModalTitle = "新建评分模板";
            EditModel = new ScoringModelDto
            {
                Items = new List<ScoringModelItemDto>
                {
                    new ScoringModelItemDto { Ratio = 1.0m, Description = "优秀" },
                    new ScoringModelItemDto { Ratio = 0.8m, Description = "良好" }
                }
            };

            EditModal?.Toggle();
            return Task.CompletedTask;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        private async Task OnEditClick(ScoringModel model)
        {
            ModalTitle = "编辑评分模板";
            EditModel = await ScoringService.GetDetail(model.Id);
            EditModal?.Toggle();
        }

        /// <summary>
        /// 弹窗内“保存”
        /// </summary>
        private async Task OnConfirmSave()
        {
            try
            {
                // 简单校验
                if (string.IsNullOrWhiteSpace(EditModel.Name))
                {
                    await Toast.Error("提示", "模板名称不能为空");
                    return;
                }
                if (EditModel.Items == null || !EditModel.Items.Any())
                {
                    await Toast.Error("提示", "至少需要一个评分等级");
                    return;
                }

                await ScoringService.Save(EditModel);

                await Toast.Success("保存成功");
                if (EditModal != null)
                {
                    await EditModal.Close();
                }

                // 刷新表格数据
                if (ScoringTable != null)
                {
                    await ScoringTable.QueryAsync();
                }
            }
            catch (Exception ex)
            {
                await Toast.Error("保存失败", ex.Message);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        private async Task<bool> OnDeleteAsync(IEnumerable<ScoringModel> items)
        {
            foreach (var item in items)
            {
                await ScoringService.Delete(item.Id);
            }

            await Toast.Success("删除成功");

            // 删除后顺便刷新表格
            if (ScoringTable != null)
            {
                await ScoringTable.QueryAsync();
            }

            return true;
        }

        #region 弹窗内子项操作

        private void OnAddItem()
        {
            if (EditModel.Items == null)
            {
                EditModel.Items = new List<ScoringModelItemDto>();
            }

            decimal nextRatio = 0.6m;
            if (EditModel.Items.Any())
            {
                var min = EditModel.Items.Min(x => x.Ratio);
                nextRatio = min >= 0.2m ? min - 0.2m : 0;
            }

            EditModel.Items.Add(new ScoringModelItemDto
            {
                Ratio = nextRatio,
                Description = string.Empty
            });

            StateHasChanged();
        }

        private void OnRemoveItem(ScoringModelItemDto item)
        {
            EditModel.Items.Remove(item);
            StateHasChanged();
        }

        #endregion
    }
}
