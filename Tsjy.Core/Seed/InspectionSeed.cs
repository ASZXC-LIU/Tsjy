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
    public class InspectionTeamSeed : IEntityTypeBuilder<InspectionTeam>, IEntitySeedData<InspectionTeam>
    {
        public void Configure(EntityTypeBuilder<InspectionTeam> entityBuilder, DbContext dbContext, Type dbContextLocator) { entityBuilder.HasKey(u => u.Id); }

        public IEnumerable<InspectionTeam> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<InspectionTeam>
            {
                new InspectionTeam { Id = 1, BatchId = 1, Name = "第一视导组", CreatedAt = DateTime.UtcNow }
            };
        }
    }

    public class InspectionTeamMemberSeed : IEntityTypeBuilder<InspectionTeamMember>, IEntitySeedData<InspectionTeamMember>
    {
        public void Configure(EntityTypeBuilder<InspectionTeamMember> entityBuilder, DbContext dbContext, Type dbContextLocator) { entityBuilder.HasKey(u => u.Id); }

        public IEnumerable<InspectionTeamMember> HasData(DbContext dbContext, Type dbContextLocator)
        {
            // 假设存在 UserId 100
            return new List<InspectionTeamMember>
            {
                new InspectionTeamMember { Id = 1, TeamId = 1, UserId = 100, CreatedAt = DateTime.UtcNow }
            };
        }
    }

    public class InspectionScheduleSeed : IEntityTypeBuilder<InspectionSchedule>, IEntitySeedData<InspectionSchedule>
    {
        public void Configure(EntityTypeBuilder<InspectionSchedule> entityBuilder, DbContext dbContext, Type dbContextLocator) { entityBuilder.HasKey(u => u.Id); }

        public IEnumerable<InspectionSchedule> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<InspectionSchedule>
            {
                new InspectionSchedule { Id = 1, AssignmentId = 1, TeamId = 1, VisitStartAt = DateTime.UtcNow.AddDays(1), VisitEndAt = DateTime.UtcNow.AddDays(2), Status = InspectionScheduleStatus.Scheduled }
            };
        }
    }

    public class InspectionLogSeed : IEntityTypeBuilder<InspectionLog>, IEntitySeedData<InspectionLog>
    {
        public void Configure(EntityTypeBuilder<InspectionLog> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.EvidenceFiles).HasColumnType("json");
        }

        public IEnumerable<InspectionLog> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<InspectionLog>
            {
                new InspectionLog { Id = 1, ScheduleId = 1, NodeId = 3, Findings = "现场查看符合要求", EvidenceFiles = "[\"photo1.jpg\"]", CreatedBy = 100 }
            };
        }
    }
}
