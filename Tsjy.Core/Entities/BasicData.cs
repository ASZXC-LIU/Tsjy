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
    public long Id { get; set; }


    [DisplayName("行政代码")]
    public string Code { get; set; }

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
/// 特殊教育学校
/// </summary>
[Table("special_schools")]
public class SpecialSchool : IEntity
{
    [Key]
    public long Id { get; set; }

    [DisplayName("所属区域")]
    public long RegionId { get; set; }

    [DisplayName("标识码")]
    public string Code { get; set; }

    [DisplayName("学校官方名称")]
    [MaxLength(255)]
    public string Name { get; set; }

    public int Status { get; set; } = 1;
    [DisplayName("学校联系电话")]
    public int Phone { get; set; } = 1;
    [DisplayName("学校地址")]
    public string Address { get; set; }
    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}

/// <summary>
/// 融合教育学校
/// </summary>
[Table("inclusive_schools")]
public class InclusiveSchool : IEntity
{
    [Key]
    public long Id { get; set; }

    public long RegionId { get; set; }


    public string Code { get; set; }


    public string Name { get; set; }
    [DisplayName("学校联系电话")]
    public int Phone { get; set; } = 1;
    [DisplayName("学校地址")]
    public string Address { get; set; }
    public bool IsDeleted { get; set; } = false;

    [DisplayName("日期")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}

/// <summary>
/// 教育局
/// </summary>
[Table("education_bureaus")]
public class EducationBureau : IEntity
{
    [Key]
    public long Id { get; set; }

    public long RegionId { get; set; }

    [DisplayName("级别")]
    public string Level { get; set; } // city, district


    public string Code { get; set; }


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