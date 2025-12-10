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
                    case "SPECIAL":
                        Menus = GetUserSideMenuItems();
                        break;
                    default:
                        Menus = GetUserSideMenuItems();
                        break;
                }
            }
        }
        private static List<MenuItem> GetDataAdminSideMenuItems()
        {
            var menus = new List<MenuItem>
        {
        new MenuItem() { Text = "系统主页", Icon = "fa-solid fa-fw fa-flag", Url = "/index" , Match = NavLinkMatch.All},

        new MenuItem() { Text = "获取数据", Icon = "fa-solid fa-fw fa-user", Url = "/fetchdata" },

        new MenuItem() { Text = "用户列表", Icon = "fa-solid fa-fw fa-user", Url = "/UserList" },
        new MenuItem() { Text = "学校上传", Icon = "fa-solid fa-fw fa-user", Url = "/School/Assignment" },
         new MenuItem() { Text = "新建评价体系", Icon = "fa-solid fa-fw fa-user", Url = "/Admin/EvalSystemList" },
        new MenuItem() { Text = "新建评价体系", Icon = "fa-solid fa-fw fa-user", Url = "/Admin/EvalBuilder" },
        new MenuItem() { Text = "新建评分模板", Icon = "fa-solid fa-fw fa-user", Url = "/Admin/ScoringModels" },

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
            new MenuItem() { Text = "学校上传", Icon = "fa-solid fa-fw fa-user", Url = "/School/Assignment" };
            new MenuItem() { Text = "新建评价体系", Icon = "fa-solid fa-fw fa-user", Url = "/Admin/EvalBuilder" };

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
