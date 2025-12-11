using System.Diagnostics.CodeAnalysis;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.BasicDataDtos;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class RegionList
    {
        [Inject] private BasicDataService DataService { get; set; }
        [Inject] private ToastService Toast { get; set; }

        [NotNull]
        private Table<RegionDto>? Table { get; set; }

        // 缓存所有数据
        private List<RegionDto> AllRegions { get; set; } = new();

        // 动态计算的父级选项
        private List<SelectedItem> ParentItems { get; set; } = new();

        // 动态提示文字
        private string ParentPlaceholder { get; set; } = "请先选择行政级别";

        private bool IsAdding { get; set; } = false;

        private async Task<QueryData<RegionDto>> OnQueryAsync(QueryPageOptions options)
        {
            // 获取最新全量数据，确保修改时下拉框内容完整
            AllRegions = await DataService.GetRegionsAsync();

            var data = AllRegions;
            if (!string.IsNullOrEmpty(options.SearchText))
            {
                data = data.Where(x => x.Name.Contains(options.SearchText) || x.Code.Contains(options.SearchText)).ToList();
            }

            return new QueryData<RegionDto>
            {
                Items = data,
                TotalCount = data.Count,
                IsFiltered = true,
                IsSorted = true,
                IsSearch = true
            };
        }

        /// <summary>
        /// 确保弹窗打开时的级联状态（新建和编辑都会调用）
        /// </summary>
        private void EnsureCascadingState(RegionDto model)
        {
            // 根据当前模型的级别，加载对应的父级列表
            UpdateParentItems(model.Level);
        }

        /// <summary>
        /// 当行政级别改变时
        /// </summary>
        private async Task OnLevelChanged(RegionLevel level, RegionDto model)
        {
            model.Level = level;
            model.ParentCode = ""; // 级别变了，清空已选的父级
            UpdateParentItems(level);
            StateHasChanged();
            await Task.CompletedTask;
        }

        /// <summary>
        /// 核心逻辑：根据级别筛选父级列表
        /// </summary>
        private void UpdateParentItems(RegionLevel level)
        {
            IEnumerable<RegionDto> query = new List<RegionDto>();

            switch (level)
            {
                case RegionLevel.Province:
                    // 省级：没有父级
                    query = Enumerable.Empty<RegionDto>();
                    ParentPlaceholder = "省级区域无父级代码";
                    break;

                case RegionLevel.City:
                    // 市级：父级必须是 省
                    query = AllRegions.Where(x => x.Level == RegionLevel.Province);
                    ParentPlaceholder = "请选择所属省份";
                    break;

                case RegionLevel.District:
                    // 区县级：父级必须是 市
                    query = AllRegions.Where(x => x.Level == RegionLevel.City);
                    ParentPlaceholder = "请选择所属城市";
                    break;

                default:
                    // 其他情况
                    query = Enumerable.Empty<RegionDto>();
                    ParentPlaceholder = "请先选择行政级别";
                    break;
            }

            // 转换数据源
            ParentItems = query.Select(x => new SelectedItem(x.Code, x.Name)).ToList();
        }

        // 处理树形结构
        private Task<IEnumerable<TableTreeNode<RegionDto>>> OnTreeNodeConverter(IEnumerable<RegionDto> items)
        {
            var rootItems = items.Where(i => string.IsNullOrEmpty(i.ParentCode)).ToList();
            var ret = BuildTreeNodes(rootItems, items);
            return Task.FromResult(ret);
        }

        private IEnumerable<TableTreeNode<RegionDto>> BuildTreeNodes(IEnumerable<RegionDto> currentLevelItems, IEnumerable<RegionDto> allItems)
        {
            var nodes = new List<TableTreeNode<RegionDto>>();
            foreach (var item in currentLevelItems)
            {
                var node = new TableTreeNode<RegionDto>(item);
                var children = allItems.Where(i => i.ParentCode == item.Code).ToList();
                if (children.Any())
                {
                    node.Items = BuildTreeNodes(children, allItems).ToList();
                    node.HasChildren = true;
                }
                nodes.Add(node);
            }
            return nodes;
        }

        // 新建按钮回调
        private Task<RegionDto> OnAddAsync()
        {
            IsAdding = true;
            var newItem = new RegionDto();
            // 默认 RegionDto 的 Level 可能是 Province (0)，
            // 我们初始化一下，让界面状态正确（父级为空，提示无父级）
            UpdateParentItems(newItem.Level);
            return Task.FromResult(newItem);
        }

        private async Task<bool> OnSaveAsync(RegionDto dto, ItemChangedType changedType)
        {
            IsAdding = false;
            await DataService.SaveRegionAsync(dto);
            // 刷新数据
            AllRegions = await DataService.GetRegionsAsync();
            return true;
        }

        private async Task<bool> OnDeleteAsync(IEnumerable<RegionDto> items)
        {
            foreach (var item in items) await DataService.DeleteRegionAsync(item.Code);
            // 刷新数据
            AllRegions = await DataService.GetRegionsAsync();
            return true;
        }

        private async Task OnStatusChanged(RegionDto item, bool isEnabled)
        {
            await DataService.UpdateRegionStatusAsync(item.Code, !isEnabled);
            item.IsDeleted = !isEnabled;
            await Toast.Success("操作成功");
        }
    }
}