using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.BasicDataDtos;
using Tsjy.Application.System.Service;

namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class DepartmentList
    {
        [Inject] private BasicDataService DataService { get; set; }
        [Inject] private ToastService Toast { get; set; }
        private async Task<QueryData<DepartmentDto>> OnQueryAsync(QueryPageOptions options)
        {
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
            await DataService.UpdateRegionStatusAsync(item.Code, !isEnabled);
            item.IsDeleted = !isEnabled;
            await Toast.Success("操作成功");
        }
    }
}