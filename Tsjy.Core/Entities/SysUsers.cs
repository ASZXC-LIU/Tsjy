using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furion.DatabaseAccessor;
using Tsjy.Core.Enums;
namespace Tsjy.Core.Entities;


/// <summary>
/// 用户表
/// </summary>
[Table("sys_users")]
public class SysUsers : IEntity
{
    [Key]
    [DisplayName("身份证号（主键）")]
    public string IDNumber { get; set; }
    [DisplayName("账号")]
    public string UserName { get; set; } = string.Empty;
    [DisplayName("密码")]
    [Required(ErrorMessage = "密码不能为空")]
    public string Password { get; set; } = string.Empty;

    public string RealName { get; set; } = string.Empty;



    public UserRole Role { get; set; }
    public OrgType OrgType { get; set; }
    public string OrgId { get; set; }

    public string Phone { get; set; } = string.Empty;
 
    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}