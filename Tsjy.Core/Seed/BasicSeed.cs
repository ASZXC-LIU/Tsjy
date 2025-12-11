using System;
using System.Collections.Generic;
using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Core.Seed
{
    // 行政区划种子数据
    public class RegionSeed : IEntityTypeBuilder<Region>, IEntitySeedData<Region>
    {
        public void Configure(EntityTypeBuilder<Region> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Code); // String Key
            entityBuilder.Property(u => u.Name).HasMaxLength(100).IsRequired();
        }

        public IEnumerable<Region> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<Region>
            {
                new Region { Code = "330000", Name = "浙江省", Level = RegionLevel.Province, ParentCode = null, CreatedAt = DateTime.UtcNow },
                new Region { Code = "330100", Name = "杭州市", Level = RegionLevel.City, ParentCode = "330000", CreatedAt = DateTime.UtcNow },
                new Region { Code = "330106", Name = "西湖区", Level = RegionLevel.District, ParentCode = "330100", CreatedAt = DateTime.UtcNow }
            };
        }
    }

    // 教育局/部门种子数据
    public class DepartmentsSeed : IEntityTypeBuilder<Departments>, IEntitySeedData<Departments>
    {
        public void Configure(EntityTypeBuilder<Departments> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Code); // String Key
            entityBuilder.Property(u => u.Name).IsRequired();
        }

        public IEnumerable<Departments> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<Departments>
            {
                // 市教育局
                new Departments
                {
                    Code = "330100_EDU",
                    RegionCode = "330100",
                    Name = "杭州市教育局",
                    Level = RegionLevel.City,
                    OrgType = OrgType.EducationBureau,
                    SpeSchoolsNum = 8,
                    IncSchoolsNum = 120,
                    Address = "杭州市某某路1号",
                    Phone = 88888888,
                    IsDeleted = false,
                    CreatedAt = DateTime.UtcNow
                },
                // 区教育局
                new Departments
                {
                    Code = "330106_EDU",
                    RegionCode = "330106",
                    Name = "西湖区教育局",
                    Level = RegionLevel.District,
                    OrgType = OrgType.EducationBureau,
                    SpeSchoolsNum = 2,
                    IncSchoolsNum = 45,
                    Address = "西湖区某某路2号",
                    Phone = 66666666,
                    IsDeleted = false,
                    CreatedAt = DateTime.UtcNow
                }
            };
        }
    }
}