using Furion;
using Furion.DatabaseAccessor;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.Extensions.DependencyInjection;
using MySql.EntityFrameworkCore.Extensions;

namespace Tsjy.EntityFramework.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDatabaseAccessor(options =>
            {

                options.AddDbPool<DefaultDbContext>();

               

            }, "Tsjy.Database.Migrations");

            //测试在此注入认证状态服务，应该也是可以的，这样在Blazor端就可以使用AuthenticationStateProvider了
            //考虑在Furion.Application层更好，再比较Furion.Web.Core只能在Web.Entry中修改登录状态

            //这个在Furion.Application层中增加Startup.cs，实现注入，通过Service登录后直接修改登录状态
            //也可以在Furion.Web.Entry中注册，前端登录后修改登录状态
            services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();

            //注册服务IdbContextFactory
            services.AddDbContextFactory<DefaultDbContext>();
        }
    }
}
