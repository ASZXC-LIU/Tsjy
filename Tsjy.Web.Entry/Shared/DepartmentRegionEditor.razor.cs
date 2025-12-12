using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Tsjy.Application.System.Dtos.BasicDataDtos;
using Tsjy.Core.Enums; // 确保引用了 RegionLevel 枚举所在的命名空间

namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class DepartmentRegionEditor
    {
        /// <summary>
        /// 双向绑定的值（区/县 Code）
        /// </summary>
        [Parameter]
        public string? Value { get; set; }

        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }

        /// <summary>
        /// 所有区域数据源，由父组件传入
        /// </summary>
        [Parameter]
        public List<RegionDto> AllRegions { get; set; } = new();

        // 下拉框数据源
        private List<SelectedItem> ProvinceItems { get; set; } = new();
        private List<SelectedItem> CityItems { get; set; } = new();
        private List<SelectedItem> DistrictItems { get; set; } = new();

        // 内部选中的省市代码
        private string? SelectedProvinceCode { get; set; }
        private string? SelectedCityCode { get; set; }

        /// <summary>
        /// 参数设置时触发，用于初始化数据
        /// </summary>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            // 只有当数据源存在且下拉框未初始化时才执行初始化
            // 这样可以避免每次父组件刷新都重置组件状态
            if (ProvinceItems.Count == 0 && AllRegions != null && AllRegions.Any())
            {
                InitData();
            }
        }

        private void InitData()
        {
            // 1. 加载所有省份
            ProvinceItems = AllRegions.Where(r => r.Level == RegionLevel.Province)
                                      .Select(r => new SelectedItem(r.Code, r.Name))
                                      .ToList();

            // 2. 判断是"编辑模式"（Value有值）还是"新建模式"
            if (!string.IsNullOrEmpty(Value))
            {
                // 反推逻辑：区 -> 市 -> 省
                var district = AllRegions.FirstOrDefault(r => r.Code == Value);
                if (district != null && district.Level == RegionLevel.District)
                {
                    // 找到市
                    var city = AllRegions.FirstOrDefault(r => r.Code == district.ParentCode);
                    if (city != null)
                    {
                        SelectedCityCode = city.Code;
                        DistrictItems = AllRegions.Where(r => r.ParentCode == city.Code)
                                                  .Select(r => new SelectedItem(r.Code, r.Name)).ToList();

                        // 找到省
                        var province = AllRegions.FirstOrDefault(r => r.Code == city.ParentCode);
                        if (province != null)
                        {
                            SelectedProvinceCode = province.Code;
                            CityItems = AllRegions.Where(r => r.ParentCode == province.Code)
                                                  .Select(r => new SelectedItem(r.Code, r.Name)).ToList();
                        }
                    }
                }
            }
            else
            {
                // 新建模式：清空所有选中状态
                SelectedProvinceCode = "";
                SelectedCityCode = "";
                CityItems.Clear();
                DistrictItems.Clear();
            }
        }

        private async Task OnProvinceChanged(SelectedItem item)
        {
            SelectedProvinceCode = item.Value;
            SelectedCityCode = "";

            // 省份变了，意味着底层的区县值肯定要清空，触发 ValueChanged
            await UpdateValueAsync("");

            if (!string.IsNullOrEmpty(SelectedProvinceCode))
            {
                CityItems = AllRegions.Where(r => r.ParentCode == SelectedProvinceCode)
                                      .Select(r => new SelectedItem(r.Code, r.Name))
                                      .ToList();
            }
            else
            {
                CityItems.Clear();
            }
            DistrictItems.Clear();

            // 关键：只刷新当前组件 UI
            StateHasChanged();
        }

        private async Task OnCityChanged(SelectedItem item)
        {
            SelectedCityCode = item.Value;

            // 城市变了，区县值也要重置
            await UpdateValueAsync("");

            if (!string.IsNullOrEmpty(SelectedCityCode))
            {
                DistrictItems = AllRegions.Where(r => r.ParentCode == SelectedCityCode)
                                          .Select(r => new SelectedItem(r.Code, r.Name))
                                          .ToList();
            }
            else
            {
                DistrictItems.Clear();
            }

            StateHasChanged();
        }

        private async Task OnDistrictChanged(SelectedItem item)
        {
            // 最终选择了区县，更新绑定的 Value
            await UpdateValueAsync(item.Value);
        }

        private async Task UpdateValueAsync(string? val)
        {
            Value = val;
            if (ValueChanged.HasDelegate)
            {
                await ValueChanged.InvokeAsync(val);
            }
        }
    }
}