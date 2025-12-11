using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Dtos
{
    public class SysUserDto
    {
   
        public string Account { get; set; } = string.Empty;
        public string IDNumber { get; set; }
        public string Password { get; set; } = string.Empty;
        public string RealName { get; set; } = string.Empty;
        
        public UserRole User_type { get; set; }
        public string OrgId { get; set; }
        public string OrgName { get; set; }
        


    }
}
