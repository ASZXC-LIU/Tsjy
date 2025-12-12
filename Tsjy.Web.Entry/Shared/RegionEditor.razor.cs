using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Tsjy.Application.System.Dtos.BasicDataDtos;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class RegionEditor
    {
        /// <summary>
        /// 当前编辑的实体
        /// </summary>
        [Parameter]
        public RegionDto Value { get; set; }

        [Parameter]
        public EventCallback<RegionDto> ValueChanged { get; set; }

        /// <summary>
        /// 全量数据（用于筛选父级）
        /// </summary>
        [Parameter]
        public List<RegionDto> AllRegions { get; set; } = new();

        /// <summary>
        /// 是否是新建模式（控制Code是否可编辑）
        /// </summary>
        [Parameter]
        public bool IsAdding { get; set; }

        // 内部状态
        private List<SelectedItem> ParentItems { get; set; } = new();
        private string ParentPlaceholder { get; set; } = "请先选择行政级别";

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            // 初始化时确保下拉框有正确的数据
            if (Value != null)
            {
                UpdateParentItems(Value.Level);
            }
        }

        private async Task OnLevelChanged(RegionLevel level)
        {
            Value.Level = level;
            Value.ParentCode = ""; // 级别变了，清空已选的父级

            UpdateParentItems(level);

            // 触发更新
            if (ValueChanged.HasDelegate)
            {
                await ValueChanged.InvokeAsync(Value);
            }

            // 关键：局部刷新当前组件，立即更新下拉框
            StateHasChanged();
        }

        private void UpdateParentItems(RegionLevel level)
        {
            IEnumerable<RegionDto> query = AllRegions ?? Enumerable.Empty<RegionDto>();

            switch (level)
            {
                case RegionLevel.Province:
                    query = Enumerable.Empty<RegionDto>();
                    ParentPlaceholder = "省级区域无父级代码";
                    break;
                case RegionLevel.City:
                    query = query.Where(x => x.Level == RegionLevel.Province);
                    ParentPlaceholder = "请选择所属省份";
                    break;
                case RegionLevel.District:
                    query = query.Where(x => x.Level == RegionLevel.City);
                    ParentPlaceholder = "请选择所属城市";
                    break;
                default:
                    query = Enumerable.Empty<RegionDto>();
                    ParentPlaceholder = "请先选择行政级别";
                    break;
            }

            ParentItems = query.Select(x => new SelectedItem(x.Code, x.Name)).ToList();
        }
    }
}