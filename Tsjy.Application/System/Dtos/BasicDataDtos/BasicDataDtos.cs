using Tsjy.Core.Enums;
using System.ComponentModel;

namespace Tsjy.Application.System.Dtos.BasicDataDtos
{
    public class RegionDto
    {
        [DisplayName("行政代码")]
        public string Code { get; set; }

        [DisplayName("父级代码")]
        public string ParentCode { get; set; }

        [DisplayName("名称")]
        public string Name { get; set; }

        [DisplayName("级别")]
        public RegionLevel Level { get; set; }
        public bool IsDeleted { get; set; } = false;

        [DisplayName("日期")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }

    public class DepartmentDto
    {
        [DisplayName("机构代码")]
        public string Code { get; set; }

        [DisplayName("区域代码")]
        public string RegionCode { get; set; }

        [DisplayName("区域名称")]
        public string RegionName { get; set; } // 额外字段，用于显示

        [DisplayName("机构名称")]
        public string Name { get; set; }

        [DisplayName("机构类型")]
        public OrgType OrgType { get; set; }

        [DisplayName("联系电话")]
        public int Phone { get; set; }

        public bool IsDeleted { get; set; } = false;

        [DisplayName("日期")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}