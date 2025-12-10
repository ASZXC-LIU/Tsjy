using Tsjy.Core.Entities;
using Tsjy.Core.Enums;
using System.ComponentModel;

namespace Tsjy.Application.System.Dtos.SysusersDtos
{
    public class SysUserListDto
    {
        [DisplayName("身份证/ID")]
        public string IDNumber { get; set; }

        [DisplayName("账号")]
        public string UserName { get; set; }

        [DisplayName("真实姓名")]
        public string RealName { get; set; }

        [DisplayName("角色")]
        public UserRole Role { get; set; }

        [DisplayName("机构类型")]
        public OrgType OrgType { get; set; }

        [DisplayName("电话")]
        public string Phone { get; set; }
        [DisplayName("密码")]
        public string Password { get; set; }
        
        public bool IsDeleted { get; set; } = false;

        [DisplayName("日期")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}