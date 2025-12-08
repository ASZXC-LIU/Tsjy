using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using Tsjy.Core.Entities;

namespace Tsjy.Core.Seed
{
    public class SysRoleSeed : IEntityTypeBuilder<SysRole>, IEntitySeedData<SysRole>
    {
        public void Configure(EntityTypeBuilder<SysRole> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(r => r.Id);
            entityBuilder.Property(r => r.Name).IsRequired().HasMaxLength(50);
            entityBuilder.Property(r => r.Code).HasMaxLength(20);
        }

        public IEnumerable<SysRole> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<SysRole>
            {
                new SysRole
                {
                    Id = 1,
                    Name = "管理员",
                    Code = "ADMIN",
                    Sort = 1,
                    remark = "系统超级管理员",
                    IsDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };
        }
    }
}
