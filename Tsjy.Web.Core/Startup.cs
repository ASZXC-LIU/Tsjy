using System;
using System.Security.Claims;
using Furion;
using Furion.Logging;
using Furion.VirtualFileServer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tsjy.Web.Core.DataService;
using Tsjy.Web.Core.Handler;

namespace Tsjy.Web.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddConsoleFormatter();


            //在AddControllers之前增加认证授权部分,自定义授权机制
            services.AddJwt<JwtHandler>(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
                {
                    options.Cookie.Name = "BlazorWithApiEF";
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                    options.SlidingExpiration = false;
                    options.LoginPath = "/login";
                });

            //添加
            services.AddAuthorizationCore(options =>
            {
                Log.Information(ClaimTypes.Role);
                options.AddPolicy("SPECIAL", policy => policy.RequireClaim(ClaimTypes.Role, "SPECIAL"));
                options.AddPolicy("Admin", policy => policy.RequireClaim(ClaimTypes.Role, "Admin"));
            });

            services.AddControllers().AddInjectWithUnifyResult();

            //services.AddControllers();


            services.AddRazorPages();
            services.AddServerSideBlazor();

            // 添加本行代码
            services.AddBootstrapBlazor(null, options =>
            {
                // 忽略文化信息丢失日志
                options.IgnoreLocalizerMissing = true;
            });

            //添加DataService扩展
            services.AddEFCoreDataAccessServices();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //添加认证授权中间件
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseInject();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
