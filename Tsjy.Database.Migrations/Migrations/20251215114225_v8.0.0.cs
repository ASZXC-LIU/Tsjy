using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tsjy.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v800 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "batch_targets");

            migrationBuilder.DropTable(
                name: "review_allocations");

            migrationBuilder.UpdateData(
                table: "ai_pre_evaluations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 57, DateTimeKind.Utc).AddTicks(2539), new DateTime(2025, 12, 15, 11, 42, 25, 57, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8127), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_OTH_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8879), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8856), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8874), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8866), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8859), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8875), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8868), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8860), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8862), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8869), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130102_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8871), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130104_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8876), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8865), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8872), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130402_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8877), new DateTime(2025, 12, 15, 11, 42, 24, 995, DateTimeKind.Utc).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(2493), new DateTime(2026, 1, 4, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3120), new DateTime(2025, 12, 5, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3017), new DateTime(2025, 12, 15, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3211), new DateTime(2026, 1, 19, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3213), new DateTime(2025, 12, 20, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3213), new DateTime(2025, 12, 15, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3215), new DateTime(2025, 12, 30, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3216), new DateTime(2025, 12, 13, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3216), new DateTime(2025, 12, 15, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3217), new DateTime(2025, 1, 14, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3263), new DateTime(2024, 12, 15, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3218), new DateTime(2025, 12, 15, 11, 42, 25, 82, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 51, DateTimeKind.Utc).AddTicks(5656), new DateTime(2025, 12, 15, 11, 42, 25, 51, DateTimeKind.Utc).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 51, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 12, 15, 11, 42, 25, 51, DateTimeKind.Utc).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 51, DateTimeKind.Utc).AddTicks(7248), new DateTime(2025, 12, 15, 11, 42, 25, 51, DateTimeKind.Utc).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 51, DateTimeKind.Utc).AddTicks(7402), new DateTime(2025, 12, 15, 11, 42, 25, 51, DateTimeKind.Utc).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 51, DateTimeKind.Utc).AddTicks(7407), new DateTime(2025, 12, 15, 11, 42, 25, 51, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 61, DateTimeKind.Utc).AddTicks(7873), new DateTime(2025, 12, 15, 11, 42, 25, 61, DateTimeKind.Utc).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 49, DateTimeKind.Utc).AddTicks(5074), new DateTime(2025, 12, 15, 11, 42, 25, 49, DateTimeKind.Utc).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 49, DateTimeKind.Utc).AddTicks(6086), new DateTime(2025, 12, 15, 11, 42, 25, 49, DateTimeKind.Utc).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 49, DateTimeKind.Utc).AddTicks(6197), new DateTime(2025, 12, 15, 11, 42, 25, 49, DateTimeKind.Utc).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 49, DateTimeKind.Utc).AddTicks(6292), new DateTime(2025, 12, 15, 11, 42, 25, 49, DateTimeKind.Utc).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 49, DateTimeKind.Utc).AddTicks(6299), new DateTime(2025, 12, 15, 11, 42, 25, 49, DateTimeKind.Utc).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 49, DateTimeKind.Utc).AddTicks(6305), new DateTime(2025, 12, 15, 11, 42, 25, 49, DateTimeKind.Utc).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "inspection_logs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 68, DateTimeKind.Utc).AddTicks(2280), new DateTime(2025, 12, 15, 11, 42, 25, 68, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "inspection_schedules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 66, DateTimeKind.Utc).AddTicks(8713), new DateTime(2025, 12, 15, 11, 42, 25, 66, DateTimeKind.Utc).AddTicks(8714), new DateTime(2025, 12, 17, 11, 42, 25, 66, DateTimeKind.Utc).AddTicks(9255), new DateTime(2025, 12, 16, 11, 42, 25, 66, DateTimeKind.Utc).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "inspection_team_members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 64, DateTimeKind.Utc).AddTicks(8353), new DateTime(2025, 12, 15, 11, 42, 25, 64, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "inspection_teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 63, DateTimeKind.Utc).AddTicks(5538), new DateTime(2025, 12, 15, 11, 42, 25, 63, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4083), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110101",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4610), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4612), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110105",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4612), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110106",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4613), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110107",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4617), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110108",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4617), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110109",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4618), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110111",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4619), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110112",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4620), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110113",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4620), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110114",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4621), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110115",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4622), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110116",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4622), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110117",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4623), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110118",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4624), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110119",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4624), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4626), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4677), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4678), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130200",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4680), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130202",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4680), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130300",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4681), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130302",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4694), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130400",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4695), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130402",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4696), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130500",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4697), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130502",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4697), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130600",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4698), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130606",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4699), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130700",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4699), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130702",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4700), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130800",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4700), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130802",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4702), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130900",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4704), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130902",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4704), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4705), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4705), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4706), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4707), new DateTime(2025, 12, 15, 11, 42, 24, 992, DateTimeKind.Utc).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 42, 25, 43, DateTimeKind.Local).AddTicks(2242), new DateTime(2025, 12, 15, 19, 42, 25, 43, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 42, 25, 43, DateTimeKind.Local).AddTicks(3154), new DateTime(2025, 12, 15, 19, 42, 25, 43, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 42, 25, 43, DateTimeKind.Local).AddTicks(3156), new DateTime(2025, 12, 15, 19, 42, 25, 43, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 42, 25, 43, DateTimeKind.Local).AddTicks(3158), new DateTime(2025, 12, 15, 19, 42, 25, 43, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 42, 25, 43, DateTimeKind.Local).AddTicks(3160), new DateTime(2025, 12, 15, 19, 42, 25, 43, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 42, 25, 43, DateTimeKind.Local).AddTicks(3164), new DateTime(2025, 12, 15, 19, 42, 25, 43, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 42, 25, 40, DateTimeKind.Local).AddTicks(4382), new DateTime(2025, 12, 15, 19, 42, 25, 42, DateTimeKind.Local).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 42, 25, 42, DateTimeKind.Local).AddTicks(1520), new DateTime(2025, 12, 15, 19, 42, 25, 42, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 42, 25, 42, DateTimeKind.Local).AddTicks(1523), new DateTime(2025, 12, 15, 19, 42, 25, 42, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(1809), new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(3069), new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6401), new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6424), new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6605), new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6615), new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10006L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6618), new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10007L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6621), new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10008L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6624), new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10009L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6629), new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10010L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6631), new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10011L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6633), new DateTime(2025, 12, 15, 11, 42, 25, 47, DateTimeKind.Utc).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 69, DateTimeKind.Utc).AddTicks(7610), new DateTime(2025, 12, 15, 11, 42, 25, 69, DateTimeKind.Utc).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000197001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(3387), new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000198001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(2466), new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105198501010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(3364), new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105199001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(3371), new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110108199003030001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(3384), new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100198502020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(3369), new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100199002020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(3374), new DateTime(2025, 12, 15, 11, 42, 25, 79, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "task_evidences",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 55, DateTimeKind.Utc).AddTicks(8090), new DateTime(2025, 12, 15, 11, 42, 25, 55, DateTimeKind.Utc).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 84, DateTimeKind.Utc).AddTicks(6799), new DateTime(2025, 12, 15, 11, 42, 25, 84, DateTimeKind.Utc).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 84, DateTimeKind.Utc).AddTicks(7445), new DateTime(2025, 12, 14, 11, 42, 25, 84, DateTimeKind.Utc).AddTicks(7447), new DateTime(2025, 12, 15, 11, 42, 25, 84, DateTimeKind.Utc).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 84, DateTimeKind.Utc).AddTicks(7659), new DateTime(2025, 12, 15, 11, 42, 25, 84, DateTimeKind.Utc).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 84, DateTimeKind.Utc).AddTicks(7661), new DateTime(2025, 12, 13, 11, 42, 25, 84, DateTimeKind.Utc).AddTicks(7662), new DateTime(2025, 12, 15, 11, 42, 25, 84, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 42, 25, 84, DateTimeKind.Utc).AddTicks(7663), new DateTime(2024, 12, 15, 11, 42, 25, 84, DateTimeKind.Utc).AddTicks(7664), new DateTime(2025, 12, 15, 11, 42, 25, 84, DateTimeKind.Utc).AddTicks(7663) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "batch_targets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BatchId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    OrgId = table.Column<string>(type: "longtext", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_batch_targets", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "review_allocations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AssignedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExpertId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NodeId = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_review_allocations", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ai_pre_evaluations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 377, DateTimeKind.Utc).AddTicks(1477), new DateTime(2025, 12, 15, 11, 26, 14, 377, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.InsertData(
                table: "batch_targets",
                columns: new[] { "Id", "BatchId", "CreatedAt", "IsDeleted", "OrgId", "UpdatedAt" },
                values: new object[,]
                {
                    { 20000L, 10000L, new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(8921), false, "110105_SPE_01", new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(8923) },
                    { 20001L, 10000L, new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9306), false, "110108_SPE_01", new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9306) },
                    { 20002L, 10000L, new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9307), false, "130100_SPE_01", new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9308) },
                    { 20003L, 10001L, new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9309), false, "110108_INC_01", new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9309) },
                    { 20004L, 10001L, new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9310), false, "130104_INC_01", new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9310) },
                    { 20005L, 10002L, new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9312), false, "110105_EDU", new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9312) },
                    { 20006L, 10002L, new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9313), false, "130100_EDU", new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9313) },
                    { 20007L, 10003L, new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9314), false, "130400_SPE_01", new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9314) }
                });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2163), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_OTH_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2904), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2881), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2899), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2891), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2883), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2900), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2893), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2885), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2887), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2894), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130102_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2896), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130104_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2901), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2890), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2898), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130402_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2903), new DateTime(2025, 12, 15, 11, 26, 14, 323, DateTimeKind.Utc).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(6737), new DateTime(2026, 1, 4, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7551), new DateTime(2025, 12, 5, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7443), new DateTime(2025, 12, 15, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7636), new DateTime(2026, 1, 19, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7639), new DateTime(2025, 12, 20, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7638), new DateTime(2025, 12, 15, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7640), new DateTime(2025, 12, 30, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7642), new DateTime(2025, 12, 13, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7641), new DateTime(2025, 12, 15, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7643), new DateTime(2025, 1, 14, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7695), new DateTime(2024, 12, 15, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7644), new DateTime(2025, 12, 15, 11, 26, 14, 397, DateTimeKind.Utc).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 371, DateTimeKind.Utc).AddTicks(8421), new DateTime(2025, 12, 15, 11, 26, 14, 371, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 371, DateTimeKind.Utc).AddTicks(9328), new DateTime(2025, 12, 15, 11, 26, 14, 371, DateTimeKind.Utc).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 371, DateTimeKind.Utc).AddTicks(9461), new DateTime(2025, 12, 15, 11, 26, 14, 371, DateTimeKind.Utc).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 371, DateTimeKind.Utc).AddTicks(9759), new DateTime(2025, 12, 15, 11, 26, 14, 371, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 371, DateTimeKind.Utc).AddTicks(9764), new DateTime(2025, 12, 15, 11, 26, 14, 371, DateTimeKind.Utc).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 381, DateTimeKind.Utc).AddTicks(4526), new DateTime(2025, 12, 15, 11, 26, 14, 381, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 370, DateTimeKind.Utc).AddTicks(2917), new DateTime(2025, 12, 15, 11, 26, 14, 370, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 370, DateTimeKind.Utc).AddTicks(3814), new DateTime(2025, 12, 15, 11, 26, 14, 370, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 370, DateTimeKind.Utc).AddTicks(3910), new DateTime(2025, 12, 15, 11, 26, 14, 370, DateTimeKind.Utc).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 370, DateTimeKind.Utc).AddTicks(4002), new DateTime(2025, 12, 15, 11, 26, 14, 370, DateTimeKind.Utc).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 370, DateTimeKind.Utc).AddTicks(4007), new DateTime(2025, 12, 15, 11, 26, 14, 370, DateTimeKind.Utc).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 370, DateTimeKind.Utc).AddTicks(4014), new DateTime(2025, 12, 15, 11, 26, 14, 370, DateTimeKind.Utc).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "inspection_logs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 386, DateTimeKind.Utc).AddTicks(5764), new DateTime(2025, 12, 15, 11, 26, 14, 386, DateTimeKind.Utc).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "inspection_schedules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 385, DateTimeKind.Utc).AddTicks(3112), new DateTime(2025, 12, 15, 11, 26, 14, 385, DateTimeKind.Utc).AddTicks(3114), new DateTime(2025, 12, 17, 11, 26, 14, 385, DateTimeKind.Utc).AddTicks(3645), new DateTime(2025, 12, 16, 11, 26, 14, 385, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "inspection_team_members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 383, DateTimeKind.Utc).AddTicks(5010), new DateTime(2025, 12, 15, 11, 26, 14, 383, DateTimeKind.Utc).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "inspection_teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 382, DateTimeKind.Utc).AddTicks(4649), new DateTime(2025, 12, 15, 11, 26, 14, 382, DateTimeKind.Utc).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9135), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110101",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9677), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9679), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110105",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9679), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110106",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9680), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110107",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9683), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110108",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9684), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110109",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9685), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110111",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9686), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110112",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9687), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110113",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9688), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110114",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9688), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110115",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9689), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110116",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9690), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110117",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9690), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110118",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9691), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110119",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9691), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9693), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9742), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9743), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130200",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9745), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130202",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9745), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130300",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9746), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130302",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9747), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130400",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9747), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130402",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9748), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130500",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9749), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130502",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9749), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130600",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9750), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130606",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9753), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130700",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9754), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130702",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9755), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130800",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9756), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130802",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9758), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130900",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9760), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130902",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9760), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9761), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9762), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9762), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9763), new DateTime(2025, 12, 15, 11, 26, 14, 319, DateTimeKind.Utc).AddTicks(9763) });

            migrationBuilder.InsertData(
                table: "review_allocations",
                columns: new[] { "Id", "AssignedAt", "CreatedAt", "ExpertId", "IsDeleted", "NodeId", "Status", "TaskId", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2025, 12, 15, 11, 26, 14, 379, DateTimeKind.Utc).AddTicks(984), new DateTime(2025, 12, 15, 11, 26, 14, 379, DateTimeKind.Utc).AddTicks(463), 100L, false, 3L, 0, 1L, new DateTime(2025, 12, 15, 11, 26, 14, 379, DateTimeKind.Utc).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 26, 14, 365, DateTimeKind.Local).AddTicks(549), new DateTime(2025, 12, 15, 19, 26, 14, 365, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 26, 14, 365, DateTimeKind.Local).AddTicks(1398), new DateTime(2025, 12, 15, 19, 26, 14, 365, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 26, 14, 365, DateTimeKind.Local).AddTicks(1400), new DateTime(2025, 12, 15, 19, 26, 14, 365, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 26, 14, 365, DateTimeKind.Local).AddTicks(1402), new DateTime(2025, 12, 15, 19, 26, 14, 365, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 26, 14, 365, DateTimeKind.Local).AddTicks(1404), new DateTime(2025, 12, 15, 19, 26, 14, 365, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 26, 14, 365, DateTimeKind.Local).AddTicks(1408), new DateTime(2025, 12, 15, 19, 26, 14, 365, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 26, 14, 362, DateTimeKind.Local).AddTicks(7564), new DateTime(2025, 12, 15, 19, 26, 14, 364, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 26, 14, 364, DateTimeKind.Local).AddTicks(1387), new DateTime(2025, 12, 15, 19, 26, 14, 364, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 26, 14, 364, DateTimeKind.Local).AddTicks(1389), new DateTime(2025, 12, 15, 19, 26, 14, 364, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(2826), new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(4026), new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7299), new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7329), new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7503), new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7515), new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10006L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7519), new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10007L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7523), new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10008L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7527), new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10009L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7532), new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10010L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7535), new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10011L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7537), new DateTime(2025, 12, 15, 11, 26, 14, 368, DateTimeKind.Utc).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 387, DateTimeKind.Utc).AddTicks(8429), new DateTime(2025, 12, 15, 11, 26, 14, 387, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000197001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(5738), new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000198001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(4777), new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105198501010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(5724), new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105199001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(5729), new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110108199003030001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(5736), new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100198502020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(5727), new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100199002020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(5730), new DateTime(2025, 12, 15, 11, 26, 14, 395, DateTimeKind.Utc).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "task_evidences",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 375, DateTimeKind.Utc).AddTicks(9249), new DateTime(2025, 12, 15, 11, 26, 14, 375, DateTimeKind.Utc).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 400, DateTimeKind.Utc).AddTicks(9162), new DateTime(2025, 12, 15, 11, 26, 14, 400, DateTimeKind.Utc).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 400, DateTimeKind.Utc).AddTicks(9888), new DateTime(2025, 12, 14, 11, 26, 14, 400, DateTimeKind.Utc).AddTicks(9890), new DateTime(2025, 12, 15, 11, 26, 14, 400, DateTimeKind.Utc).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 401, DateTimeKind.Utc).AddTicks(86), new DateTime(2025, 12, 15, 11, 26, 14, 401, DateTimeKind.Utc).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 401, DateTimeKind.Utc).AddTicks(88), new DateTime(2025, 12, 13, 11, 26, 14, 401, DateTimeKind.Utc).AddTicks(90), new DateTime(2025, 12, 15, 11, 26, 14, 401, DateTimeKind.Utc).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 401, DateTimeKind.Utc).AddTicks(91), new DateTime(2024, 12, 15, 11, 26, 14, 401, DateTimeKind.Utc).AddTicks(92), new DateTime(2025, 12, 15, 11, 26, 14, 401, DateTimeKind.Utc).AddTicks(91) });

            migrationBuilder.CreateIndex(
                name: "IX_batch_targets_BatchId",
                table: "batch_targets",
                column: "BatchId");
        }
    }
}
