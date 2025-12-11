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
            
            return Task.FromResult(newItem);
        }

        // 编辑按钮回调 - 修复级联失效的关键
        private Task<bool> OnEditAsync(RegionDto item)
        {
            IsAdding = false;
         
            return Task.FromResult(true);
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