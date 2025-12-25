using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Text.Json;
using BootstrapBlazor.Components;
using Furion.JsonSerialization;
using Furion.Logging;
using Furion.Shapeless;
using Furion.Shapeless.Extensions;
using Mapster;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.JSInterop;
using Tsjy.Application.System;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service;
using Tsjy.Core;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;
using Tsjy.Web.Core.ConstData;

namespace FurionBlazorServerEFAuth202502.Web.Entry.Pages
{
    public partial class Login
    {
        private string Title { get; set; } = "登录";

        public LoginInput loginInput { get; set; } = new LoginInput();

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        [Inject]
        [NotNull]
        private AjaxService AjaxService { get; set; }

        [Inject]
        [NotNull]
        public MessageService MessageService { get; set; }

        [Inject]
        [NotNull]
        public ISysUsersService SysUserService { get; set; }




        [Inject]
        IJSRuntime JS { get; set; }
        [Inject]
        [NotNull]
        public AuthenticationStateProvider authenticationStateProvider { get; set; }

        private AuthenticationState authState { get; set; }

        private ClaimsPrincipal principal { get; set; }
        // 2. 定义下拉框的数据源
        private IEnumerable<SelectedItem> UserRoles { get; set; }
        protected override async Task OnInitializedAsync()
        {
            var authState = await (authenticationStateProvider as ServerAuthenticationStateProvider).GetAuthenticationStateAsync();
            principal = authState.User;
            // 3. 将枚举转换为下拉框列表
            // BootstrapBlazor 会自动读取 [Description] 中的文本（如"系统管理员"）作为显示内容
            UserRoles = typeof(UserRole).ToSelectList();

        }

        private Task OnForgotPassword()
        {
            //忘记密码
            throw new NotImplementedException();
        }

        //跳转到注册页面

        private void OnRegister()
        {
            //跳转
            NavigationManager.NavigateTo("/Register", true);
        }
        private async Task DoLogin()
        {
            if (string.IsNullOrEmpty(loginInput.UserName))
            {
                await MessageService.Show(new MessageOption()
                {
                    Color = Color.Danger,
                    Content = "用户名不能为空"
                });
                return;
            }

            if (string.IsNullOrEmpty(loginInput.Password))
            {
                await MessageService.Show(new MessageOption()
                {
                    Color = Color.Danger,
                    Content = "密码不能为空"
                });
                return;
            }

            if (loginInput.Role == null)
            {
                await MessageService.Show(new MessageOption()
                {
                    Color = Color.Danger,
                    Content = "用户角色不能为空"
                });
                return;
            }



            var op = new AjaxOption()
            {
                Url = "/api/sys-users/login-http-context",
                Method = "POST",
                Data = loginInput
            };


            var resDoc = await AjaxService.InvokeAsync(op);

            StateHasChanged();

            JsonElement jsonEl = resDoc.RootElement;
            JsonElement jsonData = jsonEl.GetProperty("data");

            dynamic cla = Clay.Parse(jsonData);

            //转换为dynamic类型
            var rec = (AuthResult)cla.As<AuthResult>();

            if (rec.Succeeded)
            {
                Log.Information("登录成功，跳转到：/index");
                StateHasChanged();
                string targetUrl = "/index";
                switch (loginInput.Role)
                {
                    case UserRole.Admin:
                        targetUrl = "/Admin/EvalSystemList";
                        break;
                    case UserRole.SchoolUser:
                        // 对应受评单位
                        targetUrl = "/School/HistoryEvaluation";
                        break;
                    case UserRole.Expert:
                        // 对应专家
                        targetUrl = "/Review/Dashboard";
                        break;
                    default:
                        targetUrl = "/index";
                        break;
                }

                // 执行跳转 (forceLoad: true 确保强制刷新，清除旧缓存状态)
                NavigationManager.NavigateTo(targetUrl, true);
            }
            else
            {
                await MessageService.Show(new MessageOption()
                {
                    Color = Color.Danger,
                    Content = "登录失败："
                });


            }

        }



    }
}
