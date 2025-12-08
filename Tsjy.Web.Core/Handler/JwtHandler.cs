using System;
using System.Threading.Tasks;
using Furion;
using Furion.Authorization;
using Furion.DatabaseAccessor;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Tsjy.Web.Core.Handler
{
    public class JwtHandler : AppAuthorizeHandler
    {
        public override Task<bool> PipelineAsync(AuthorizationHandlerContext context, DefaultHttpContext httpContext)
        {
            // 这里写您的授权判断逻辑，授权通过返回 true，否则返回 false
            //var jwtRole = App.User.FindFirst("Role")?.Value;
            //if (jwtRole == null) return Task.FromResult(false);

            //var routeData = httpContext.GetRouteData();
            //var requestPoint = routeData?.Values["controller"]?.ToString();
            //Console.WriteLine(requestPoint);

            //if (string.IsNullOrEmpty(requestPoint)) return Task.FromResult(false);
            //using var scope = _serviceProvider.CreateScope();
            //var authRepo = scope.ServiceProvider.GetRequiredService<IRepository<AuthEntity>>().Where(a => a.Role == jwtRole).FirstOrDefault();
            //if (authRepo == null) return Task.FromResult(false);
            //var roleAuth = authRepo.Auth.Split(',').ToList();
            //if (!roleAuth.IsNullOrEmpty() && roleAuth.Contains(requestPoint)) { return Task.FromResult(true); }
            //return Task.FromResult(false);


            return Task.FromResult(true);

        }
    }
}
