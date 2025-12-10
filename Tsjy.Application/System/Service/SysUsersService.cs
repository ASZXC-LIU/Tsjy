using System.Security.Claims;
using Furion.DatabaseAccessor;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;
using Tsjy.Core.MyHelper;

namespace Tsjy.Application.System.Service
{
    public class SysUsersService : ISysUsersService, IScoped, IDynamicApiController
    {
        private readonly IRepository<SysUsers> _usersRepo;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public SysUsersService(
            IRepository<SysUsers> usersRepo, 
            AuthenticationStateProvider authenticationStateProvider,
            IHttpContextAccessor httpContextAccessor)
        {
            _usersRepo = usersRepo as EFCoreRepository<SysUsers>;
        
            _authenticationStateProvider = authenticationStateProvider;
            _httpContextAccessor = httpContextAccessor;
        }




        

        public Task DeleteUsersAsync(IEnumerable<SysUserDto> users)
        {
            var items = users.Adapt<List<SysUser>>();
            return _usersRepo.DeleteNowAsync(items);
        }

        public async Task<List<SysUserDto>> GetAllUsersDtoAsync()
        {
            var users = await _usersRepo.AsQueryable(false).ToListAsync();

            return users.Adapt<List<SysUserDto>>();
        }

        public async Task InsertUserAsync(SysUserDto userDto)
        {
            var item = userDto.Adapt<SysUsers>();
            item.CreatedAt = DateTime.Now;
            item.UpdatedAt = DateTime.Now;
            item.Password = DataEncryption.SHA1Encrypt("123456");
            item.IsDeleted = false;
            item.Role = 0;
            var entry = await _usersRepo.InsertNowAsync(item);
            //entry.State = EntityState.Detached;

            // 基本可以确认一件事：BootstrapBlazor 在插入数据后会立即跟踪数据（在没有刷新或者重新查询的情况下），那么就会导致更新失败。
            // 所以在新增之后调用 Detach 取消 EFCore 上下文跟踪（这个代码理应无需配置，不知道 BootstrapBlazor 底层弄了什么）
            // 我想它每次都会调用一次 SaveChanges 和重新加载实体
            // 所以你在新增的操作之后取消跟踪实体即可解决问题

            // _userRepo.Detach(item);
            _usersRepo.Detach(entry);
        }


        public async Task UpdateUserAsync(SysUserDto userDto)
        {
            var item = userDto.Adapt<SysUsers>();
            item.UpdatedAt = DateTime.Now;

            await _usersRepo.UpdateNowAsync(item);
        }

        public async Task<AuthResult> LoginBlazorAsync(LoginInput loginInput)
        {
            loginInput.Password = DataEncryption.SHA1Encrypt(loginInput.Password.Trim());
            var user = await _usersRepo.FirstOrDefaultAsync(u => u.UserName == loginInput.UserName && u.Password == loginInput.Password && u.Role == loginInput.Role);
            if (user is null)
            {
                return new AuthResult().Failed("登录错误");
            }
            else
            {

                //登录成功，设置Identity,需要命名空间using System.Security.Claims;
                var identity = new ClaimsIdentity(
                new List<Claim>()
                {
                new Claim(ClaimTypes.Name, user.RealName, ClaimValueTypes.String),
                new Claim(ClaimTypes.Sid, user.IDNumber, ClaimValueTypes.String),
                new Claim(ClaimTypes.GivenName, user.UserName, ClaimValueTypes.String),
                new Claim(ClaimTypes.Role, user.Role.ToString(), ClaimValueTypes.String) }, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);
                (_authenticationStateProvider as ServerAuthenticationStateProvider).SetAuthenticationState(Task.FromResult(new AuthenticationState(principal)));

                var tokenDict = new Dictionary<string, object>
                {
                    { ClaimTypes.Name, user.RealName },
                    { ClaimTypes.Sid, user.IDNumber },
                    { ClaimTypes.GivenName, user.UserName },
                    { ClaimTypes.Role, user.Role.ToString() }
                };

                var token = JWTEncryption.Encrypt(tokenDict);

                var result = new AuthResult().Success();
                result.Token = token;
                result.userId = user.IDNumber;
                result.Role = user.Role.ToString();
                result.UserName = user.UserName;
                return result;
            }
        }
        public async Task<AuthResult> LoginHttpContextAsync(LoginInput loginInput)
        {
            loginInput.Password = DataEncryption.SHA1Encrypt(loginInput.Password.Trim());
            var user = await _usersRepo.FirstOrDefaultAsync(u => u.UserName == loginInput.UserName && u.Password == loginInput.Password && u.Role == loginInput.Role);
            if (user is null)
            {
                return new AuthResult().Failed("登录错误");
            }
            else
            {
                Log.Information("111111111"+ user.Role.ToString());
                //登录成功，设置Identity,需要命名空间using System.Security.Claims;
                var identity = new ClaimsIdentity(
                new List<Claim>()
                {
                new Claim(ClaimTypes.Sid, user.IDNumber, ClaimValueTypes.String),
                new Claim(ClaimTypes.GivenName, user.UserName, ClaimValueTypes.String),
                new Claim(ClaimTypes.Role, user.Role.ToString(), ClaimValueTypes.String) }, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);
               

                var context = _httpContextAccessor.HttpContext;

                if (context is not null)
                {
                    await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                }
                else
                {

                    return new AuthResult().Failed("HttpContext为空，无法登录");
                }

                var tokenDict = new Dictionary<string, object>
                {
                    { ClaimTypes.Sid, user.IDNumber },
                    { ClaimTypes.GivenName, user.UserName },
                    { ClaimTypes.Role, user.Role.ToString() }
                };

                var token = JWTEncryption.Encrypt(tokenDict);

                


                var result = new AuthResult().Success();
                result.Token = token;
                result.userId = user.IDNumber;
                result.Role = user.Role.ToString();
                result.UserName = user.UserName;
                return result;
            }
        }

        public async Task<bool> LogoutBlazorAsync()
        {
            // 重置认证状态
            (_authenticationStateProvider as ServerAuthenticationStateProvider)
               .SetAuthenticationState(Task.FromResult(new AuthenticationState(new ClaimsPrincipal())));

            //这里的Cookie应该如何处理？

            // 如果是前后端分离，可以在这里清除客户端存储的Token

            return await Task.FromResult(true);
        }





        public async Task<bool> LogoutHttpContextAsync()
        {
            var context = _httpContextAccessor.HttpContext;
            if (context is not null)
            {
                await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                // 清除Cookie示例
                context.Response.Cookies.Delete("BlazorWithApiEF");
                return true;
            }
            else
            {
                return false;
            }

        }


        //是否存在
        public async Task<bool> IsExistAsync(RegisterInput registerInput)
        {
            Console.WriteLine(registerInput);
            var user = await _usersRepo.FirstOrDefaultAsync(u => u.UserName == registerInput.UserName);
            
            if (user is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //注册
        public async Task<bool> RegisterAsync(RegisterInput registerInput)
        {
            Console.WriteLine(registerInput);
            Console.WriteLine(DataEncryption.SHA1Encrypt(registerInput.Password.Trim()));
            var user = new SysUsers
            {
                UserName = registerInput.UserName,
                Password = DataEncryption.SHA1Encrypt(registerInput.Password.Trim()),
                RealName = registerInput.RealName,
                Role = registerInput.Role,
            };
            await _usersRepo.InsertNowAsync(user);
            if (user is not null) {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
