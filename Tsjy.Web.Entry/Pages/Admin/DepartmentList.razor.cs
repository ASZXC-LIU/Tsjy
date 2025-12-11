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

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            // 移除了这里的 GetRegionsAsync 调用
        }

        private async Task<QueryData<DepartmentDto>> OnQueryAsync(QueryPageOptions options)
        {
            // 检查区域数据是否已加载，如果没有，先加载区域数据
            // 这确保了使用同一个 Context 时，先查完区域，再查部门，顺序执行
            if (AllRegions == null || AllRegions.Count == 0)
            {
                AllRegions = await DataService.GetRegionsAsync();

                // 初始化省份下拉框
                ProvinceItems = AllRegions.Where(r => r.Level == RegionLevel.Province)
                                          .Select(r => new SelectedItem(r.Code, r.Name))
                                          .ToList();
            }

            // 然后再加载表格数据
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

        private async Task<bool> OnSaveAsync(DepartmentDto dto, ItemChangedType changedType)
        {
            // 在保存前，如果需要，可以在这里做校验，确保 RegionCode 已设置
            if (string.IsNullOrEmpty(dto.RegionCode))
            {
                await Toast.Error("请选择所属区域");
                return false;
            }
            await DataService.SaveDepartmentAsync(dto);
            return true;
        }

        // 当点击“编辑”或“新建”按钮，Table 准备渲染 EditTemplate 时，会调用 OnSaveAsync 之前的数据绑定
        // 但 BootstrapBlazor 没有专门的 "OnStartEdit" 回调直接用于初始化非绑定字段。
        // 我们利用 EditTemplate 内部的 Select 组件绑定逻辑，或者每次 SelectedItem 变化时计算。
        // *更好的方式*：我们需要在模态框弹出时初始化省市的回显。
        // 目前简单的做法：由于无法直接通过 Table 钩子在编辑开始时设置 SelectedProvinceCode，
        // 我们可以在 OnQueryAsync 后不需要做，而是在级联组件渲染时尝试通过当前的 dto.RegionCode 反推。

        // 这是一个辅助方法，用于在编辑模式下，根据当前的 RegionCode 初始化下拉框选中状态
        // 这一步在 EditTemplate 第一次渲染时可能无法自动触发，因此我们在 OnProvinceChanged 等事件中处理交互。
        // 为了回显，我们可以利用 Select 组件的 OnBeforeRender 或者在 Select 绑定值时处理，但比较复杂。
        // 简单的方案：在 User 点击编辑时，Dto 是有值的。

        // 我们使用一个技巧：当 DistrictItems 为空 且 RegionCode 有值时，执行初始化
        private string _lastInitializedRegionCode;
        private void EnsureCascadingState(DepartmentDto model)
        {
            if (model.RegionCode == _lastInitializedRegionCode && DistrictItems.Count > 0) return;

            _lastInitializedRegionCode = model.RegionCode;
            if (string.IsNullOrEmpty(model.RegionCode))
            {
                // 新建模式，重置
                SelectedProvinceCode = "";
                SelectedCityCode = "";
                CityItems.Clear();
                DistrictItems.Clear();
                return;
            }

            // 如果已经有下拉数据且匹配，可能不需要重新计算，但为了安全每次都算一下所属的省市
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

        // 级联事件：省份改变
        private async Task OnProvinceChanged(string provinceCode)
        {
            SelectedProvinceCode = provinceCode;
            SelectedCityCode = "";

            // 加载市
            CityItems = AllRegions.Where(r => r.ParentCode == provinceCode)
                                  .Select(r => new SelectedItem(r.Code, r.Name))
                                  .ToList();
            DistrictItems.Clear(); // 清空区
            await Task.CompletedTask;
        }

        // 级联事件：城市改变
        private async Task OnCityChanged(string cityCode)
        {
            SelectedCityCode = cityCode;
            // 加载区
            DistrictItems = AllRegions.Where(r => r.ParentCode == cityCode)
                                      .Select(r => new SelectedItem(r.Code, r.Name))
                                      .ToList();
            await Task.CompletedTask;
        }

        // 级联事件：区县改变 -> 写入实体
        private Task OnDistrictChanged(string districtCode, DepartmentDto model)
        {
            model.RegionCode = districtCode;
            return Task.CompletedTask;
        }

        // 覆盖 Table 的 OnAddAsync 或 OnEditAsync 来做初始化太麻烦，
        // 我们改为在 Razor 页面中使用 OnParametersSet 或在 Select 渲染前调用 EnsureCascadingState。
        // 但 Select 在 EditTemplate 中。
        // *替代方案*：利用 TableColumn 的 EditTemplate 的 Context。
        // 我们在 Razor 中 Select 的 Value 绑定那里做一点“手脚”并不容易。
        // 最稳妥的方法是重写 Table 的 EditModal 里的 Content，但这里用了 Inline EditTemplate。
        // 
        // 鉴于 BootstrapBlazor 的生命周期，我们可以在 EditTemplate 内部放一个隐藏的组件或者代码块来触发初始化，
        // 或者简单点：在 OnQueryAsync 不处理。
        // 我们在 OnSaveAsync 不需要处理 UI 逻辑。

        // 实际修正：在 Razor 中，我在 EditTemplate 开头调用一个初始化方法即可。
        // 但 Razor 不允许直接写 void 调用。
        // 解决方法：使用一个自定义的小组件或者在 Select 的 OnParametersSet 逻辑。
        // 
        // 这里为了代码简洁，我在 EditTemplate 里加了一行逻辑：
        // @{ EnsureCascadingState(context); } 
        // 注意：这会导致每次渲染都计算，需加判断防止死循环（EnsureCascadingState 内部要判断是否已有数据）。


        private async Task<bool> OnDeleteAsync(IEnumerable<DepartmentDto> items)
        {
            foreach (var item in items) await DataService.DeleteDepartmentAsync(item.Code);
            return true;
        }

        // 补回缺失的状态切换方法
        private async Task OnStatusChanged(DepartmentDto item, bool isEnabled)
        {
            // 注意这里使用的是 UpdateDepartmentStatusAsync
            await DataService.UpdateDepartmentStatusAsync(item.Code, !isEnabled);
            item.IsDeleted = !isEnabled;
            await Toast.Success("操作成功");
        }
    }
}