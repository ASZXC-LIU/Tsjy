using System;
using System.Collections.Generic;
using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Core.Seed
{
    // 1. 行政区划 (北京全量 + 河北全量地级市)
    public class RegionSeed : IEntityTypeBuilder<Region>, IEntitySeedData<Region>
    {
        public void Configure(EntityTypeBuilder<Region> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Code);
            entityBuilder.Property(u => u.Name).HasMaxLength(100).IsRequired();
        }

        public IEnumerable<Region> HasData(DbContext dbContext, Type dbContextLocator)
        {
            var list = new List<Region>();

            // --- 北京市 (110000) ---
            list.Add(new Region { Code = "110000", Name = "北京市", Level = RegionLevel.Province, ParentCode = null });
            // 16个市辖区
            var bjDistricts = new[] {
                ("110101", "东城区"), ("110102", "西城区"), ("110105", "朝阳区"), ("110106", "丰台区"),
                ("110107", "石景山区"), ("110108", "海淀区"), ("110109", "门头沟区"), ("110111", "房山区"),
                ("110112", "通州区"), ("110113", "顺义区"), ("110114", "昌平区"), ("110115", "大兴区"),
                ("110116", "怀柔区"), ("110117", "平谷区"), ("110118", "密云区"), ("110119", "延庆区")
            };
            foreach (var d in bjDistricts) list.Add(new Region { Code = d.Item1, Name = d.Item2, Level = RegionLevel.District, ParentCode = "110000" });

            // --- 河北省 (130000) ---
            list.Add(new Region { Code = "130000", Name = "河北省", Level = RegionLevel.Province, ParentCode = null });
            // 11个地级市及其主城区示例
            var hbCities = new[] {
                ("130100", "石家庄市", "130102", "长安区"),
                ("130200", "唐山市", "130202", "路南区"),
                ("130300", "秦皇岛市", "130302", "海港区"),
                ("130400", "邯郸市", "130402", "邯山区"),
                ("130500", "邢台市", "130502", "襄都区"),
                ("130600", "保定市", "130606", "莲池区"),
                ("130700", "张家口市", "130702", "桥东区"),
                ("130800", "承德市", "130802", "双桥区"),
                ("130900", "沧州市", "130902", "新华区"),
                ("131000", "廊坊市", "131003", "广阳区"),
                ("131100", "衡水市", "131102", "桃城区")
            };

            foreach (var c in hbCities)
            {
                list.Add(new Region { Code = c.Item1, Name = c.Item2, Level = RegionLevel.City, ParentCode = "130000" });
                list.Add(new Region { Code = c.Item3, Name = c.Item4, Level = RegionLevel.District, ParentCode = c.Item1 });
            }

            return list;
        }
    }

    // 2. 机构/部门
    public class DepartmentsSeed : IEntityTypeBuilder<Departments>, IEntitySeedData<Departments>
    {
        public void Configure(EntityTypeBuilder<Departments> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Code);
            entityBuilder.Property(u => u.Name).IsRequired();
        }

        public IEnumerable<Departments> HasData(DbContext dbContext, Type dbContextLocator)
        {
            var list = new List<Departments>();

            // --- 教育局 (EducationBureau) ---
            list.Add(new Departments { Code = "110000_EDU", RegionCode = "110000", Name = "北京市教委", Level = RegionLevel.Province, OrgType = OrgType.EducationBureau, SpeSchoolsNum = 20, IncSchoolsNum = 1000 });
            list.Add(new Departments { Code = "110105_EDU", RegionCode = "110105", Name = "朝阳区教委", Level = RegionLevel.District, OrgType = OrgType.EducationBureau, SpeSchoolsNum = 3, IncSchoolsNum = 150 });
            list.Add(new Departments { Code = "110108_EDU", RegionCode = "110108", Name = "海淀区教委", Level = RegionLevel.District, OrgType = OrgType.EducationBureau, SpeSchoolsNum = 4, IncSchoolsNum = 180 });

            list.Add(new Departments { Code = "130000_EDU", RegionCode = "130000", Name = "河北省教育厅", Level = RegionLevel.Province, OrgType = OrgType.EducationBureau, SpeSchoolsNum = 150, IncSchoolsNum = 3000 });
            list.Add(new Departments { Code = "130100_EDU", RegionCode = "130100", Name = "石家庄市教育局", Level = RegionLevel.City, OrgType = OrgType.EducationBureau, SpeSchoolsNum = 12, IncSchoolsNum = 200 });
            list.Add(new Departments { Code = "130400_EDU", RegionCode = "130400", Name = "邯郸市教育局", Level = RegionLevel.City, OrgType = OrgType.EducationBureau, SpeSchoolsNum = 10, IncSchoolsNum = 180 });

            // --- 特教学校 (SpecialSchool) ---
            list.Add(new Departments { Code = "110105_SPE_01", RegionCode = "110105", Name = "北京市朝阳区安华学校", Level = RegionLevel.District, OrgType = OrgType.SpecialSchool });
            list.Add(new Departments { Code = "110108_SPE_01", RegionCode = "110108", Name = "北京市海淀区特殊教育学校", Level = RegionLevel.District, OrgType = OrgType.SpecialSchool });
            list.Add(new Departments { Code = "130100_SPE_01", RegionCode = "130100", Name = "石家庄市特殊教育学校", Level = RegionLevel.City, OrgType = OrgType.SpecialSchool });
            list.Add(new Departments { Code = "130102_SPE_01", RegionCode = "130102", Name = "石家庄市长安区启智学校", Level = RegionLevel.District, OrgType = OrgType.SpecialSchool });
            list.Add(new Departments { Code = "130400_SPE_01", RegionCode = "130400", Name = "邯郸市特殊教育中心", Level = RegionLevel.City, OrgType = OrgType.SpecialSchool });

            // --- 融合学校 (InclusiveSchool) ---
            list.Add(new Departments { Code = "110105_INC_01", RegionCode = "110105", Name = "朝阳区实验小学", Level = RegionLevel.District, OrgType = OrgType.InclusiveSchool });
            list.Add(new Departments { Code = "110108_INC_01", RegionCode = "110108", Name = "中关村第一小学", Level = RegionLevel.District, OrgType = OrgType.InclusiveSchool });
            list.Add(new Departments { Code = "130104_INC_01", RegionCode = "130104", Name = "石家庄草场街小学", Level = RegionLevel.District, OrgType = OrgType.InclusiveSchool });
            list.Add(new Departments { Code = "130402_INC_01", RegionCode = "130402", Name = "邯郸市邯山区实验小学", Level = RegionLevel.District, OrgType = OrgType.InclusiveSchool });

            // --- 其他 (Other) ---
            list.Add(new Departments { Code = "110000_OTH_01", RegionCode = "110000", Name = "北师大特教研究所", Level = RegionLevel.Province, OrgType = OrgType.Other });

            return list;
        }
    }
}