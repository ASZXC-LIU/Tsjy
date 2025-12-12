using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tsjy.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v500 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ai_pre_evaluations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    TaskId = table.Column<long>(type: "bigint", nullable: false),
                    NodeId = table.Column<long>(type: "bigint", nullable: false),
                    EvidenceId = table.Column<long>(type: "bigint", nullable: false),
                    SuggestedScore = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RiskLevel = table.Column<string>(type: "longtext", nullable: true),
                    AnalysisReport = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ai_pre_evaluations", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "batch_targets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BatchId = table.Column<long>(type: "bigint", nullable: false),
                    OrgId = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_batch_targets", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Code = table.Column<string>(type: "varchar(255)", nullable: false),
                    RegionCode = table.Column<string>(type: "longtext", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    OrgType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    SpeSchoolsNum = table.Column<long>(type: "bigint", nullable: false),
                    IncSchoolsNum = table.Column<long>(type: "bigint", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Code);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "distribution_batches",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TreeId = table.Column<long>(type: "bigint", nullable: false),
                    TargetType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DueAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_distribution_batches", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "edu_eval_nodes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TreeId = table.Column<long>(type: "bigint", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    Path = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    MaxScore = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ScoringTemplateId = table.Column<long>(type: "bigint", nullable: true),
                    OrderIndex = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edu_eval_nodes", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "expert_reviews",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TaskId = table.Column<long>(type: "bigint", nullable: false),
                    NodeId = table.Column<long>(type: "bigint", nullable: false),
                    ReviewerId = table.Column<long>(type: "bigint", nullable: false),
                    ScoreRatio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StandardScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FinalScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_expert_reviews", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inc_eval_nodes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TreeId = table.Column<long>(type: "bigint", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    Path = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    MaxScore = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ScoringTemplateId = table.Column<long>(type: "bigint", nullable: true),
                    OrderIndex = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inc_eval_nodes", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inspection_logs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ScheduleId = table.Column<long>(type: "bigint", nullable: false),
                    NodeId = table.Column<long>(type: "bigint", nullable: false),
                    Findings = table.Column<string>(type: "longtext", nullable: true),
                    EvidenceFiles = table.Column<string>(type: "json", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inspection_logs", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inspection_schedules",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AssignmentId = table.Column<long>(type: "bigint", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    VisitStartAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    VisitEndAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inspection_schedules", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inspection_team_members",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inspection_team_members", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inspection_teams",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BatchId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inspection_teams", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "regions",
                columns: table => new
                {
                    Code = table.Column<string>(type: "varchar(255)", nullable: false),
                    ParentCode = table.Column<string>(type: "longtext", nullable: true),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regions", x => x.Code);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "review_allocations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TaskId = table.Column<long>(type: "bigint", nullable: false),
                    NodeId = table.Column<long>(type: "bigint", nullable: false),
                    ExpertId = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AssignedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_review_allocations", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "scoring_templates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scoring_templates", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "spe_eval_nodes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TreeId = table.Column<long>(type: "bigint", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    Path = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    MaxScore = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ScoringTemplateId = table.Column<long>(type: "bigint", nullable: true),
                    OrderIndex = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spe_eval_nodes", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Code = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: false),
                    remark = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_role", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Account = table.Column<string>(type: "longtext", nullable: true),
                    Password = table.Column<string>(type: "longtext", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    Phone = table.Column<string>(type: "longtext", nullable: true),
                    User_type = table.Column<string>(type: "longtext", nullable: true),
                    OrgId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_user", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_users",
                columns: table => new
                {
                    IDNumber = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(255)", nullable: true),
                    Password = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    RealName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    OrgType = table.Column<int>(type: "int", nullable: false),
                    OrgId = table.Column<string>(type: "longtext", nullable: true),
                    Phone = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_users", x => x.IDNumber);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "task_evidences",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TaskId = table.Column<long>(type: "bigint", nullable: false),
                    NodeId = table.Column<long>(type: "bigint", nullable: false),
                    Content = table.Column<string>(type: "longtext", nullable: true),
                    FileUrls = table.Column<string>(type: "json", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RejectReason = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_task_evidences", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tasks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BatchId = table.Column<long>(type: "bigint", nullable: false),
                    TreeId = table.Column<long>(type: "bigint", nullable: false),
                    TargetType = table.Column<int>(type: "int", nullable: false),
                    TargetId = table.Column<string>(type: "longtext", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SubmittedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FinalScore = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tasks", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "scoring_template_items",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TemplateId = table.Column<long>(type: "bigint", nullable: false),
                    LevelCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Ratio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ScoringModelId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scoring_template_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_scoring_template_items_scoring_templates_ScoringModelId",
                        column: x => x.ScoringModelId,
                        principalTable: "scoring_templates",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "ai_pre_evaluations",
                columns: new[] { "Id", "AnalysisReport", "CreatedAt", "EvidenceId", "IsDeleted", "NodeId", "RiskLevel", "SuggestedScore", "TaskId", "UpdatedAt", "UserId" },
                values: new object[] { 1L, "AI分析通过", new DateTime(2025, 12, 12, 9, 31, 48, 935, DateTimeKind.Utc).AddTicks(9435), 1L, false, 3L, "low", 4.5m, 1L, new DateTime(2025, 12, 12, 9, 31, 48, 935, DateTimeKind.Utc).AddTicks(9437), 1L });

            migrationBuilder.InsertData(
                table: "batch_targets",
                columns: new[] { "Id", "BatchId", "CreatedAt", "IsDeleted", "OrgId", "UpdatedAt" },
                values: new object[,]
                {
                    { 20000L, 10000L, new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(7688), false, "110105_SPE_01", new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(7689) },
                    { 20001L, 10000L, new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8043), false, "110108_SPE_01", new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8044) },
                    { 20002L, 10000L, new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8045), false, "130100_SPE_01", new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8045) },
                    { 20003L, 10001L, new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8046), false, "110108_INC_01", new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8047) },
                    { 20004L, 10001L, new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8048), false, "130104_INC_01", new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8048) },
                    { 20005L, 10002L, new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8050), false, "110105_EDU", new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8050) },
                    { 20006L, 10002L, new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8051), false, "130100_EDU", new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8052) },
                    { 20007L, 10003L, new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8052), false, "130400_SPE_01", new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8053) }
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Code", "Address", "CreatedAt", "IncSchoolsNum", "IsDeleted", "Level", "Name", "OrgType", "Phone", "RegionCode", "SpeSchoolsNum", "UpdatedAt" },
                values: new object[,]
                {
                    { "110000_EDU", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2319), 1000L, false, 0, "北京市教委", 2, 0, "110000", 20L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2323) },
                    { "110000_OTH_01", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3015), 0L, false, 0, "北师大特教研究所", 3, 0, "110000", 0L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3015) },
                    { "110105_EDU", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2993), 150L, false, 2, "朝阳区教委", 2, 0, "110105", 3L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2994) },
                    { "110105_INC_01", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3010), 0L, false, 2, "朝阳区实验小学", 1, 0, "110105", 0L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3011) },
                    { "110105_SPE_01", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3003), 0L, false, 2, "北京市朝阳区安华学校", 0, 0, "110105", 0L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3003) },
                    { "110108_EDU", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2996), 180L, false, 2, "海淀区教委", 2, 0, "110108", 4L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2996) },
                    { "110108_INC_01", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3011), 0L, false, 2, "中关村第一小学", 1, 0, "110108", 0L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3012) },
                    { "110108_SPE_01", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3004), 0L, false, 2, "北京市海淀区特殊教育学校", 0, 0, "110108", 0L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3005) },
                    { "130000_EDU", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2997), 3000L, false, 0, "河北省教育厅", 2, 0, "130000", 150L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2998) },
                    { "130100_EDU", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2999), 200L, false, 1, "石家庄市教育局", 2, 0, "130100", 12L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2999) },
                    { "130100_SPE_01", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3006), 0L, false, 1, "石家庄市特殊教育学校", 0, 0, "130100", 0L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3006) },
                    { "130102_SPE_01", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3008), 0L, false, 2, "石家庄市长安区启智学校", 0, 0, "130102", 0L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3008) },
                    { "130104_INC_01", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3013), 0L, false, 2, "石家庄草场街小学", 1, 0, "130104", 0L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3013) },
                    { "130400_EDU", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3002), 180L, false, 1, "邯郸市教育局", 2, 0, "130400", 10L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3002) },
                    { "130400_SPE_01", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3009), 0L, false, 1, "邯郸市特殊教育中心", 0, 0, "130400", 0L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3009) },
                    { "130402_INC_01", null, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3014), 0L, false, 2, "邯郸市邯山区实验小学", 1, 0, "130402", 0L, new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3014) }
                });

            migrationBuilder.InsertData(
                table: "distribution_batches",
                columns: new[] { "Id", "CreatedAt", "DueAt", "IsDeleted", "Name", "StartAt", "Status", "TargetType", "TreeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 10000L, new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(6469), new DateTime(2026, 1, 1, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(6993), false, "2025年特教学校春季普查", new DateTime(2025, 12, 2, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(6903), 1, 0, 202501L, new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(6470) },
                    { 10001L, new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7076), new DateTime(2026, 1, 16, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7078), false, "海淀区随班就读质量监测", new DateTime(2025, 12, 17, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7078), 0, 0, 202502L, new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7077) },
                    { 10002L, new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7079), new DateTime(2025, 12, 27, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7081), false, "2025区域特教发展绩效评价", new DateTime(2025, 12, 10, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7081), 1, 0, 202503L, new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7080) },
                    { 10003L, new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7082), new DateTime(2025, 1, 11, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7120), false, "2024年终考核存档", new DateTime(2024, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7083), 2, 0, 202401L, new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7083) }
                });

            migrationBuilder.InsertData(
                table: "edu_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 30000L, null, new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(1312), 0, false, 100m, "2025区域特教发展评价", 0, null, "0", null, 202503L, 0, new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(1313) },
                    { 30001L, "1", new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2138), 1, false, 60m, "经费保障", 0, 30000L, "0,30000", null, 202503L, 1, new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2139) },
                    { 30002L, "1.1", new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2235), 2, false, 60m, "生均公用经费标准", 0, 30001L, "0,30000,30001", 1L, 202503L, 4, new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2235) },
                    { 30003L, "2", new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2323), 1, false, 40m, "入学率", 0, 30000L, "0,30000", null, 202503L, 1, new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2323) },
                    { 30004L, "2.1", new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2327), 2, false, 40m, "义务教育入学率", 0, 30003L, "0,30000,30003", 1L, 202503L, 4, new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2327) }
                });

            migrationBuilder.InsertData(
                table: "expert_reviews",
                columns: new[] { "Id", "CreatedAt", "FinalScore", "IsDeleted", "NodeId", "ReviewerId", "ScoreRatio", "StandardScore", "TaskId", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2025, 12, 12, 9, 31, 48, 938, DateTimeKind.Utc).AddTicks(9994), 4.0m, false, 3L, 100L, 0.8m, 5m, 1L, new DateTime(2025, 12, 12, 9, 31, 48, 938, DateTimeKind.Utc).AddTicks(9258) });

            migrationBuilder.InsertData(
                table: "inc_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 20000L, null, new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(5449), 0, false, 100m, "2025随班就读质量监测", 0, null, "0", null, 202502L, 0, new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(5450) },
                    { 20001L, "1", new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6305), 1, false, 50m, "资源教室", 0, 20000L, "0,20000", null, 202502L, 1, new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6305) },
                    { 20002L, "1.1", new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6409), 2, false, 25m, "资源教师配备", 0, 20001L, "0,20000,20001", 2L, 202502L, 4, new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6409) },
                    { 20003L, "1.2", new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6497), 2, false, 25m, "设备使用率", 0, 20001L, "0,20000,20001", 1L, 202502L, 4, new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6497) },
                    { 20004L, "2", new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6502), 1, false, 50m, "融合文化", 0, 20000L, "0,20000", null, 202502L, 1, new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6503) },
                    { 20005L, "2.1", new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6507), 2, false, 50m, "普特融合活动", 0, 20004L, "0,20000,20004", 1L, 202502L, 4, new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6507) }
                });

            migrationBuilder.InsertData(
                table: "inspection_logs",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EvidenceFiles", "Findings", "IsDeleted", "NodeId", "ScheduleId", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2025, 12, 12, 9, 31, 48, 944, DateTimeKind.Utc).AddTicks(7632), 100L, "[\"photo1.jpg\"]", "现场查看符合要求", false, 3L, 1L, new DateTime(2025, 12, 12, 9, 31, 48, 944, DateTimeKind.Utc).AddTicks(7633) });

            migrationBuilder.InsertData(
                table: "inspection_schedules",
                columns: new[] { "Id", "AssignmentId", "CreatedAt", "IsDeleted", "Status", "TeamId", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { 1L, 1L, new DateTime(2025, 12, 12, 9, 31, 48, 943, DateTimeKind.Utc).AddTicks(4112), false, 0, 1L, new DateTime(2025, 12, 12, 9, 31, 48, 943, DateTimeKind.Utc).AddTicks(4113), new DateTime(2025, 12, 14, 9, 31, 48, 943, DateTimeKind.Utc).AddTicks(4589), new DateTime(2025, 12, 13, 9, 31, 48, 943, DateTimeKind.Utc).AddTicks(4416) });

            migrationBuilder.InsertData(
                table: "inspection_team_members",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "TeamId", "UpdatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2025, 12, 12, 9, 31, 48, 941, DateTimeKind.Utc).AddTicks(2852), false, 1L, new DateTime(2025, 12, 12, 9, 31, 48, 941, DateTimeKind.Utc).AddTicks(2430), 100L });

            migrationBuilder.InsertData(
                table: "inspection_teams",
                columns: new[] { "Id", "BatchId", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { 1L, 1L, new DateTime(2025, 12, 12, 9, 31, 48, 939, DateTimeKind.Utc).AddTicks(9084), false, "第一视导组", new DateTime(2025, 12, 12, 9, 31, 48, 939, DateTimeKind.Utc).AddTicks(8763) });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "Code", "CreatedAt", "IsDeleted", "Level", "Name", "ParentCode", "UpdatedAt" },
                values: new object[,]
                {
                    { "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7112), false, 0, "北京市", null, new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7117) },
                    { "110101", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7660), false, 2, "东城区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7661) },
                    { "110102", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7662), false, 2, "西城区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7663) },
                    { "110105", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7663), false, 2, "朝阳区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7663) },
                    { "110106", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7664), false, 2, "丰台区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7664) },
                    { "110107", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7670), false, 2, "石景山区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7671) },
                    { "110108", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7671), false, 2, "海淀区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7671) },
                    { "110109", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7672), false, 2, "门头沟区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7672) },
                    { "110111", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7673), false, 2, "房山区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7673) },
                    { "110112", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7674), false, 2, "通州区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7674) },
                    { "110113", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7674), false, 2, "顺义区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7675) },
                    { "110114", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7675), false, 2, "昌平区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7675) },
                    { "110115", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7676), false, 2, "大兴区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7676) },
                    { "110116", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7676), false, 2, "怀柔区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7677) },
                    { "110117", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7677), false, 2, "平谷区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7677) },
                    { "110118", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7678), false, 2, "密云区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7678) },
                    { "110119", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7678), false, 2, "延庆区", "110000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7679) },
                    { "130000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7680), false, 0, "河北省", null, new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7680) },
                    { "130100", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7736), false, 1, "石家庄市", "130000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7736) },
                    { "130102", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7737), false, 2, "长安区", "130100", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7738) },
                    { "130200", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7739), false, 1, "唐山市", "130000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7739) },
                    { "130202", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7739), false, 2, "路南区", "130200", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7740) },
                    { "130300", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7740), false, 1, "秦皇岛市", "130000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7740) },
                    { "130302", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7741), false, 2, "海港区", "130300", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7741) },
                    { "130400", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7742), false, 1, "邯郸市", "130000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7742) },
                    { "130402", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7742), false, 2, "邯山区", "130400", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7743) },
                    { "130500", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7743), false, 1, "邢台市", "130000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7743) },
                    { "130502", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7744), false, 2, "襄都区", "130500", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7744) },
                    { "130600", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7744), false, 1, "保定市", "130000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7745) },
                    { "130606", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7745), false, 2, "莲池区", "130600", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7745) },
                    { "130700", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7746), false, 1, "张家口市", "130000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7746) },
                    { "130702", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7746), false, 2, "桥东区", "130700", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7746) },
                    { "130800", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7747), false, 1, "承德市", "130000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7747) },
                    { "130802", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7749), false, 2, "双桥区", "130800", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7750) },
                    { "130900", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7750), false, 1, "沧州市", "130000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7751) },
                    { "130902", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7751), false, 2, "新华区", "130900", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7751) },
                    { "131000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7752), false, 1, "廊坊市", "130000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7752) },
                    { "131003", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7752), false, 2, "广阳区", "131000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7752) },
                    { "131100", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7753), false, 1, "衡水市", "130000", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7753) },
                    { "131102", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7753), false, 2, "桃城区", "131100", new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7754) }
                });

            migrationBuilder.InsertData(
                table: "review_allocations",
                columns: new[] { "Id", "AssignedAt", "CreatedAt", "ExpertId", "IsDeleted", "NodeId", "Status", "TaskId", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2025, 12, 12, 9, 31, 48, 937, DateTimeKind.Utc).AddTicks(8045), new DateTime(2025, 12, 12, 9, 31, 48, 937, DateTimeKind.Utc).AddTicks(7567), 100L, false, 3L, 0, 1L, new DateTime(2025, 12, 12, 9, 31, 48, 937, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.InsertData(
                table: "scoring_template_items",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "LevelCode", "Ratio", "ScoringModelId", "Sort", "TemplateId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7045), "完全符合", false, "A", 1.0m, null, 1, 1L, new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7049) },
                    { 2L, new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7751), "基本符合", false, "B", 0.8m, null, 2, 1L, new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7751) },
                    { 3L, new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7753), "部分符合", false, "C", 0.6m, null, 3, 1L, new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7754) },
                    { 4L, new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7755), "不符合", false, "D", 0.0m, null, 4, 1L, new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7755) },
                    { 5L, new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7756), "合格", false, "是", 1.0m, null, 1, 2L, new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7757) },
                    { 6L, new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7760), "不合格", false, "否", 0.0m, null, 2, 2L, new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7760) }
                });

            migrationBuilder.InsertData(
                table: "scoring_templates",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 12, 12, 17, 31, 48, 922, DateTimeKind.Local).AddTicks(2940), false, "四级评分(A/B/C/D)", new DateTime(2025, 12, 12, 17, 31, 48, 923, DateTimeKind.Local).AddTicks(6458) },
                    { 2L, new DateTime(2025, 12, 12, 17, 31, 48, 923, DateTimeKind.Local).AddTicks(7261), false, "是否合格(是/否)", new DateTime(2025, 12, 12, 17, 31, 48, 923, DateTimeKind.Local).AddTicks(7263) },
                    { 3L, new DateTime(2025, 12, 12, 17, 31, 48, 923, DateTimeKind.Local).AddTicks(7264), false, "五星评价(1-5星)", new DateTime(2025, 12, 12, 17, 31, 48, 923, DateTimeKind.Local).AddTicks(7264) }
                });

            migrationBuilder.InsertData(
                table: "spe_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 10000L, null, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(5368), 0, false, 100m, "2025特教学校办学质量评价", 0, null, "0", null, 202501L, 0, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(5371) },
                    { 10001L, "1", new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(6570), 1, false, 20m, "办学方向", 0, 10000L, "0,10000", null, 202501L, 1, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(6571) },
                    { 10002L, "1.1", new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9601), 2, false, 10m, "党的领导", 0, 10001L, "0,10000,10001", null, 202501L, 2, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9601) },
                    { 10003L, "1.1.1", new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9618), 3, false, 10m, "党建工作常态化", 0, 10002L, "0,10000,10001,10002", 2L, 202501L, 4, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9618) },
                    { 10004L, "2", new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9749), 1, false, 40m, "教育教学", 0, 10000L, "0,10000", null, 202501L, 1, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9750) },
                    { 10005L, "2.1", new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9769), 2, false, 20m, "个别化教育", 0, 10004L, "0,10000,10004", null, 202501L, 2, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9769) },
                    { 10006L, "2.1.1", new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9772), 3, false, 10m, "IEP制定规范", 0, 10005L, "0,10000,10004,10005", null, 202501L, 3, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9773) },
                    { 10007L, null, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9776), 4, false, null, "查阅10份学生档案，检查IEP要素是否齐全。", 0, 10006L, "0,10000,10004,10005,10006", null, 202501L, 5, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9776) },
                    { 10008L, "2.1.2", new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9779), 3, false, 10m, "IEP实施效果", 0, 10005L, "0,10000,10004,10005", 1L, 202501L, 4, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9779) },
                    { 10009L, null, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9783), 0, false, 100m, "2024河北省特教质量监测", 0, null, "0", null, 202401L, 0, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9784) },
                    { 10010L, "A", new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9785), 1, false, 50m, "校园安全", 0, 10009L, "0,10009", null, 202401L, 1, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9785) },
                    { 10011L, "A-1", new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9788), 2, false, 50m, "无障碍设施", 0, 10010L, "0,10009,10010", 1L, 202401L, 4, new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9788) }
                });

            migrationBuilder.InsertData(
                table: "sys_role",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "Name", "Sort", "UpdatedAt", "remark" },
                values: new object[] { 1, "ADMIN", new DateTime(2025, 12, 12, 9, 31, 48, 946, DateTimeKind.Utc).AddTicks(1501), false, "管理员", 1, new DateTime(2025, 12, 12, 9, 31, 48, 946, DateTimeKind.Utc).AddTicks(1595), "系统超级管理员" });

            migrationBuilder.InsertData(
                table: "sys_users",
                columns: new[] { "IDNumber", "CreatedAt", "IsDeleted", "OrgId", "OrgType", "Password", "Phone", "RealName", "Role", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "110000197001010001", new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4932), false, "110000_OTH_01", 3, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13600000001", "特教专家", 1, new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4932), "expert_01" },
                    { "110000198001010001", new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4042), false, "110000_EDU", 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000000", "超级管理员", 0, new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4047), "admin" },
                    { "110105198501010001", new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4913), false, "110105_EDU", 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000001", "朝阳区管理员", 0, new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4913), "admin_cy" },
                    { "110105199001010001", new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4917), false, "110105_SPE_01", 0, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13900000001", "安华学校校长", 2, new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4918), "sch_cy_spe" },
                    { "110108199003030001", new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4930), false, "110108_INC_01", 1, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13900000003", "中关村校长", 2, new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4931), "sch_hd_inc" },
                    { "130100198502020001", new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4916), false, "130100_EDU", 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000002", "石家庄管理员", 0, new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4916), "admin_sjz" },
                    { "130100199002020001", new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4919), false, "130100_SPE_01", 0, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13900000002", "石特校长", 2, new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4920), "sch_sjz_spe" }
                });

            migrationBuilder.InsertData(
                table: "task_evidences",
                columns: new[] { "Id", "Content", "CreatedAt", "FileUrls", "IsDeleted", "NodeId", "RejectReason", "Status", "TaskId", "UpdatedAt" },
                values: new object[] { 1L, "自评报告内容...", new DateTime(2025, 12, 12, 9, 31, 48, 934, DateTimeKind.Utc).AddTicks(8086), "[\"http://file/a.pdf\"]", false, 3L, null, 0, 1L, new DateTime(2025, 12, 12, 9, 31, 48, 934, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.InsertData(
                table: "tasks",
                columns: new[] { "Id", "BatchId", "CreatedAt", "FinalScore", "IsDeleted", "Status", "SubmittedAt", "TargetId", "TargetType", "TreeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 30000L, 10000L, new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(235), null, false, 2, null, "110105_SPE_01", 0, 202501L, new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(237) },
                    { 30001L, 10000L, new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(853), null, false, 3, new DateTime(2025, 12, 11, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(855), "130100_SPE_01", 0, 202501L, new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(853) },
                    { 30002L, 10001L, new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1053), null, false, 0, null, "110108_INC_01", 1, 202502L, new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1054) },
                    { 30003L, 10002L, new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1055), null, false, 4, new DateTime(2025, 12, 10, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1056), "110105_EDU", 2, 202503L, new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1055) },
                    { 30004L, 10003L, new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1057), 88.5m, false, 6, new DateTime(2024, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1059), "130400_SPE_01", 0, 202401L, new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1058) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_scoring_template_items_ScoringModelId",
                table: "scoring_template_items",
                column: "ScoringModelId");

            migrationBuilder.CreateIndex(
                name: "IX_sys_users_UserName",
                table: "sys_users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ai_pre_evaluations");

            migrationBuilder.DropTable(
                name: "batch_targets");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "distribution_batches");

            migrationBuilder.DropTable(
                name: "edu_eval_nodes");

            migrationBuilder.DropTable(
                name: "expert_reviews");

            migrationBuilder.DropTable(
                name: "inc_eval_nodes");

            migrationBuilder.DropTable(
                name: "inspection_logs");

            migrationBuilder.DropTable(
                name: "inspection_schedules");

            migrationBuilder.DropTable(
                name: "inspection_team_members");

            migrationBuilder.DropTable(
                name: "inspection_teams");

            migrationBuilder.DropTable(
                name: "regions");

            migrationBuilder.DropTable(
                name: "review_allocations");

            migrationBuilder.DropTable(
                name: "scoring_template_items");

            migrationBuilder.DropTable(
                name: "spe_eval_nodes");

            migrationBuilder.DropTable(
                name: "sys_role");

            migrationBuilder.DropTable(
                name: "sys_user");

            migrationBuilder.DropTable(
                name: "sys_users");

            migrationBuilder.DropTable(
                name: "task_evidences");

            migrationBuilder.DropTable(
                name: "tasks");

            migrationBuilder.DropTable(
                name: "scoring_templates");
        }
    }
}
