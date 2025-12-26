using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tsjy.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v1700 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ai_pre_evaluations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 471, DateTimeKind.Utc).AddTicks(3273), new DateTime(2025, 12, 26, 7, 34, 26, 471, DateTimeKind.Utc).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(2779), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_OTH_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3542), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3507), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3537), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3517), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3510), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3539), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3519), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3511), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3513), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3520), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130102_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3533), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130104_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3540), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3516), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3536), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130402_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3541), new DateTime(2025, 12, 26, 7, 34, 26, 416, DateTimeKind.Utc).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(3443), new DateTime(2026, 1, 15, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(3941), new DateTime(2025, 12, 16, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(3855), new DateTime(2025, 12, 26, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(4017), new DateTime(2026, 1, 30, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(4019), new DateTime(2025, 12, 31, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(4019), new DateTime(2025, 12, 26, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(4020), new DateTime(2026, 1, 10, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(4022), new DateTime(2025, 12, 24, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(4021), new DateTime(2025, 12, 26, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(4023), new DateTime(2025, 1, 25, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(4057), new DateTime(2024, 12, 26, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(4024), new DateTime(2025, 12, 26, 7, 34, 26, 490, DateTimeKind.Utc).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 465, DateTimeKind.Utc).AddTicks(6113), new DateTime(2025, 12, 26, 7, 34, 26, 465, DateTimeKind.Utc).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 465, DateTimeKind.Utc).AddTicks(6927), new DateTime(2025, 12, 26, 7, 34, 26, 465, DateTimeKind.Utc).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 465, DateTimeKind.Utc).AddTicks(7018), new DateTime(2025, 12, 26, 7, 34, 26, 465, DateTimeKind.Utc).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 465, DateTimeKind.Utc).AddTicks(7100), new DateTime(2025, 12, 26, 7, 34, 26, 465, DateTimeKind.Utc).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 465, DateTimeKind.Utc).AddTicks(7104), new DateTime(2025, 12, 26, 7, 34, 26, 465, DateTimeKind.Utc).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 474, DateTimeKind.Utc).AddTicks(1348), new DateTime(2025, 12, 26, 7, 34, 26, 474, DateTimeKind.Utc).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 463, DateTimeKind.Utc).AddTicks(7883), new DateTime(2025, 12, 26, 7, 34, 26, 463, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 463, DateTimeKind.Utc).AddTicks(8729), new DateTime(2025, 12, 26, 7, 34, 26, 463, DateTimeKind.Utc).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 463, DateTimeKind.Utc).AddTicks(8826), new DateTime(2025, 12, 26, 7, 34, 26, 463, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 463, DateTimeKind.Utc).AddTicks(8912), new DateTime(2025, 12, 26, 7, 34, 26, 463, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 463, DateTimeKind.Utc).AddTicks(8916), new DateTime(2025, 12, 26, 7, 34, 26, 463, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 463, DateTimeKind.Utc).AddTicks(8922), new DateTime(2025, 12, 26, 7, 34, 26, 463, DateTimeKind.Utc).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "inspection_logs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 479, DateTimeKind.Utc).AddTicks(6076), new DateTime(2025, 12, 26, 7, 34, 26, 479, DateTimeKind.Utc).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "inspection_schedules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 478, DateTimeKind.Utc).AddTicks(3940), new DateTime(2025, 12, 26, 7, 34, 26, 478, DateTimeKind.Utc).AddTicks(3941), new DateTime(2025, 12, 28, 7, 34, 26, 478, DateTimeKind.Utc).AddTicks(4397), new DateTime(2025, 12, 27, 7, 34, 26, 478, DateTimeKind.Utc).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "inspection_team_members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 476, DateTimeKind.Utc).AddTicks(4411), new DateTime(2025, 12, 26, 7, 34, 26, 476, DateTimeKind.Utc).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "inspection_teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 475, DateTimeKind.Utc).AddTicks(264), new DateTime(2025, 12, 26, 7, 34, 26, 474, DateTimeKind.Utc).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(7565), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110101",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8010), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8012), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110105",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8013), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110106",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8014), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110107",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8017), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110108",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8017), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110109",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8018), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110111",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8019), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110112",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8020), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110113",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8020), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110114",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8021), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110115",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8021), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110116",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8022), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110117",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8023), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110118",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8023), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110119",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8024), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8025), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8065), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8066), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130200",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8067), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130202",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8068), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130300",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8069), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130302",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8069), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130400",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8070), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130402",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8070), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130500",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8071), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130502",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8072), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130600",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8072), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130606",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8073), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130700",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8074), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130702",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8074), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130800",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8075), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130802",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8077), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130900",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8078), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130902",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8079), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8080), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8080), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8081), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8081), new DateTime(2025, 12, 26, 7, 34, 26, 412, DateTimeKind.Utc).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 34, 26, 457, DateTimeKind.Local).AddTicks(5480), new DateTime(2025, 12, 26, 15, 34, 26, 457, DateTimeKind.Local).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 34, 26, 457, DateTimeKind.Local).AddTicks(6212), new DateTime(2025, 12, 26, 15, 34, 26, 457, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 34, 26, 457, DateTimeKind.Local).AddTicks(6214), new DateTime(2025, 12, 26, 15, 34, 26, 457, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 34, 26, 457, DateTimeKind.Local).AddTicks(6216), new DateTime(2025, 12, 26, 15, 34, 26, 457, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 34, 26, 457, DateTimeKind.Local).AddTicks(6217), new DateTime(2025, 12, 26, 15, 34, 26, 457, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 34, 26, 457, DateTimeKind.Local).AddTicks(6221), new DateTime(2025, 12, 26, 15, 34, 26, 457, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 34, 26, 454, DateTimeKind.Local).AddTicks(8507), new DateTime(2025, 12, 26, 15, 34, 26, 456, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 34, 26, 456, DateTimeKind.Local).AddTicks(1660), new DateTime(2025, 12, 26, 15, 34, 26, 456, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 34, 26, 456, DateTimeKind.Local).AddTicks(1664), new DateTime(2025, 12, 26, 15, 34, 26, 456, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(1010), new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(2085), new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6426), new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6446), new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6606), new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6629), new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10006L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6632), new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10007L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6636), new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10008L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6639), new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10009L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6643), new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10010L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6645), new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10011L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6647), new DateTime(2025, 12, 26, 7, 34, 26, 460, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 480, DateTimeKind.Utc).AddTicks(7878), new DateTime(2025, 12, 26, 7, 34, 26, 480, DateTimeKind.Utc).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000197001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(2539), new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000198001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(1710), new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105198501010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(2526), new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105199001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(2531), new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110108199003030001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(2538), new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100198502020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(2529), new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100199002020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(2533), new DateTime(2025, 12, 26, 7, 34, 26, 488, DateTimeKind.Utc).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "task_evidences",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 470, DateTimeKind.Utc).AddTicks(2137), new DateTime(2025, 12, 26, 7, 34, 26, 470, DateTimeKind.Utc).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 492, DateTimeKind.Utc).AddTicks(3735), new DateTime(2025, 12, 26, 7, 34, 26, 492, DateTimeKind.Utc).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 492, DateTimeKind.Utc).AddTicks(4364), new DateTime(2025, 12, 25, 7, 34, 26, 492, DateTimeKind.Utc).AddTicks(4366), new DateTime(2025, 12, 26, 7, 34, 26, 492, DateTimeKind.Utc).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 492, DateTimeKind.Utc).AddTicks(4544), new DateTime(2025, 12, 26, 7, 34, 26, 492, DateTimeKind.Utc).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 492, DateTimeKind.Utc).AddTicks(4546), new DateTime(2025, 12, 24, 7, 34, 26, 492, DateTimeKind.Utc).AddTicks(4547), new DateTime(2025, 12, 26, 7, 34, 26, 492, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 34, 26, 492, DateTimeKind.Utc).AddTicks(4548), new DateTime(2024, 12, 26, 7, 34, 26, 492, DateTimeKind.Utc).AddTicks(4549), new DateTime(2025, 12, 26, 7, 34, 26, 492, DateTimeKind.Utc).AddTicks(4548) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ai_pre_evaluations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 946, DateTimeKind.Utc).AddTicks(6991), new DateTime(2025, 12, 26, 7, 31, 11, 946, DateTimeKind.Utc).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(6728), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_OTH_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7768), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7734), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7763), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7747), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7737), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7765), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7748), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7738), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7740), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7750), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130102_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7761), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130104_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7766), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7745), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7762), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130402_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7767), new DateTime(2025, 12, 26, 7, 31, 11, 888, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(5785), new DateTime(2026, 1, 15, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6408), new DateTime(2025, 12, 16, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6300), new DateTime(2025, 12, 26, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6507), new DateTime(2026, 1, 30, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6509), new DateTime(2025, 12, 31, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6509), new DateTime(2025, 12, 26, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6510), new DateTime(2026, 1, 10, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6512), new DateTime(2025, 12, 24, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6512), new DateTime(2025, 12, 26, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6513), new DateTime(2025, 1, 25, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6552), new DateTime(2024, 12, 26, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6514), new DateTime(2025, 12, 26, 7, 31, 11, 966, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 941, DateTimeKind.Utc).AddTicks(4384), new DateTime(2025, 12, 26, 7, 31, 11, 941, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 941, DateTimeKind.Utc).AddTicks(5309), new DateTime(2025, 12, 26, 7, 31, 11, 941, DateTimeKind.Utc).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 941, DateTimeKind.Utc).AddTicks(5412), new DateTime(2025, 12, 26, 7, 31, 11, 941, DateTimeKind.Utc).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 941, DateTimeKind.Utc).AddTicks(5510), new DateTime(2025, 12, 26, 7, 31, 11, 941, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 941, DateTimeKind.Utc).AddTicks(5514), new DateTime(2025, 12, 26, 7, 31, 11, 941, DateTimeKind.Utc).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 949, DateTimeKind.Utc).AddTicks(9305), new DateTime(2025, 12, 26, 7, 31, 11, 949, DateTimeKind.Utc).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 939, DateTimeKind.Utc).AddTicks(7091), new DateTime(2025, 12, 26, 7, 31, 11, 939, DateTimeKind.Utc).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 939, DateTimeKind.Utc).AddTicks(8012), new DateTime(2025, 12, 26, 7, 31, 11, 939, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 939, DateTimeKind.Utc).AddTicks(8116), new DateTime(2025, 12, 26, 7, 31, 11, 939, DateTimeKind.Utc).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 939, DateTimeKind.Utc).AddTicks(8216), new DateTime(2025, 12, 26, 7, 31, 11, 939, DateTimeKind.Utc).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 939, DateTimeKind.Utc).AddTicks(8221), new DateTime(2025, 12, 26, 7, 31, 11, 939, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 939, DateTimeKind.Utc).AddTicks(8228), new DateTime(2025, 12, 26, 7, 31, 11, 939, DateTimeKind.Utc).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "inspection_logs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 955, DateTimeKind.Utc).AddTicks(5080), new DateTime(2025, 12, 26, 7, 31, 11, 955, DateTimeKind.Utc).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "inspection_schedules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 954, DateTimeKind.Utc).AddTicks(1604), new DateTime(2025, 12, 26, 7, 31, 11, 954, DateTimeKind.Utc).AddTicks(1605), new DateTime(2025, 12, 28, 7, 31, 11, 954, DateTimeKind.Utc).AddTicks(2113), new DateTime(2025, 12, 27, 7, 31, 11, 954, DateTimeKind.Utc).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "inspection_team_members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 952, DateTimeKind.Utc).AddTicks(1164), new DateTime(2025, 12, 26, 7, 31, 11, 952, DateTimeKind.Utc).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "inspection_teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 951, DateTimeKind.Utc).AddTicks(1580), new DateTime(2025, 12, 26, 7, 31, 11, 951, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(2612), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110101",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3141), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3143), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110105",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3144), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110106",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3145), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110107",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3148), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110108",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3149), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110109",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3150), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110111",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3150), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110112",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3152), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110113",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3153), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110114",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3153), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110115",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3154), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110116",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3155), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110117",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3155), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110118",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3156), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110119",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3157), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3158), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3208), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3209), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130200",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3211), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130202",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3212), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130300",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3213), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130302",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3213), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130400",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3214), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130402",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3215), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130500",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3215), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130502",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3216), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130600",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3216), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130606",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3217), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130700",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3218), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130702",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3218), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130800",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3219), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130802",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3222), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130900",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3223), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130902",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3224), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3225), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3225), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3226), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3226), new DateTime(2025, 12, 26, 7, 31, 11, 884, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 31, 11, 934, DateTimeKind.Local).AddTicks(2442), new DateTime(2025, 12, 26, 15, 31, 11, 934, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 31, 11, 934, DateTimeKind.Local).AddTicks(3288), new DateTime(2025, 12, 26, 15, 31, 11, 934, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 31, 11, 934, DateTimeKind.Local).AddTicks(3290), new DateTime(2025, 12, 26, 15, 31, 11, 934, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 31, 11, 934, DateTimeKind.Local).AddTicks(3292), new DateTime(2025, 12, 26, 15, 31, 11, 934, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 31, 11, 934, DateTimeKind.Local).AddTicks(3294), new DateTime(2025, 12, 26, 15, 31, 11, 934, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 31, 11, 934, DateTimeKind.Local).AddTicks(3299), new DateTime(2025, 12, 26, 15, 31, 11, 934, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 31, 11, 931, DateTimeKind.Local).AddTicks(7073), new DateTime(2025, 12, 26, 15, 31, 11, 933, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 31, 11, 933, DateTimeKind.Local).AddTicks(2045), new DateTime(2025, 12, 26, 15, 31, 11, 933, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 15, 31, 11, 933, DateTimeKind.Local).AddTicks(2049), new DateTime(2025, 12, 26, 15, 31, 11, 933, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(5179), new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(6447), new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9774), new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9792), new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9966), new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9975), new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10006L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9979), new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10007L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9983), new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10008L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9986), new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10009L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9991), new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10010L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9993), new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10011L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9995), new DateTime(2025, 12, 26, 7, 31, 11, 937, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 956, DateTimeKind.Utc).AddTicks(8107), new DateTime(2025, 12, 26, 7, 31, 11, 956, DateTimeKind.Utc).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000197001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(9477), new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000198001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(8431), new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105198501010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(9462), new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105199001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(9467), new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110108199003030001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(9475), new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100198502020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(9465), new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100199002020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(9469), new DateTime(2025, 12, 26, 7, 31, 11, 963, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "task_evidences",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 945, DateTimeKind.Utc).AddTicks(4423), new DateTime(2025, 12, 26, 7, 31, 11, 945, DateTimeKind.Utc).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 968, DateTimeKind.Utc).AddTicks(8267), new DateTime(2025, 12, 26, 7, 31, 11, 968, DateTimeKind.Utc).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 968, DateTimeKind.Utc).AddTicks(8907), new DateTime(2025, 12, 25, 7, 31, 11, 968, DateTimeKind.Utc).AddTicks(8909), new DateTime(2025, 12, 26, 7, 31, 11, 968, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 968, DateTimeKind.Utc).AddTicks(9101), new DateTime(2025, 12, 26, 7, 31, 11, 968, DateTimeKind.Utc).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 968, DateTimeKind.Utc).AddTicks(9103), new DateTime(2025, 12, 24, 7, 31, 11, 968, DateTimeKind.Utc).AddTicks(9104), new DateTime(2025, 12, 26, 7, 31, 11, 968, DateTimeKind.Utc).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 7, 31, 11, 968, DateTimeKind.Utc).AddTicks(9105), new DateTime(2024, 12, 26, 7, 31, 11, 968, DateTimeKind.Utc).AddTicks(9107), new DateTime(2025, 12, 26, 7, 31, 11, 968, DateTimeKind.Utc).AddTicks(9106) });
        }
    }
}
