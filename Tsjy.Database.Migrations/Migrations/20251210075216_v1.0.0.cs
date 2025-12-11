using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tsjy.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v100 : Migration
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
                    OrgId = table.Column<long>(type: "bigint", nullable: false),
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
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
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
                    OrgId = table.Column<int>(type: "int", nullable: false),
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
                    TargetId = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DueAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
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
                    LevelCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
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
                values: new object[] { 1L, "AI分析通过", new DateTime(2025, 12, 10, 7, 52, 15, 492, DateTimeKind.Utc).AddTicks(5547), 1L, false, 3L, "low", 4.5m, 1L, new DateTime(2025, 12, 10, 7, 52, 15, 492, DateTimeKind.Utc).AddTicks(5551), 1L });

            migrationBuilder.InsertData(
                table: "batch_targets",
                columns: new[] { "Id", "BatchId", "CreatedAt", "IsDeleted", "OrgId", "UpdatedAt" },
                values: new object[] { 1L, 1L, new DateTime(2025, 12, 10, 7, 52, 15, 514, DateTimeKind.Utc).AddTicks(6114), false, 1L, new DateTime(2025, 12, 10, 7, 52, 15, 514, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Code", "Address", "CreatedAt", "IncSchoolsNum", "IsDeleted", "Level", "Name", "OrgType", "Phone", "RegionCode", "SpeSchoolsNum", "UpdatedAt" },
                values: new object[,]
                {
                    { "330100_EDU", "杭州市某某路1号", new DateTime(2025, 12, 10, 7, 52, 15, 441, DateTimeKind.Utc).AddTicks(715), 120L, false, 1, "杭州市教育局", 2, 88888888, "330100", 8L, new DateTime(2025, 12, 10, 7, 52, 15, 440, DateTimeKind.Utc).AddTicks(8855) },
                    { "330106_EDU", "西湖区某某路2号", new DateTime(2025, 12, 10, 7, 52, 15, 441, DateTimeKind.Utc).AddTicks(843), 45L, false, 2, "西湖区教育局", 2, 66666666, "330106", 2L, new DateTime(2025, 12, 10, 7, 52, 15, 441, DateTimeKind.Utc).AddTicks(840) }
                });

            migrationBuilder.InsertData(
                table: "distribution_batches",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "Status", "TreeId", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2025, 12, 10, 7, 52, 15, 513, DateTimeKind.Utc).AddTicks(6728), false, "2025年度第一次普查", 1, 202501L, new DateTime(2025, 12, 10, 7, 52, 15, 513, DateTimeKind.Utc).AddTicks(6315) });

            migrationBuilder.InsertData(
                table: "edu_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2025, 12, 10, 7, 52, 15, 487, DateTimeKind.Utc).AddTicks(5027), 0, false, 100m, "河北省特教评价2025", 0, null, "0", null, 202501L, 0, new DateTime(2025, 12, 10, 7, 52, 15, 487, DateTimeKind.Utc).AddTicks(5032) },
                    { 2L, "1", new DateTime(2025, 12, 10, 7, 52, 15, 487, DateTimeKind.Utc).AddTicks(6054), 1, false, 20m, "办学方向", 0, 1L, "0,1", null, 202501L, 1, new DateTime(2025, 12, 10, 7, 52, 15, 487, DateTimeKind.Utc).AddTicks(6054) },
                    { 3L, "1.1", new DateTime(2025, 12, 10, 7, 52, 15, 487, DateTimeKind.Utc).AddTicks(6140), 2, false, 5m, "坚持办学方向", 0, 2L, "0,1,2", 1L, 202501L, 4, new DateTime(2025, 12, 10, 7, 52, 15, 487, DateTimeKind.Utc).AddTicks(6140) }
                });

            migrationBuilder.InsertData(
                table: "expert_reviews",
                columns: new[] { "Id", "CreatedAt", "FinalScore", "IsDeleted", "NodeId", "ReviewerId", "ScoreRatio", "StandardScore", "TaskId", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2025, 12, 10, 7, 52, 15, 496, DateTimeKind.Utc).AddTicks(5747), 4.0m, false, 3L, 100L, 0.8m, 5m, 1L, new DateTime(2025, 12, 10, 7, 52, 15, 496, DateTimeKind.Utc).AddTicks(5085) });

            migrationBuilder.InsertData(
                table: "inc_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2025, 12, 10, 7, 52, 15, 485, DateTimeKind.Utc).AddTicks(7515), 0, false, 100m, "河北省特教评价2025", 0, null, "0", null, 202501L, 0, new DateTime(2025, 12, 10, 7, 52, 15, 485, DateTimeKind.Utc).AddTicks(7517) },
                    { 2L, "1", new DateTime(2025, 12, 10, 7, 52, 15, 485, DateTimeKind.Utc).AddTicks(8373), 1, false, 20m, "办学方向", 0, 1L, "0,1", null, 202501L, 1, new DateTime(2025, 12, 10, 7, 52, 15, 485, DateTimeKind.Utc).AddTicks(8374) },
                    { 3L, "1.1", new DateTime(2025, 12, 10, 7, 52, 15, 485, DateTimeKind.Utc).AddTicks(8455), 2, false, 5m, "坚持办学方向", 0, 2L, "0,1,2", 1L, 202501L, 4, new DateTime(2025, 12, 10, 7, 52, 15, 485, DateTimeKind.Utc).AddTicks(8455) }
                });

            migrationBuilder.InsertData(
                table: "inspection_logs",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EvidenceFiles", "Findings", "IsDeleted", "NodeId", "ScheduleId", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2025, 12, 10, 7, 52, 15, 502, DateTimeKind.Utc).AddTicks(726), 100L, "[\"photo1.jpg\"]", "现场查看符合要求", false, 3L, 1L, new DateTime(2025, 12, 10, 7, 52, 15, 502, DateTimeKind.Utc).AddTicks(727) });

            migrationBuilder.InsertData(
                table: "inspection_schedules",
                columns: new[] { "Id", "AssignmentId", "CreatedAt", "IsDeleted", "Status", "TeamId", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { 1L, 1L, new DateTime(2025, 12, 10, 7, 52, 15, 500, DateTimeKind.Utc).AddTicks(7500), false, 0, 1L, new DateTime(2025, 12, 10, 7, 52, 15, 500, DateTimeKind.Utc).AddTicks(7502), new DateTime(2025, 12, 12, 7, 52, 15, 500, DateTimeKind.Utc).AddTicks(7972), new DateTime(2025, 12, 11, 7, 52, 15, 500, DateTimeKind.Utc).AddTicks(7809) });

            migrationBuilder.InsertData(
                table: "inspection_team_members",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "TeamId", "UpdatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2025, 12, 10, 7, 52, 15, 498, DateTimeKind.Utc).AddTicks(8335), false, 1L, new DateTime(2025, 12, 10, 7, 52, 15, 498, DateTimeKind.Utc).AddTicks(8019), 100L });

            migrationBuilder.InsertData(
                table: "inspection_teams",
                columns: new[] { "Id", "BatchId", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { 1L, 1L, new DateTime(2025, 12, 10, 7, 52, 15, 497, DateTimeKind.Utc).AddTicks(7358), false, "第一视导组", new DateTime(2025, 12, 10, 7, 52, 15, 497, DateTimeKind.Utc).AddTicks(7029) });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "Code", "CreatedAt", "IsDeleted", "Level", "Name", "ParentCode", "UpdatedAt" },
                values: new object[,]
                {
                    { "330000", new DateTime(2025, 12, 10, 7, 52, 15, 437, DateTimeKind.Utc).AddTicks(1204), false, 0, "浙江省", null, new DateTime(2025, 12, 10, 7, 52, 15, 437, DateTimeKind.Utc).AddTicks(764) },
                    { "330100", new DateTime(2025, 12, 10, 7, 52, 15, 437, DateTimeKind.Utc).AddTicks(1303), false, 1, "杭州市", "330000", new DateTime(2025, 12, 10, 7, 52, 15, 437, DateTimeKind.Utc).AddTicks(1301) },
                    { "330106", new DateTime(2025, 12, 10, 7, 52, 15, 437, DateTimeKind.Utc).AddTicks(1305), false, 2, "西湖区", "330100", new DateTime(2025, 12, 10, 7, 52, 15, 437, DateTimeKind.Utc).AddTicks(1304) }
                });

            migrationBuilder.InsertData(
                table: "review_allocations",
                columns: new[] { "Id", "AssignedAt", "CreatedAt", "ExpertId", "IsDeleted", "NodeId", "Status", "TaskId", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2025, 12, 10, 7, 52, 15, 495, DateTimeKind.Utc).AddTicks(3324), new DateTime(2025, 12, 10, 7, 52, 15, 495, DateTimeKind.Utc).AddTicks(2785), 100L, false, 3L, 0, 1L, new DateTime(2025, 12, 10, 7, 52, 15, 495, DateTimeKind.Utc).AddTicks(2785) });

            migrationBuilder.InsertData(
                table: "scoring_template_items",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "LevelCode", "Ratio", "ScoringModelId", "Sort", "TemplateId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 12, 10, 7, 52, 15, 482, DateTimeKind.Utc).AddTicks(1011), "完全符合指标要求，佐证材料详实", false, "A", 1.0m, null, 1, 1L, new DateTime(2025, 12, 10, 15, 52, 15, 482, DateTimeKind.Local).AddTicks(309) },
                    { 2L, new DateTime(2025, 12, 10, 7, 52, 15, 482, DateTimeKind.Utc).AddTicks(1100), "基本符合，存在少量非关键性缺失", false, "B", 0.8m, null, 2, 1L, new DateTime(2025, 12, 10, 15, 52, 15, 482, DateTimeKind.Local).AddTicks(1097) },
                    { 3L, new DateTime(2025, 12, 10, 7, 52, 15, 482, DateTimeKind.Utc).AddTicks(1102), "部分符合，存在明显问题或材料不足", false, "C", 0.6m, null, 3, 1L, new DateTime(2025, 12, 10, 15, 52, 15, 482, DateTimeKind.Local).AddTicks(1101) },
                    { 4L, new DateTime(2025, 12, 10, 7, 52, 15, 482, DateTimeKind.Utc).AddTicks(1104), "不符合要求或未开展此项工作", false, "D", 0.0m, null, 4, 1L, new DateTime(2025, 12, 10, 15, 52, 15, 482, DateTimeKind.Local).AddTicks(1103) }
                });

            migrationBuilder.InsertData(
                table: "scoring_templates",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2025, 12, 10, 7, 52, 15, 481, DateTimeKind.Utc).AddTicks(566), false, "通用四级评分标准(A/B/C/D)", new DateTime(2025, 12, 10, 15, 52, 15, 480, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.InsertData(
                table: "spe_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2025, 12, 10, 7, 52, 15, 484, DateTimeKind.Utc).AddTicks(2818), 0, false, 100m, "河北省特教评价2025", 0, null, "0", null, 202501L, 0, new DateTime(2025, 12, 10, 7, 52, 15, 484, DateTimeKind.Utc).AddTicks(2820) },
                    { 2L, "1", new DateTime(2025, 12, 10, 7, 52, 15, 484, DateTimeKind.Utc).AddTicks(3835), 1, false, 20m, "办学方向", 0, 1L, "0,1", null, 202501L, 1, new DateTime(2025, 12, 10, 7, 52, 15, 484, DateTimeKind.Utc).AddTicks(3835) },
                    { 3L, "1.1", new DateTime(2025, 12, 10, 7, 52, 15, 484, DateTimeKind.Utc).AddTicks(3924), 2, false, 5m, "坚持办学方向", 0, 2L, "0,1,2", 1L, 202501L, 4, new DateTime(2025, 12, 10, 7, 52, 15, 484, DateTimeKind.Utc).AddTicks(3925) }
                });

            migrationBuilder.InsertData(
                table: "sys_role",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "Name", "Sort", "UpdatedAt", "remark" },
                values: new object[] { 1, "ADMIN", new DateTime(2025, 12, 10, 7, 52, 15, 503, DateTimeKind.Utc).AddTicks(5666), false, "管理员", 1, new DateTime(2025, 12, 10, 7, 52, 15, 503, DateTimeKind.Utc).AddTicks(5762), "系统超级管理员" });

            migrationBuilder.InsertData(
                table: "sys_users",
                columns: new[] { "IDNumber", "CreatedAt", "IsDeleted", "OrgId", "OrgType", "Password", "Phone", "RealName", "Role", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "123456789012345678", new DateTime(2025, 12, 10, 7, 52, 15, 511, DateTimeKind.Utc).AddTicks(6530), false, 1, 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000000", "超级管理员", 0, new DateTime(2025, 12, 10, 7, 52, 15, 511, DateTimeKind.Utc).AddTicks(6639), "admin" },
                    { "123456789012345679", new DateTime(2025, 12, 10, 7, 52, 15, 511, DateTimeKind.Utc).AddTicks(6846), false, 1, 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000000", "超级管理员", 0, new DateTime(2025, 12, 10, 7, 52, 15, 511, DateTimeKind.Utc).AddTicks(6847), "100" }
                });

            migrationBuilder.InsertData(
                table: "task_evidences",
                columns: new[] { "Id", "Content", "CreatedAt", "FileUrls", "IsDeleted", "NodeId", "RejectReason", "Status", "TaskId", "UpdatedAt" },
                values: new object[] { 1L, "自评报告内容...", new DateTime(2025, 12, 10, 7, 52, 15, 491, DateTimeKind.Utc).AddTicks(4644), "[\"http://file/a.pdf\"]", false, 3L, null, 0, 1L, new DateTime(2025, 12, 10, 7, 52, 15, 491, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.InsertData(
                table: "tasks",
                columns: new[] { "Id", "BatchId", "CreatedAt", "DueAt", "FinalScore", "IsDeleted", "StartAt", "Status", "SubmittedAt", "TargetId", "TargetType", "TreeId", "UpdatedAt" },
                values: new object[] { 1L, 1L, new DateTime(2025, 12, 10, 7, 52, 15, 516, DateTimeKind.Utc).AddTicks(6172), new DateTime(2025, 12, 17, 7, 52, 15, 516, DateTimeKind.Utc).AddTicks(6088), null, false, new DateTime(2025, 12, 10, 7, 52, 15, 516, DateTimeKind.Utc).AddTicks(5997), 2, null, 1L, 0, 202501L, new DateTime(2025, 12, 10, 7, 52, 15, 516, DateTimeKind.Utc).AddTicks(5448) });

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
