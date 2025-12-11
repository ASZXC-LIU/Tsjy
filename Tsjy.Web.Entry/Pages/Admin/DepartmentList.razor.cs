using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.BasicDataDtos;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class DepartmentList
    {
        [Inject] private BasicDataService DataService { get; set; }
        [Inject] private ToastService Toast { get; set; }

        // 所有区域缓存
        private List<RegionDto> AllRegions { get; set; } = new();

        // 下拉框数据源
        private List<SelectedItem> ProvinceItems { get; set; } = new();
        private List<SelectedItem> CityItems { get; set; } = new();
        private List<SelectedItem> DistrictItems { get; set; } = new();

        // 当前选中的省市代码
        private string SelectedProvinceCode { get; set; }
        private string SelectedCityCode { get; set; }

      

        private async Task<QueryData<DepartmentDto>> OnQueryAsync(QueryPageOptions options)
        {
            if (AllRegions == null || AllRegions.Count == 0)
            {
                AllRegions = await DataService.GetRegionsAsync();
                ProvinceItems = AllRegions.Where(r => r.Level == RegionLevel.Province)
                                          .Select(r => new SelectedItem(r.Code, r.Name))
                                          .ToList();
            }

            var data = await DataService.GetDepartmentsAsync();
            if (!string.IsNullOrEmpty(options.SearchText))
            {
                data = data.Where(x => x.Name.Contains(options.SearchText)).ToList();
            }

            return new QueryData<DepartmentDto>
            {
                Items = data.Skip((options.PageIndex - 1) * options.PageItems).Take(options.PageItems),
                TotalCount = data.Count
            };
        }

        // 新建时的初始化
        private Task<DepartmentDto> OnAddAsync()
        {
            var newDto = new DepartmentDto() { IsDeleted = false };
            OnEditAsync(newDto);
            return Task.FromResult(newDto);
        }

        // 编辑时的初始化
        private Task<bool> OnEditAsync(DepartmentDto model)
        {
            // 1. 新建模式（Code为空或其他判断方式），清空数据
            if (string.IsNullOrEmpty(model.Code)) // 或者根据你的业务逻辑判断是否为新建
            {
                SelectedProvinceCode = "";
                SelectedCityCode = "";
                CityItems.Clear();
                DistrictItems.Clear();
                return Task.FromResult(true);
            }

            // 2. 编辑模式：根据 RegionCode 反推回显
            // 注意：这里不需要再判断 _lastInitializedRegionCode 了，因为每次点击编辑都是一次全新的操作，必须重新计算

            // 初始化默认状态
            SelectedProvinceCode = "";
            SelectedCityCode = "";
            CityItems.Clear();
            DistrictItems.Clear();

            if (!string.IsNullOrEmpty(model.RegionCode))
            {
                var district = AllRegions.FirstOrDefault(r => r.Code == model.RegionCode);
                if (district != null && district.Level == RegionLevel.District)
                {
                    var city = AllRegions.FirstOrDefault(r => r.Code == district.ParentCode);
                    if (city != null)
                    {
                        SelectedCityCode = city.Code;
                        // 加载该市的所有区
                        DistrictItems = AllRegions.Where(r => r.ParentCode == city.Code)
                                                  .Select(r => new SelectedItem(r.Code, r.Name)).ToList();

                        var province = AllRegions.FirstOrDefault(r => r.Code == city.ParentCode);
                        if (province != null)
                        {
                            SelectedProvinceCode = province.Code;
                            // 加载该省的所有市
                            CityItems = AllRegions.Where(r => r.ParentCode == province.Code)
                                                  .Select(r => new SelectedItem(r.Code, r.Name)).ToList();
                        }
                    }
                }
            }

            return Task.FromResult(true);
        }

        /// <summary>
        /// 根据实体的 RegionCode 反推省、市的选中状态，并加载对应的下拉列表
        /// </summary>
       

        // 级联事件：省份改变
        // 级联事件：省份改变
        private async Task OnProvinceChanged(SelectedItem item, DepartmentDto model)
        {
            // 获取值：item.Value
            var provinceCode = item.Value;

            SelectedProvinceCode = provinceCode;

            // 清空下级
            SelectedCityCode = "";
            model.RegionCode = ""; // 清空绑定的区县值

            // 加载市级数据
            if (!string.IsNullOrEmpty(provinceCode))
            {
                CityItems = AllRegions.Where(r => r.ParentCode == provinceCode)
                                      .Select(r => new SelectedItem(r.Code, r.Name))
                                      .ToList();
            }
            else
            {
                CityItems.Clear();
            }
            DistrictItems.Clear();

            // 强制刷新
            StateHasChanged();
            await Task.CompletedTask;
        }

        // 级联事件：城市改变
        private async Task OnCityChanged(SelectedItem item, DepartmentDto model)
        {
            var cityCode = item.Value;
            SelectedCityCode = cityCode;

            // 清空下级
            model.RegionCode = "";

            // 加载区县数据
            if (!string.IsNullOrEmpty(cityCode))
            {
                DistrictItems = AllRegions.Where(r => r.ParentCode == cityCode)
                                          .Select(r => new SelectedItem(r.Code, r.Name))
                                          .ToList();
            }
            else
            {
                DistrictItems.Clear();
            }

            StateHasChanged();
            await Task.CompletedTask;
        }

        // 级联事件：区县改变
        private Task OnDistrictChanged(SelectedItem item, DepartmentDto model)
        {
            // 将选中的区县 Code 赋值给实体
            model.RegionCode = item.Value;
            return Task.CompletedTask;
        }

        private async Task<bool> OnSaveAsync(DepartmentDto dto, ItemChangedType changedType)
        {
            if (string.IsNullOrEmpty(dto.RegionCode))
            {
                await Toast.Error("请选择所属区域");
                return false;
            }
            await DataService.SaveDepartmentAsync(dto);
            return true;
        }

        private async Task<bool> OnDeleteAsync(IEnumerable<DepartmentDto> items)
        {
            foreach (var item in items) await DataService.DeleteDepartmentAsync(item.Code);
            return true;
        }

        private async Task OnStatusChanged(DepartmentDto item, bool isEnabled)
        {
            await DataService.UpdateDepartmentStatusAsync(item.Code, !isEnabled);
            item.IsDeleted = !isEnabled;
            await Toast.Success("操作成功");
        }
    }
}