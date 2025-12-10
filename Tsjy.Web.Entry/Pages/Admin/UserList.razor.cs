using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.SysusersDtos;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class UserList
    {
        [Inject] private SysUsersService UserService { get; set; }
        [Inject] private ToastService Toast { get; set; }

        private Table<SysUserListDto> UserTable { get; set; }
        private UserRole? FilterRole { get; set; } = null;
        private List<SelectedItem> RoleItems { get; set; } = new();

        protected override void OnInitialized()
        {
            // 初始化角色筛选下拉框
            RoleItems.Add(new SelectedItem("", "全部用户"));
            foreach (UserRole role in Enum.GetValues(typeof(UserRole)))
            {
                RoleItems.Add(new SelectedItem(role.ToString(), role.ToDescriptionString()));
            }
        }

        private async Task<QueryData<SysUserListDto>> OnQueryAsync(QueryPageOptions options)
        {
            var data = await UserService.GetUserListAsync(FilterRole);

            // 处理搜索
            if (!string.IsNullOrEmpty(options.SearchText))
            {
                data = data.Where(x => x.UserName.Contains(options.SearchText) || x.RealName.Contains(options.SearchText)).ToList();
            }

            // 内存分页
            var total = data.Count;
            var items = data.Skip((options.PageIndex - 1) * options.PageItems).Take(options.PageItems).ToList();

            return new QueryData<SysUserListDto> { Items = items, TotalCount = total };
        }

        private async Task OnFilterChanged(SelectedItem item)
        {
            if (string.IsNullOrEmpty(item.Value)) FilterRole = null;
            else FilterRole = Enum.Parse<UserRole>(item.Value);

            await UserTable.QueryAsync();
        }

        // 保存逻辑（新增/编辑）需要你需要完善 DTO 到 Entity 的映射
        private async Task<bool> OnSaveAsync(SysUserListDto dto, ItemChangedType changedType)
        {

            try
            {
                
                await UserService.SaveUserAsync(dto);

                await Toast.Success("保存成功");
                return true;
            }
            catch (Exception ex)
            {
                await Toast.Error("保存失败", ex.Message);
                return false;
            }
        }

        private async Task<bool> OnDeleteAsync(IEnumerable<SysUserListDto> items)
        {
            foreach (var item in items)
            {
                await UserService.DeleteUserAsync(item);
            }
            return true;
        }

        // 处理开关点击事件
        private async Task OnStatusChanged(SysUserListDto item, bool isEnabled)
        {
            // isEnabled = true (开关开启) -> IsDeleted 应该为 false
            // isEnabled = false (开关关闭) -> IsDeleted 应该为 true
            var targetDeleteStatus = !isEnabled;

            await UserService.UpdateUserStatusAsync(item.IDNumber, targetDeleteStatus);

            // 更新本地数据状态，避免刷新表格带来的闪烁（或者直接调用 QueryAsync 刷新也可以）
            item.IsDeleted = targetDeleteStatus;

            await Toast.Success("状态更新成功", $"用户 {item.RealName} 已{(isEnabled ? "启用" : "禁用")}");
        }
    }
}