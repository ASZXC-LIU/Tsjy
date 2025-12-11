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
        private List<SelectedItem> OrgTypeItems { get; set; } = new();
        private List<SelectedItem> OrgItems { get; set; } = new(); // 单位列表

        protected override void OnInitialized()
        {
            // 初始化角色筛选（添加"全部"选项）
            RoleItems.Add(new SelectedItem("", "查看所有"));
            RoleItems.AddRange(typeof(UserRole).ToSelectList());

            // 初始化机构类型
            OrgTypeItems = typeof(OrgType).ToSelectList().ToList();
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

        // --- 核心级联逻辑 ---
        private async Task OnOrgTypeChanged(OrgType type)
        {
            // 根据选中的类型，去后台查单位列表
            OrgItems = await DeptService.GetOrgSelectListAsync(type);

            // 如果不是在编辑初始加载阶段，切换类型时要清空已选的单位ID
            if (Model.OrgType != type)
            {
                Model.OrgId = "";
            }
        }

        // 点击新增
        private void OnAddUser()
        {
            IsEditMode = false;
            Model = new SysUserListDto();
            OrgItems.Clear(); // 新增时单位列表先清空，等用户选类型
            EditModal.Show();
        }

        // 点击编辑
        private async Task OnEditUser(SysUserListDto item)
        {
            IsEditMode = true;
            Model = item.Adapt<SysUserListDto>(); // 深拷贝

            // ★ 关键：回显处理 ★
            // 1. 根据这个用户当前的 OrgType，去后台加载对应的单位列表
            OrgItems = await DeptService.GetOrgSelectListAsync(Model.OrgType);

            // 2. 特殊处理：如果列表里没有当前用户的单位（比如被软删了），手动加上，保证下拉框能显示名字而不是Code
            if (!string.IsNullOrEmpty(Model.OrgId) && !OrgItems.Any(x => x.Value == Model.OrgId))
            {
                OrgItems.Add(new SelectedItem(Model.OrgId, Model.OrgName));
            }

            await EditModal.Show();
        }

        // 保存提交
        private async Task OnSaveUserSubmit(EditContext context)
        {
            await UserService.SaveUserAsync(Model);
            await Toast.Success("保存成功");
            await EditModal.Close();
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