using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furion.DatabaseAccessor;
using Tsjy.Core.Enums;

namespace Tsjy.Core.Entities;

/// <summary>
/// 行政区划表
/// </summary>
[Table("regions")]
public class Region : IEntity
{
    [Key]
    [DisplayName("行政代码主键")]
    public string Code { get; set; }

    [DisplayName("父级代码")]
    public string ParentCode { get; set; }


    [DisplayName("名称")]
    [MaxLength(100)]
    public string Name { get; set; }

    [DisplayName("级别")]
    public RegionLevel Level { get; set; } // province, city, district

    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}

/// <summary>
/// 教育局
/// </summary>
[Table("departments")]
public class Departments : IEntity
{
    [Key]
    [DisplayName("机构代码主键")]
    public string Code { get; set; }


    [DisplayName("所在区域ID")]
    public string RegionCode { get; set; }

    [DisplayName("级别")]
    public RegionLevel Level { get; set; } // city, district

    [DisplayName("机构类型")]
    public OrgType OrgType { get; set; }

    [DisplayName("机构官方名称")]
    public string Name { get; set; }


    [DisplayName("特殊教育学校数量")]
    public long SpeSchoolsNum { get; set; }


    [DisplayName("融合教育学校数量")]
    public long IncSchoolsNum { get; set; }


    [DisplayName("学校联系电话")]
    public int Phone { get; set; }
    [DisplayName("学校地址")]
    public string Address { get; set; }
    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}