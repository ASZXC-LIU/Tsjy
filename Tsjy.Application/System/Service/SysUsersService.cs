using System.Security.Claims;
using Furion.DatabaseAccessor;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.SysusersDtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;
using Tsjy.Core.MyHelper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Tsjy.Application.System.Service
{
    public class SysUsersService : ISysUsersService, IScoped, IDynamicApiController
    {
        private readonly IRepository<SysUsers> _usersRepo;
        private readonly IRepository<Departments> _orgRepo;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public SysUsersService(
            IRepository<SysUsers> usersRepo,
            IRepository<Departments> orgRepo,
            AuthenticationStateProvider authenticationStateProvider,
            IHttpContextAccessor httpContextAccessor)
        {
            _usersRepo = usersRepo as EFCoreRepository<SysUsers>;
        
            _authenticationStateProvider = authenticationStateProvider;
            _httpContextAccessor = httpContextAccessor;
            _orgRepo = orgRepo;
        }

        // 在 SysUsersService 类中添加以下方法

        public async Task SaveUserAsync(SysUserListDto dto)
        {
            // 判断是新增还是更新 (根据身份证号)
            //var existingUser = await _usersRepo.FirstOrDefaultAsync(x => x.IDNumber == dto.IDNumber);

            //if (existingUser != null)
            //{
            //    // --- 更新逻辑 ---
            //    // 使用 Mapster 将 DTO 的值覆盖到现有实体上
            //    dto.Adapt(existingUser);
            //    existingUser.UpdatedAt = DateTime.Now;
            //    if (!string.IsNullOrEmpty(dto.Password))
            //    {
            //        existingUser.Password = DataEncryption.SHA1Encrypt(dto.Password.Trim());
            //    }
            //    // 注意：SysUserListDto 通常不包含密码，所以这里不修改密码

            //    await _usersRepo.UpdateNowAsync(existingUser);
            //}
            //else
            //{
            //    // --- 新增逻辑 ---
            //    var newUser = dto.Adapt<SysUsers>();

            //    newUser.CreatedAt = DateTime.Now;
            //    newUser.UpdatedAt = DateTime.Now;
            //    // 设置默认密码 (例如 123456)
            //    if (!string.IsNullOrEmpty(dto.Password))
            //    {
            //        newUser.Password = DataEncryption.SHA1Encrypt(dto.Password.Trim());
            //    }
            //    else
            //    {
            //        // 设置默认密码 (例如 123456)
            //        newUser.Password = DataEncryption.SHA1Encrypt("123456");
            //    }
            //    newUser.IsDeleted = false;

            //    await _usersRepo.InsertNowAsync(newUser);
            //}
            var existingUser = await _usersRepo.FirstOrDefaultAsync(x => x.IDNumber == dto.IDNumber);

            if (existingUser != null)
            {
                // --- 更新逻辑 ---
                existingUser.RealName = dto.RealName;
                existingUser.Phone = dto.Phone;
                existingUser.Role = dto.Role;
                existingUser.OrgType = dto.OrgType;
                existingUser.OrgId = dto.OrgId; // 更新单位
                existingUser.UpdatedAt = DateTime.Now;

                // 只有当密码框不为空时，才更新密码
                if (!string.IsNullOrEmpty(dto.Password))
                {
                    existingUser.Password = DataEncryption.SHA1Encrypt(dto.Password.Trim());
                }

                await _usersRepo.UpdateNowAsync(existingUser);
            }
            else
            {
                // --- 新增逻辑 ---
                var newUser = dto.Adapt<SysUsers>();
                newUser.CreatedAt = DateTime.Now;
                newUser.UpdatedAt = DateTime.Now;
                newUser.IsDeleted = false;

                // 设置默认密码或指定密码
                string rawPwd = string.IsNullOrEmpty(dto.Password) ? "123456" : dto.Password.Trim();
                newUser.Password = DataEncryption.SHA1Encrypt(rawPwd);

                await _usersRepo.InsertNowAsync(newUser);
            }
        }
        // 在 SysUsersService 类中添加以下方法
        public async Task<List<SysUserListDto>> GetUserListAsync(UserRole? roleFilter = null)
        {
            //var query = _usersRepo.AsQueryable(false)
            //   .Where(x => !roleFilter.HasValue || x.Role == roleFilter.Value  ) // 如果有筛选条件则过滤

            //    .OrderByDescending(x => x.CreatedAt);

            //var list = await query.ToListAsync();
            //return list.Adapt<List<SysUserListDto>>();

            var query = from u in _usersRepo.AsQueryable()
                        join d in _orgRepo.AsQueryable() on u.OrgId equals d.Code into leftJoin // 左连接，防止没单位的用户查不出来
                        from org in leftJoin.DefaultIfEmpty()
                        //where !u.IsDeleted
                        select new SysUserListDto
                        {
                            IDNumber = u.IDNumber,
                            UserName = u.UserName,
                            RealName = u.RealName,
                            Role = u.Role,
                            Phone = u.Phone,
                            OrgId = u.OrgId,     // 绑定ID
                            OrgType = u.OrgType, // 绑定类型
                            OrgName = org != null ? org.Name : "未分配", // 显示名称
                            IsDeleted = u.IsDeleted,
                            CreatedAt = u.CreatedAt
                        };

            if (roleFilter.HasValue)
            {
                query = query.Where(x => x.Role == roleFilter.Value);
            }

            return await query.OrderByDescending(x => x.CreatedAt).ToListAsync();
        }

        public async Task DeleteUserAsync(SysUserListDto dto)
        {
            // 1. 先查找数据库中已存在的实体（如果上下文中已有，会直接返回该追踪对象，避免冲突）
            var user = await _usersRepo.FirstOrDefaultAsync(u => u.IDNumber == dto.IDNumber);

            // 2. 如果找到了，再进行修改
            if (user != null)
            {
                // 仅修改软删除标记和更新时间，不影响其他字段（如密码）
                user.IsDeleted = true;
                user.UpdatedAt = DateTime.Now;

                // 3. 更新实体
                // 因为 user 是从 Repo 获取的，它已经被追踪，UpdateNowAsync 会自动处理
                await _usersRepo.UpdateNowAsync(user);
            }
        }

        public async Task UpdateUserStatusAsync(string idNumber, bool isDeleted)
        {
            var user = await _usersRepo.FirstOrDefaultAsync(u => u.IDNumber == idNumber);
            if (user != null)
            {
                user.IsDeleted = isDeleted;
                user.UpdatedAt = DateTime.Now;
                await _usersRepo.UpdateNowAsync(user);
            }
        }

        public Task DeleteUsersAsync(IEnumerable<SysUserDto> users)
        {
            var items = users.Adapt<List<SysUsers>>();
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
            var user = await _usersRepo.FirstOrDefaultAsync(u => u.UserName == loginInput.UserName && u.Password == loginInput.Password && u.Role == loginInput.Role&& u.IsDeleted ==false);
            if (user is null)
            {
                return new AuthResult().Failed("登录错误");
            }
            else
            {
                Log.Information("用户登录: " + user.UserName);
                //登录成功，设置Identity,需要命名空间using System.Security.Claims;
                var claims = new List<Claim>()
        {
            new Claim(ClaimTypes.Sid, user.IDNumber ?? "", ClaimValueTypes.String),
            new Claim(ClaimTypes.Name, user.RealName ?? "", ClaimValueTypes.String),
            new Claim(ClaimTypes.GivenName, user.UserName ?? "", ClaimValueTypes.String),
            new Claim(ClaimTypes.Role, user.Role.ToString(), ClaimValueTypes.String),
            // ★★★ 关键修复：添加 OrgId claim ★★★
            new Claim("OrgId", user.OrgId ?? "", ClaimValueTypes.String)
        };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
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
            { ClaimTypes.Sid, user.IDNumber ?? "" },
            { ClaimTypes.Name, user.RealName ?? "" },
            { ClaimTypes.GivenName, user.UserName ?? "" },
            { ClaimTypes.Role, user.Role.ToString() },
            { "OrgId", user.OrgId ?? "" } // Token 也加上
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
        public async Task<List<SysUsers>> GetListAsync()
        {
            // 返回未删除的所有用户
            return await _usersRepo.Where(u => !u.IsDeleted).ToListAsync();
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
