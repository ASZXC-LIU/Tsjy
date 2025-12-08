using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Tsjy.Web.Entry.Pages
{
    public partial class Index
    {
        [Inject]
        [NotNull]
        public NavigationManager NavigationManager { get; set; }

        [CascadingParameter]
        [NotNull]
        public Task<AuthenticationState> authStateTask { get; set; }
        private AuthenticationState authState { get; set; }

        private string userName { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            StateHasChanged();
            if (authStateTask != null)
            {
                authState = await authStateTask;
                var user = authState.User;

                //未认证则跳转到登录页面
                if (user.Identity == null || !user.Identity.IsAuthenticated)
                {
                    NavigationManager.NavigateTo("/login", false);
                }
            }

        }
    }
}
