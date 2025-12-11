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

     

        private async Task<QueryData<DepartmentDto>> OnQueryAsync(QueryPageOptions options)
        {
            if (AllRegions == null || AllRegions.Count == 0)
            {
                AllRegions = await DataService.GetRegionsAsync();
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
            return Task.FromResult(true);
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