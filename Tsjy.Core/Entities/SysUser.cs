using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furion.DatabaseAccessor;
namespace Tsjy.Core.Entities;


/// <summary>
/// 用户表
/// </summary>
[Table("sys_user")]
public class SysUser : IEntity
{
    [DisplayName("主键")]
    [Key]
    public int Id { get; set; }
    [DisplayName("账号")]
    public string Account { get; set; } = string.Empty;
    [DisplayName("密码")]
    [Required(ErrorMessage = "密码不能为空")]
    public string Password { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string Phone { get; set; } = "string.Empty";

    public string User_type { get; set; }
    public int OrgId { get; set; }

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}