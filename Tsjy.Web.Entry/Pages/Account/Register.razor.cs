using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Text.Json;
using BootstrapBlazor.Components;
using Furion.JsonSerialization;
using Furion.Logging;
using Furion.Shapeless;
using Furion.Shapeless.Extensions;
using Mapster;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Tsjy.Application.System;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service;
using Tsjy.Core;
using Tsjy.Web.Core.ConstData;


namespace FurionBlazorServerEFAuth202502.Web.Entry.Pages
{
    public partial class Register
    {
        private string Title { get; set; } = "注册";

        public RegisterInput registerInput { get; set; } = new RegisterInput();

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
        [NotNull]
        public AuthenticationStateProvider authenticationStateProvider { get; set; }

        private AuthenticationState authState { get; set; }

        private ClaimsPrincipal principal { get; set; }

        private List<string> SysRolesName = new List<string>();
        private List<string> SysRolesCode = new List<string>();

        private List<SelectedItem> RoleSelectValues = new List<SelectedItem>();

        private string SelectRole { get; set; } = "未选择";

        
        protected override async Task OnInitializedAsync()
        {
            var authState = await (authenticationStateProvider as ServerAuthenticationStateProvider).GetAuthenticationStateAsync();
            principal = authState.User;

          

        }
      
        

        private async Task DoRegister()
        {
            if (string.IsNullOrEmpty(registerInput.UserName))
            {
                await MessageService.Show(new MessageOption()
                {
                    Color = Color.Danger,
                    Content = "用户名不能为空"
                });
                return;
            }

            if (string.IsNullOrEmpty(registerInput.Password))
            {
                await MessageService.Show(new MessageOption()
                {
                    Color = Color.Danger,
                    Content = "密码不能为空"
                });
                return;
            }
            

            var user = await SysUserService.IsExistAsync( registerInput);
            if (user == true)
            {
                await MessageService.Show(new MessageOption()
                {
                    Color = Color.Danger,
                    Content = "用户名已存在"
                });
            }
            else {
                var result = await SysUserService.RegisterAsync(registerInput);
                if (result == true) {
                    await MessageService.Show(new MessageOption()
                    {
                        Color = Color.Success,
                        Content = "注册成功"
                                                });
                    NavigationManager.NavigateTo("/login");
                }
                else {
                    await MessageService.Show(new MessageOption()
                    {
                        Color = Color.Danger,
                        Content = "注册失败"
                                                });
                }
            }
        


            //if (user.Succeeded)
            //{
            //    await MessageService.Show(new MessageOption()
            //    {
            //        Color = Color.Success,
            //        Content = "登录成功"
            //    });

            //    Log.Information("登录成功，跳转到：/");

            //    NavigationManager.NavigateTo("/index");

            //}
            //else
            //{
            //    await MessageService.Show(new MessageOption()
            //    {
            //        Color = Color.Danger,
            //        Content = "登录失败"

            //    });
            //}

           





        }

    }



}
