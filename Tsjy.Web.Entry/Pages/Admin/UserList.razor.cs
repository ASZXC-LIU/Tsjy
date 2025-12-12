using BootstrapBlazor.Components;
using Mapster; // 记得引用 Mapster
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Tsjy.Application.System.Dtos.SysusersDtos;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class UserList
    {
        [Inject] private SysUsersService UserService { get; set; }
        [Inject] private DepartmentsService DeptService { get; set; }
        [Inject] private ToastService Toast { get; set; }

        private Table<SysUserListDto> UserTable { get; set; }
        private Modal EditModal { get; set; }

        // 数据模型
        private SysUserListDto Model { get; set; } = new();
        private bool IsEditMode { get; set; } = false;

        // 筛选与下拉框数据源
        private UserRole? FilterRole { get; set; } = null; // 默认为空（查看所有）
        private List<SelectedItem> RoleItems { get; set; } = new();

        private bool ShowEditForm { get; set; } = false;
        protected override void OnInitialized()
        {
            // 初始化角色筛选（添加"全部"选项）
            RoleItems.Add(new SelectedItem("", "查看所有"));
            RoleItems.AddRange(typeof(UserRole).ToSelectList());

            // 初始化机构类型
        
        }

        // 表格数据查询
        private async Task<QueryData<SysUserListDto>> OnQueryAsync(QueryPageOptions options)
        {
            var data = await UserService.GetUserListAsync(FilterRole);

            // 前端内存搜索
            if (!string.IsNullOrEmpty(options.SearchText))
            {
                data = data.Where(x => x.UserName.Contains(options.SearchText) || x.RealName.Contains(options.SearchText)).ToList();
            }

            return new QueryData<SysUserListDto>
            {
                Items = data.Skip((options.PageIndex - 1) * options.PageItems).Take(options.PageItems),
                TotalCount = data.Count
            };
        }

        // 筛选变动
        private async Task OnFilterChanged(SelectedItem item)
        {
            if (string.IsNullOrEmpty(item.Value)) FilterRole = null;
            else FilterRole = Enum.Parse<UserRole>(item.Value);

            await UserTable.QueryAsync();
        }


        // 点击新增
        private void OnAddUser()
        {
            IsEditMode = false;
            Model = new SysUserListDto();
            ShowEditForm = true;
            EditModal.Show();
        }

        // 点击编辑
        private async Task OnEditUser(SysUserListDto item)
        {
            IsEditMode = true;
            Model = item.Adapt<SysUserListDto>();
            ShowEditForm = true;
            await EditModal.Show();
        }

        // 保存提交
        private async Task OnSaveUserSubmit(EditContext context)
        {
            await UserService.SaveUserAsync(Model);
            await Toast.Success("保存成功");
            await EditModal.Close();
            ShowEditForm = false;
            await UserTable.QueryAsync();
        }

        // 状态开关
        private async Task OnStatusChanged(SysUserListDto item, bool isEnabled)
        {
            await UserService.UpdateUserStatusAsync(item.IDNumber, !isEnabled); // isEnabled=true 代表 IsDeleted=false
            // 无需刷新表格，因为 Switch 已经改变了 UI 状态
        }
    }
}