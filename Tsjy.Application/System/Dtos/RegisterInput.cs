using System.ComponentModel;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Dtos
{
    public class RegisterInput
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        
        


        public UserRole Role { get; set; }

        public bool IsDeleted { get; set; } = false;


        public string RealName { get; set; } = string.Empty;

        public string Phone { get; set; } = "string.Empty";

        public int OrgId { get; set; }

    }
}
