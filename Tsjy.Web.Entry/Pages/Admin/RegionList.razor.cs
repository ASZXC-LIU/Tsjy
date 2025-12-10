using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.BasicDataDtos;
using Tsjy.Application.System.Service;

namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class RegionList
    {
        [Inject] private BasicDataService DataService { get; set; }
        [Inject] private ToastService Toast { get; set; }
        private async Task<QueryData<RegionDto>> OnQueryAsync(QueryPageOptions options)
        {
            var data = await DataService.GetRegionsAsync();

            if (!string.IsNullOrEmpty(options.SearchText))
            {
                data = data.Where(x => x.Name.Contains(options.SearchText) || x.Code.Contains(options.SearchText)).ToList();
            }

            return new QueryData<RegionDto>
            {
                Items = data.Skip((options.PageIndex - 1) * options.PageItems).Take(options.PageItems),
                TotalCount = data.Count
            };
        }

        private async Task<bool> OnSaveAsync(RegionDto dto, ItemChangedType changedType)
        {
            await DataService.SaveRegionAsync(dto);
            return true;
        }

        private async Task<bool> OnDeleteAsync(IEnumerable<RegionDto> items)
        {
            foreach (var item in items) await DataService.DeleteRegionAsync(item.Code);
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