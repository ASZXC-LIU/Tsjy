using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.SysusersDtos;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.IService
{
    public interface ISysUsersService
    {
        Task<List<SysUserDto>> GetAllUsersDtoAsync();

        Task DeleteUsersAsync(IEnumerable<SysUserDto> users);

        Task InsertUserAsync(SysUserDto userDto);

        Task UpdateUserAsync(SysUserDto userDto);

        Task<AuthResult> LoginBlazorAsync(LoginInput loginInput);

        Task<AuthResult> LoginHttpContextAsync(LoginInput loginInput);

        Task<bool> IsExistAsync(RegisterInput registerInput);

        Task<bool> RegisterAsync(RegisterInput registerInput);
        Task<List<SysUserListDto>> GetUserListAsync(UserRole? roleFilter = null);
        Task DeleteUserAsync(SysUserListDto dto);
        Task SaveUserAsync(SysUserListDto dto);
        Task UpdateUserStatusAsync(string idNumber, bool isDeleted);
    }
}