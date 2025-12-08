using System;
using System.Collections.Generic;
using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tsjy.Core.Entities;
using Tsjy.Core.MyHelper;

namespace Tsjy.Core.Seed
{
    public class SysUserSeed : IEntityTypeBuilder<SysUsers>, IEntitySeedData<SysUsers>
    {
        public void Configure(EntityTypeBuilder<SysUsers> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.HasIndex(u => u.UserName).IsUnique();
            entityBuilder.Property(u => u.RealName).IsRequired().HasMaxLength(50);
            entityBuilder.Property(u => u.Password).IsRequired().HasMaxLength(100);
        }

        public IEnumerable<SysUsers> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<SysUsers>
            {
                new SysUsers
                {
                    Id = 1,
                    UserName = "admin",
                    Password = DataEncryption.SHA1Encrypt("123456"), // 生产环境请加密或换更安全算法
                    RealName = "超级管理员",
                    Phone = "13800000000",
                    Role = Enums.UserRole.Admin,
                    OrgType = Enums.OrgType.EducationBureau,
                    OrgId = 1,
                    IsDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new SysUsers
                {
                    Id = 100,
                    UserName = "100",
                    Password = DataEncryption.SHA1Encrypt("123456"), // 生产环境请加密或换更安全算法
                    RealName = "超级管理员",
                    Phone = "13800000000",
                    Role = Enums.UserRole.Admin,
                    OrgType = Enums.OrgType.EducationBureau,
                    OrgId = 1,
                    IsDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
            };
        }
    }
}
