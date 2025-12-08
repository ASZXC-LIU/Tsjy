using System;
using System.Collections.Generic;
using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;
using Tsjy.Core.MyHelper;

namespace Tsjy.Core.Seed
{
    // 行政区划种子数据
    public class RegionSeed : IEntityTypeBuilder<Region>, IEntitySeedData<Region>
    {
        public void Configure(EntityTypeBuilder<Region> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.HasIndex(u => u.Code).IsUnique();
        }

        public IEnumerable<Region> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<Region>
            {
                new Region { Id = 1, Code = "130000", Name = "河北省", Level = RegionLevel.Province, CreatedAt = DateTime.UtcNow },
                new Region { Id = 2, Code = "130100", Name = "石家庄市", Level = RegionLevel.City, CreatedAt = DateTime.UtcNow },
                new Region { Id = 3, Code = "130102", Name = "长安区", Level = RegionLevel.District, CreatedAt = DateTime.UtcNow }
            };
        }
    }
    // 教育局种子数据
    public class EducationBureauSeed : IEntityTypeBuilder<EducationBureau>, IEntitySeedData<EducationBureau>
    {
        public void Configure(EntityTypeBuilder<EducationBureau> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
        }

        public IEnumerable<EducationBureau> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<EducationBureau>
            {
                new EducationBureau
                {
                    Id = 1, RegionId = 2, Level = "city", Code = "B130100", Name = "石家庄市教育局",
                    SpeSchoolsNum = 1, IncSchoolsNum = 10, Phone = 12345678, Address = "市局地址", CreatedAt = DateTime.UtcNow
                }
            };

        }
    }
    // 特殊教育学校种子数据
    public class SpecialSchoolSeed : IEntityTypeBuilder<SpecialSchool>, IEntitySeedData<SpecialSchool>
    {
        public void Configure(EntityTypeBuilder<SpecialSchool> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
        }

        public IEnumerable<SpecialSchool> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<SpecialSchool>
            {
                new SpecialSchool
                {
                    Id = 1, RegionId = 2, Code = "S1301001", Name = "石家庄市特殊教育学校",
                    Phone = 87654321, Address = "学校地址", Status = 1, CreatedAt = DateTime.UtcNow
                }
            };
        }
    }

    // 融合教育学校种子数据
    public class InclusiveSchoolSeed : IEntityTypeBuilder<InclusiveSchool>, IEntitySeedData<InclusiveSchool>
    {
        public void Configure(EntityTypeBuilder<InclusiveSchool> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
        }

        public IEnumerable<InclusiveSchool> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<InclusiveSchool>
            {
                new InclusiveSchool
                {
                    Id = 1, RegionId = 3, Code = "I1301021", Name = "石家庄市长安区第一小学(融合校)",
                    Phone = 66666666, Address = "长安区地址", CreatedAt = DateTime.UtcNow
                }
            };
        }
    }

}
