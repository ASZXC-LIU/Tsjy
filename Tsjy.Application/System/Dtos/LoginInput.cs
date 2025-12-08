using System.ComponentModel;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Dtos
{
    public class LoginInput
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        
        


        public UserRole? Role { get; set; }

    }
}
