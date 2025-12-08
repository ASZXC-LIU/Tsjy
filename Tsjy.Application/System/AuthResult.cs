using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsjy.Application.System
{
    public class AuthResult
    {
        public bool Succeeded { get; set; } = false;
        public string Error { get; set; } = "登录错误";

        public string Role { get; set; } = "null";

        public string UserName { get; set; } = "anonymous";

        public string userId { get; set; } = "null";

        public string Token { get; set; } = "null";

        public AuthResult Success() => new() { Succeeded = true };
        public AuthResult Failed(string error) => new() { Error = error };
    }
}
