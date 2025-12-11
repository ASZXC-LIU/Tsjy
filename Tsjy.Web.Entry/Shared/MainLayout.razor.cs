using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Threading.Tasks;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Server;
using Tsjy.Web.Entry.Pages;

namespace Tsjy.Web.Entry.Shared
{
    public partial class MainLayout
    {

        [Inject]
        private NavigationManager NavigationManager { get; set; }
        [Inject]
        [NotNull]
        public MessageService MessageService { get; set; }

        [CascadingParameter]
        [NotNull]
        public Task<AuthenticationState> authStateTask { get; set; }

        private AuthenticationState authState { get; set; }


        private bool UseTabSet { get; set; } = true;  //对分页位置有影响

        private string Theme { get; set; } = "";

        private bool IsOpen { get; set; }

        private bool IsFixedHeader { get; set; } = true;

        private bool IsFixedFooter { get; set; } = true;

        private bool IsFullSide { get; set; } = true;

        private bool ShowFooter { get; set; } = true;

        private List<MenuItem> Menus { get; set; }

        /// <summary>
        /// OnInitialized 方法
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            authState = await authStateTask;

            StateHasChanged();
            //未认证则返回，不加载菜单
            if (!authState.User.Identity.IsAuthenticated)
            {
                return;
            }
            else
            {
                var role = authState.User.Claims.FirstOrDefault(it => it.Type == ClaimTypes.Role)?.Value;
                //需要检查此处是否获取到了role
                switch (role)
                {
                    case "Admin":
                        Menus = GetDataAdminSideMenuItems();
                        break;
                    case "SchoolUser":
                        Menus = GetUserSideMenuItems();
                        break;
                    default:
                        Menus = GetSysAdminSideMenuItems();
                        break;
                }
            }
        }
        private static List<MenuItem> GetDataAdminSideMenuItems()
        {
            var evalMenu = new MenuItem()
            {
                Text = "评价管理",
                Icon = "fa-solid fa-fw fa-folder-open" // 找一个合适的图标
            };

            var baseMenu = new MenuItem()
            {
                Text = "基础信息管理",
                Icon = "fa-solid fa-fw fa-folder-open" // 找一个合适的图标
            };
            var taskMenu = new MenuItem()
            {
                Text = "任务分发",
                Icon = "fa-solid fa-fw fa-folder-open" // 找一个合适的图标
            };
            // 2. 将子菜单放入父菜单的 Items 列表中
            evalMenu.Items = new List<MenuItem>
    {
        new MenuItem() { Text = "评价体系列表", Icon = "fa-solid fa-fw fa-list-check", Url = "/Admin/EvalSystemList" },
        // 注意：EvalBuilder 通常需要参数(如 /Admin/EvalBuilder/school/1)，直接放菜单可能报错或需要处理默认路由
        new MenuItem() { Text = "新建评价体系", Icon = "fa-solid fa-fw fa-pen-ruler", Url = "/Admin/EvalBuilder" },
        new MenuItem() { Text = "评分模板管理", Icon = "fa-solid fa-fw fa-table", Url = "/Admin/ScoringModels" }
    };

            baseMenu.Items = new List<MenuItem>
    {
        new MenuItem() { Text = "单位管理列表", Icon = "fa-solid fa-fw fa-list-check", Url = "/Admin/DepartmentList" },
        // 注意：EvalBuilder 通常需要参数(如 /Admin/EvalBuilder/school/1)，直接放菜单可能报错或需要处理默认路由
        new MenuItem() { Text = "区域管理列表", Icon = "fa-solid fa-fw fa-pen-ruler", Url = "/Admin/RegionList" },
        new MenuItem() { Text = "用户管理列表", Icon = "fa-solid fa-fw fa-table", Url = "/Admin/UserList" }
    };
            taskMenu.Items = new List<MenuItem>
    {
        new MenuItem() { Text = "单位管理列表", Icon = "fa-solid fa-fw fa-list-check", Url = "/Admin/TaskDistribute" }
    };

            // 3. 组装最终的菜单列表
            var menus = new List<MenuItem>
    {
        new MenuItem() { Text = "系统主页", Icon = "fa-solid fa-fw fa-flag", Url = "/index" , Match = NavLinkMatch.All},
        
        // 将刚才定义的父级菜单加入主列表
        evalMenu,
        baseMenu,
        taskMenu,
        //new MenuItem() { Text = "学校上传", Icon = "fa-solid fa-fw fa-cloud-upload", Url = "/School/Assignment" },
        //new MenuItem() { Text = "用户列表", Icon = "fa-solid fa-fw fa-users", Url = "/UserList" },
        //new MenuItem() { Text = "获取数据", Icon = "fa-solid fa-fw fa-database", Url = "/fetchdata" },
    };

            return menus;
        }

        private static List<MenuItem> GetSysAdminSideMenuItems()
        {
            var menus = new List<MenuItem>
        {
        new MenuItem() { Text = "系统主页", Icon = "fa-solid fa-fw fa-flag", Url = "/index" , Match = NavLinkMatch.All},
        new MenuItem() { Text = "创建试题", Icon = "fa-solid fa-fw fa-user", Url = "/counter" },
    };

            return menus;
        }
        private static List<MenuItem> GetUserSideMenuItems()
        {
            var menu1 = new MenuItem() { Text = "系统主页", Icon = "fa-solid fa-fw fa-flag", Url = "/index", Match = NavLinkMatch.All };
           
            new MenuItem() { Text = "我的任务", Icon = "fa-solid fa-fw fa-user", Url = "/School/MyTasks" };

            var menu5 = new MenuItem() { Text = "计数器", Icon = "fa-solid fa-fw fa-table", Url = "/counter" };


            ;
            menu5.Parent = menu1;

            var menus = new List<MenuItem>
        {
            menu1
        };
            return menus;
        }

    }

}
