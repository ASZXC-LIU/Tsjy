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
/// 角色表
/// </summary>
[Table("sys_role")]
public class SysRole : IEntity
{
    [DisplayName("主键")]
    [Key]
    public int Id { get; set; }
    [DisplayName("单位名称")]
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; }
    public int Sort { get; set; }
    public string remark { get; set; }
    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}