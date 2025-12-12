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
    public class SysUserSeed : IEntityTypeBuilder<SysUsers>, IEntitySeedData<SysUsers>
    {
        public void Configure(EntityTypeBuilder<SysUsers> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.IDNumber);
            entityBuilder.HasIndex(u => u.UserName).IsUnique();
            entityBuilder.Property(u => u.RealName).IsRequired().HasMaxLength(50);
            entityBuilder.Property(u => u.Password).IsRequired().HasMaxLength(100);
        }

        public IEnumerable<SysUsers> HasData(DbContext dbContext, Type dbContextLocator)
        {
            string pwd = DataEncryption.SHA1Encrypt("123456");
            return new List<SysUsers>
            {
                // 超级管理员
                new SysUsers { IDNumber = "110000198001010001", UserName = "admin", Password = pwd, RealName = "超级管理员", Phone = "13800000000", Role = UserRole.Admin, OrgType = OrgType.EducationBureau, OrgId = "110000_EDU" },

                // 区域管理员 (北京朝阳、石家庄)
                new SysUsers { IDNumber = "110105198501010001", UserName = "admin_cy", Password = pwd, RealName = "朝阳区管理员", Phone = "13800000001", Role = UserRole.Admin, OrgType = OrgType.EducationBureau, OrgId = "110105_EDU" },
                new SysUsers { IDNumber = "130100198502020001", UserName = "admin_sjz", Password = pwd, RealName = "石家庄管理员", Phone = "13800000002", Role = UserRole.Admin, OrgType = OrgType.EducationBureau, OrgId = "130100_EDU" },

                // 学校用户 (特教 - 朝阳安华、石家庄特教)
                new SysUsers { IDNumber = "110105199001010001", UserName = "sch_cy_spe", Password = pwd, RealName = "安华学校校长", Phone = "13900000001", Role = UserRole.SchoolUser, OrgType = OrgType.SpecialSchool, OrgId = "110105_SPE_01" },
                new SysUsers { IDNumber = "130100199002020001", UserName = "sch_sjz_spe", Password = pwd, RealName = "石特校长", Phone = "13900000002", Role = UserRole.SchoolUser, OrgType = OrgType.SpecialSchool, OrgId = "130100_SPE_01" },

                // 学校用户 (融合 - 中关村一小)
                new SysUsers { IDNumber = "110108199003030001", UserName = "sch_hd_inc", Password = pwd, RealName = "中关村校长", Phone = "13900000003", Role = UserRole.SchoolUser, OrgType = OrgType.InclusiveSchool, OrgId = "110108_INC_01" },

                // 专家
                new SysUsers { IDNumber = "110000197001010001", UserName = "expert_01", Password = pwd, RealName = "特教专家", Phone = "13600000001", Role = UserRole.Expert, OrgType = OrgType.Other, OrgId = "110000_OTH_01" }
            };
        }
    }
}