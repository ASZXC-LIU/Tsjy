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
                    AssignmentId = table.Column<long>(type: "bigint", nullable: false),
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
                name: "assignment_evidences",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AssignmentId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_assignment_evidences", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "assignments",
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
                    table.PrimaryKey("PK_assignments", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "batch_targets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BatchId = table.Column<long>(type: "bigint", nullable: false),
                    OrgType = table.Column<int>(type: "int", nullable: false),
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
                    ScoringModelId = table.Column<long>(type: "bigint", nullable: true),
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
                name: "education_bureaus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RegionId = table.Column<long>(type: "bigint", nullable: false),
                    Level = table.Column<string>(type: "longtext", nullable: true),
                    Code = table.Column<string>(type: "longtext", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true),
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
                    table.PrimaryKey("PK_education_bureaus", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "expert_reviews",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AssignmentId = table.Column<long>(type: "bigint", nullable: false),
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
                    ScoringModelId = table.Column<long>(type: "bigint", nullable: true),
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
                name: "inclusive_schools",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RegionId = table.Column<long>(type: "bigint", nullable: false),
                    Code = table.Column<string>(type: "longtext", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inclusive_schools", x => x.Id);
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
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(255)", nullable: true),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regions", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "review_allocations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AssignmentId = table.Column<long>(type: "bigint", nullable: false),
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
                name: "scoring_models",
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
                    table.PrimaryKey("PK_scoring_models", x => x.Id);
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
                    ScoringModelId = table.Column<long>(type: "bigint", nullable: true),
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
                name: "special_schools",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RegionId = table.Column<long>(type: "bigint", nullable: false),
                    Code = table.Column<string>(type: "longtext", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_special_schools", x => x.Id);
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_sys_users", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "scoring_model_items",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ModelId = table.Column<long>(type: "bigint", nullable: false),
                    LevelCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Ratio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scoring_model_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_scoring_model_items_scoring_models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "scoring_models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "ai_pre_evaluations",
                columns: new[] { "Id", "AnalysisReport", "AssignmentId", "CreatedAt", "EvidenceId", "IsDeleted", "NodeId", "RiskLevel", "SuggestedScore", "UpdatedAt", "UserId" },
                values: new object[] { 1L, "AI分析通过", 1L, new DateTime(2025, 12, 8, 12, 50, 28, 693, DateTimeKind.Utc).AddTicks(2574), 1L, false, 3L, "low", 4.5m, new DateTime(2025, 12, 8, 12, 50, 28, 693, DateTimeKind.Utc).AddTicks(2575), 1L });

            migrationBuilder.InsertData(
                table: "assignment_evidences",
                columns: new[] { "Id", "AssignmentId", "Content", "CreatedAt", "FileUrls", "IsDeleted", "NodeId", "RejectReason", "Status", "UpdatedAt" },
                values: new object[] { 1L, 1L, "自评报告内容...", new DateTime(2025, 12, 8, 12, 50, 28, 691, DateTimeKind.Utc).AddTicks(9458), "[\"http://file/a.pdf\"]", false, 3L, null, 0, new DateTime(2025, 12, 8, 12, 50, 28, 691, DateTimeKind.Utc).AddTicks(8903) });

            migrationBuilder.InsertData(
                table: "assignments",
                columns: new[] { "Id", "BatchId", "CreatedAt", "DueAt", "FinalScore", "IsDeleted", "StartAt", "Status", "SubmittedAt", "TargetId", "TargetType", "TreeId", "UpdatedAt" },
                values: new object[] { 1L, 1L, new DateTime(2025, 12, 8, 12, 50, 28, 715, DateTimeKind.Utc).AddTicks(8193), new DateTime(2025, 12, 15, 12, 50, 28, 715, DateTimeKind.Utc).AddTicks(8114), null, false, new DateTime(2025, 12, 8, 12, 50, 28, 715, DateTimeKind.Utc).AddTicks(7994), 2, null, 1L, 0, 202501L, new DateTime(2025, 12, 8, 12, 50, 28, 715, DateTimeKind.Utc).AddTicks(7479) });

            migrationBuilder.InsertData(
                table: "batch_targets",
                columns: new[] { "Id", "BatchId", "CreatedAt", "IsDeleted", "OrgId", "OrgType", "UpdatedAt" },
                values: new object[] { 1L, 1L, new DateTime(2025, 12, 8, 12, 50, 28, 713, DateTimeKind.Utc).AddTicks(2276), false, 1L, 0, new DateTime(2025, 12, 8, 12, 50, 28, 713, DateTimeKind.Utc).AddTicks(1911) });

            migrationBuilder.InsertData(
                table: "distribution_batches",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "Status", "TreeId", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2025, 12, 8, 12, 50, 28, 712, DateTimeKind.Utc).AddTicks(2422), false, "2025年度第一次普查", 1, 202501L, new DateTime(2025, 12, 8, 12, 50, 28, 712, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.InsertData(
                table: "edu_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringModelId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2025, 12, 8, 12, 50, 28, 688, DateTimeKind.Utc).AddTicks(1492), 0, false, 100m, "河北省特教评价2025", 0, null, "0", null, 202501L, 0, new DateTime(2025, 12, 8, 12, 50, 28, 688, DateTimeKind.Utc).AddTicks(1494) },
                    { 2L, "1", new DateTime(2025, 12, 8, 12, 50, 28, 688, DateTimeKind.Utc).AddTicks(2432), 1, false, 20m, "办学方向", 0, 1L, "0,1", null, 202501L, 1, new DateTime(2025, 12, 8, 12, 50, 28, 688, DateTimeKind.Utc).AddTicks(2432) },
                    { 3L, "1.1", new DateTime(2025, 12, 8, 12, 50, 28, 688, DateTimeKind.Utc).AddTicks(2524), 2, false, 5m, "坚持办学方向", 0, 2L, "0,1,2", 1L, 202501L, 4, new DateTime(2025, 12, 8, 12, 50, 28, 688, DateTimeKind.Utc).AddTicks(2525) }
                });

            migrationBuilder.InsertData(
                table: "education_bureaus",
                columns: new[] { "Id", "Address", "Code", "CreatedAt", "IncSchoolsNum", "IsDeleted", "Level", "Name", "Phone", "RegionId", "SpeSchoolsNum", "UpdatedAt" },
                values: new object[] { 1L, "市局地址", "B130100", new DateTime(2025, 12, 8, 12, 50, 28, 532, DateTimeKind.Utc).AddTicks(3587), 10L, false, "city", "石家庄市教育局", 12345678, 2L, 1L, new DateTime(2025, 12, 8, 12, 50, 28, 532, DateTimeKind.Utc).AddTicks(1954) });

            migrationBuilder.InsertData(
                table: "expert_reviews",
                columns: new[] { "Id", "AssignmentId", "CreatedAt", "FinalScore", "IsDeleted", "NodeId", "ReviewerId", "ScoreRatio", "StandardScore", "UpdatedAt" },
                values: new object[] { 1L, 1L, new DateTime(2025, 12, 8, 12, 50, 28, 696, DateTimeKind.Utc).AddTicks(9042), 4.0m, false, 3L, 100L, 0.8m, 5m, new DateTime(2025, 12, 8, 12, 50, 28, 696, DateTimeKind.Utc).AddTicks(8333) });

            migrationBuilder.InsertData(
                table: "inc_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringModelId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2025, 12, 8, 12, 50, 28, 686, DateTimeKind.Utc).AddTicks(5528), 0, false, 100m, "河北省特教评价2025", 0, null, "0", null, 202501L, 0, new DateTime(2025, 12, 8, 12, 50, 28, 686, DateTimeKind.Utc).AddTicks(5531) },
                    { 2L, "1", new DateTime(2025, 12, 8, 12, 50, 28, 686, DateTimeKind.Utc).AddTicks(6465), 1, false, 20m, "办学方向", 0, 1L, "0,1", null, 202501L, 1, new DateTime(2025, 12, 8, 12, 50, 28, 686, DateTimeKind.Utc).AddTicks(6465) },
                    { 3L, "1.1", new DateTime(2025, 12, 8, 12, 50, 28, 686, DateTimeKind.Utc).AddTicks(6551), 2, false, 5m, "坚持办学方向", 0, 2L, "0,1,2", 1L, 202501L, 4, new DateTime(2025, 12, 8, 12, 50, 28, 686, DateTimeKind.Utc).AddTicks(6552) }
                });

            migrationBuilder.InsertData(
                table: "inclusive_schools",
                columns: new[] { "Id", "Address", "Code", "CreatedAt", "IsDeleted", "Name", "Phone", "RegionId", "UpdatedAt" },
                values: new object[] { 1L, "长安区地址", "I1301021", new DateTime(2025, 12, 8, 12, 50, 28, 531, DateTimeKind.Utc).AddTicks(916), false, "石家庄市长安区第一小学(融合校)", 66666666, 3L, new DateTime(2025, 12, 8, 12, 50, 28, 531, DateTimeKind.Utc).AddTicks(329) });

            migrationBuilder.InsertData(
                table: "inspection_logs",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EvidenceFiles", "Findings", "IsDeleted", "NodeId", "ScheduleId", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2025, 12, 8, 12, 50, 28, 702, DateTimeKind.Utc).AddTicks(3205), 100L, "[\"photo1.jpg\"]", "现场查看符合要求", false, 3L, 1L, new DateTime(2025, 12, 8, 12, 50, 28, 702, DateTimeKind.Utc).AddTicks(3206) });

            migrationBuilder.InsertData(
                table: "inspection_schedules",
                columns: new[] { "Id", "AssignmentId", "CreatedAt", "IsDeleted", "Status", "TeamId", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { 1L, 1L, new DateTime(2025, 12, 8, 12, 50, 28, 701, DateTimeKind.Utc).AddTicks(122), false, 0, 1L, new DateTime(2025, 12, 8, 12, 50, 28, 701, DateTimeKind.Utc).AddTicks(124), new DateTime(2025, 12, 10, 12, 50, 28, 701, DateTimeKind.Utc).AddTicks(627), new DateTime(2025, 12, 9, 12, 50, 28, 701, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.InsertData(
                table: "inspection_team_members",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "TeamId", "UpdatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2025, 12, 8, 12, 50, 28, 698, DateTimeKind.Utc).AddTicks(9359), false, 1L, new DateTime(2025, 12, 8, 12, 50, 28, 698, DateTimeKind.Utc).AddTicks(9027), 100L });

            migrationBuilder.InsertData(
                table: "inspection_teams",
                columns: new[] { "Id", "BatchId", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { 1L, 1L, new DateTime(2025, 12, 8, 12, 50, 28, 697, DateTimeKind.Utc).AddTicks(8472), false, "第一视导组", new DateTime(2025, 12, 8, 12, 50, 28, 697, DateTimeKind.Utc).AddTicks(8134) });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "Level", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, "130000", new DateTime(2025, 12, 8, 12, 50, 28, 527, DateTimeKind.Utc).AddTicks(4643), false, 0, "河北省", new DateTime(2025, 12, 8, 12, 50, 28, 527, DateTimeKind.Utc).AddTicks(4211) },
                    { 2L, "130100", new DateTime(2025, 12, 8, 12, 50, 28, 527, DateTimeKind.Utc).AddTicks(4747), false, 1, "石家庄市", new DateTime(2025, 12, 8, 12, 50, 28, 527, DateTimeKind.Utc).AddTicks(4746) },
                    { 3L, "130102", new DateTime(2025, 12, 8, 12, 50, 28, 527, DateTimeKind.Utc).AddTicks(4749), false, 2, "长安区", new DateTime(2025, 12, 8, 12, 50, 28, 527, DateTimeKind.Utc).AddTicks(4748) }
                });

            migrationBuilder.InsertData(
                table: "review_allocations",
                columns: new[] { "Id", "AssignedAt", "AssignmentId", "CreatedAt", "ExpertId", "IsDeleted", "NodeId", "Status", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2025, 12, 8, 12, 50, 28, 695, DateTimeKind.Utc).AddTicks(6933), 1L, new DateTime(2025, 12, 8, 12, 50, 28, 695, DateTimeKind.Utc).AddTicks(6479), 100L, false, 3L, 0, new DateTime(2025, 12, 8, 12, 50, 28, 695, DateTimeKind.Utc).AddTicks(6479) });

            migrationBuilder.InsertData(
                table: "scoring_models",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "标准四级制 (A/B/C/D)", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "符合性判断 (是/否)", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "spe_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringModelId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2025, 12, 8, 12, 50, 28, 684, DateTimeKind.Utc).AddTicks(9606), 0, false, 100m, "河北省特教评价2025", 0, null, "0", null, 202501L, 0, new DateTime(2025, 12, 8, 12, 50, 28, 684, DateTimeKind.Utc).AddTicks(9608) },
                    { 2L, "1", new DateTime(2025, 12, 8, 12, 50, 28, 685, DateTimeKind.Utc).AddTicks(700), 1, false, 20m, "办学方向", 0, 1L, "0,1", null, 202501L, 1, new DateTime(2025, 12, 8, 12, 50, 28, 685, DateTimeKind.Utc).AddTicks(700) },
                    { 3L, "1.1", new DateTime(2025, 12, 8, 12, 50, 28, 685, DateTimeKind.Utc).AddTicks(795), 2, false, 5m, "坚持办学方向", 0, 2L, "0,1,2", 1L, 202501L, 4, new DateTime(2025, 12, 8, 12, 50, 28, 685, DateTimeKind.Utc).AddTicks(795) }
                });

            migrationBuilder.InsertData(
                table: "special_schools",
                columns: new[] { "Id", "Address", "Code", "CreatedAt", "IsDeleted", "Name", "Phone", "RegionId", "Status", "UpdatedAt" },
                values: new object[] { 1L, "学校地址", "S1301001", new DateTime(2025, 12, 8, 12, 50, 28, 529, DateTimeKind.Utc).AddTicks(9260), false, "石家庄市特殊教育学校", 87654321, 2L, 1, new DateTime(2025, 12, 8, 12, 50, 28, 529, DateTimeKind.Utc).AddTicks(8614) });

            migrationBuilder.InsertData(
                table: "sys_role",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "Name", "Sort", "UpdatedAt", "remark" },
                values: new object[] { 1, "ADMIN", new DateTime(2025, 12, 8, 12, 50, 28, 703, DateTimeKind.Utc).AddTicks(5962), false, "管理员", 1, new DateTime(2025, 12, 8, 12, 50, 28, 703, DateTimeKind.Utc).AddTicks(6049), "系统超级管理员" });

            migrationBuilder.InsertData(
                table: "sys_users",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "OrgId", "OrgType", "Password", "Phone", "RealName", "Role", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 8, 12, 50, 28, 710, DateTimeKind.Utc).AddTicks(4577), false, 1, 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000000", "超级管理员", 0, new DateTime(2025, 12, 8, 12, 50, 28, 710, DateTimeKind.Utc).AddTicks(4697), "admin" },
                    { 100, new DateTime(2025, 12, 8, 12, 50, 28, 710, DateTimeKind.Utc).AddTicks(4922), false, 1, 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000000", "超级管理员", 0, new DateTime(2025, 12, 8, 12, 50, 28, 710, DateTimeKind.Utc).AddTicks(4923), "100" }
                });

            migrationBuilder.InsertData(
                table: "scoring_model_items",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "LevelCode", "ModelId", "Ratio", "Sort", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "优秀/落实到位", false, "A", 1L, 1.0m, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "良好/基本落实", false, "B", 1L, 0.8m, 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "合格/部分落实", false, "C", 1L, 0.6m, 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "不合格/未落实", false, "D", 1L, 0.0m, 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "符合/是", false, "A", 2L, 1.0m, 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "不符合/否", false, "B", 2L, 0.0m, 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_regions_Code",
                table: "regions",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_scoring_model_items_ModelId",
                table: "scoring_model_items",
                column: "ModelId");

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
                name: "assignment_evidences");

            migrationBuilder.DropTable(
                name: "assignments");

            migrationBuilder.DropTable(
                name: "batch_targets");

            migrationBuilder.DropTable(
                name: "distribution_batches");

            migrationBuilder.DropTable(
                name: "edu_eval_nodes");

            migrationBuilder.DropTable(
                name: "education_bureaus");

            migrationBuilder.DropTable(
                name: "expert_reviews");

            migrationBuilder.DropTable(
                name: "inc_eval_nodes");

            migrationBuilder.DropTable(
                name: "inclusive_schools");

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
                name: "scoring_model_items");

            migrationBuilder.DropTable(
                name: "spe_eval_nodes");

            migrationBuilder.DropTable(
                name: "special_schools");

            migrationBuilder.DropTable(
                name: "sys_role");

            migrationBuilder.DropTable(
                name: "sys_user");

            migrationBuilder.DropTable(
                name: "sys_users");

            migrationBuilder.DropTable(
                name: "scoring_models");
        }
    }
}
