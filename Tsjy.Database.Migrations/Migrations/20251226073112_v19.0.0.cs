using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tsjy.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v1900 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "StandardScore",
                table: "expert_reviews",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "StandardScore",
                table: "expert_reviews",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ai_pre_evaluations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 826, DateTimeKind.Utc).AddTicks(8898), new DateTime(2025, 12, 15, 13, 14, 30, 826, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(1775), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_OTH_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2532), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2509), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2527), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2520), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2512), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2528), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2521), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2513), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2515), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2522), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130102_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2524), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130104_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2529), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2526), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130402_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2531), new DateTime(2025, 12, 15, 13, 14, 30, 773, DateTimeKind.Utc).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(7529), new DateTime(2026, 1, 4, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8140), new DateTime(2025, 12, 5, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8036), new DateTime(2025, 12, 15, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8226), new DateTime(2026, 1, 19, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8229), new DateTime(2025, 12, 20, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8228), new DateTime(2025, 12, 15, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8282), new DateTime(2025, 12, 30, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8283), new DateTime(2025, 12, 13, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8283), new DateTime(2025, 12, 15, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8285), new DateTime(2025, 1, 14, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8326), new DateTime(2024, 12, 15, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8286), new DateTime(2025, 12, 15, 13, 14, 30, 846, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 821, DateTimeKind.Utc).AddTicks(8667), new DateTime(2025, 12, 15, 13, 14, 30, 821, DateTimeKind.Utc).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 821, DateTimeKind.Utc).AddTicks(9664), new DateTime(2025, 12, 15, 13, 14, 30, 821, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 821, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 12, 15, 13, 14, 30, 821, DateTimeKind.Utc).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 821, DateTimeKind.Utc).AddTicks(9856), new DateTime(2025, 12, 15, 13, 14, 30, 821, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 821, DateTimeKind.Utc).AddTicks(9860), new DateTime(2025, 12, 15, 13, 14, 30, 821, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 830, DateTimeKind.Utc).AddTicks(216), new DateTime(2025, 12, 15, 13, 14, 30, 829, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 820, DateTimeKind.Utc).AddTicks(1907), new DateTime(2025, 12, 15, 13, 14, 30, 820, DateTimeKind.Utc).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 820, DateTimeKind.Utc).AddTicks(2879), new DateTime(2025, 12, 15, 13, 14, 30, 820, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 820, DateTimeKind.Utc).AddTicks(3236), new DateTime(2025, 12, 15, 13, 14, 30, 820, DateTimeKind.Utc).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 820, DateTimeKind.Utc).AddTicks(3328), new DateTime(2025, 12, 15, 13, 14, 30, 820, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 820, DateTimeKind.Utc).AddTicks(3334), new DateTime(2025, 12, 15, 13, 14, 30, 820, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 820, DateTimeKind.Utc).AddTicks(3344), new DateTime(2025, 12, 15, 13, 14, 30, 820, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "inspection_logs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 835, DateTimeKind.Utc).AddTicks(2222), new DateTime(2025, 12, 15, 13, 14, 30, 835, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "inspection_schedules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 833, DateTimeKind.Utc).AddTicks(6742), new DateTime(2025, 12, 15, 13, 14, 30, 833, DateTimeKind.Utc).AddTicks(6743), new DateTime(2025, 12, 17, 13, 14, 30, 833, DateTimeKind.Utc).AddTicks(7365), new DateTime(2025, 12, 16, 13, 14, 30, 833, DateTimeKind.Utc).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "inspection_team_members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 831, DateTimeKind.Utc).AddTicks(8362), new DateTime(2025, 12, 15, 13, 14, 30, 831, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "inspection_teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 830, DateTimeKind.Utc).AddTicks(9431), new DateTime(2025, 12, 15, 13, 14, 30, 830, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(5365), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110101",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6003), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6005), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110105",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6006), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110106",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6006), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110107",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6016), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110108",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6017), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110109",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6018), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110111",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6018), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110112",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6020), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110113",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6021), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110114",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6021), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110115",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6022), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110116",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6023), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110117",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6023), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110118",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6024), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110119",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6024), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6026), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6087), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6088), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130200",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6090), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130202",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6090), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130300",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6091), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130302",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6092), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130400",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6092), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130402",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6093), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130500",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6093), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130502",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6094), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130600",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6095), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130606",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6095), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130700",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6096), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130702",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6096), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130800",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6097), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130802",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6113), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130900",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6113), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130902",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6114), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6115), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6115), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6116), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6116), new DateTime(2025, 12, 15, 13, 14, 30, 768, DateTimeKind.Utc).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 21, 14, 30, 815, DateTimeKind.Local).AddTicks(2685), new DateTime(2025, 12, 15, 21, 14, 30, 815, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 21, 14, 30, 815, DateTimeKind.Local).AddTicks(3556), new DateTime(2025, 12, 15, 21, 14, 30, 815, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 21, 14, 30, 815, DateTimeKind.Local).AddTicks(3559), new DateTime(2025, 12, 15, 21, 14, 30, 815, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 21, 14, 30, 815, DateTimeKind.Local).AddTicks(3561), new DateTime(2025, 12, 15, 21, 14, 30, 815, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 21, 14, 30, 815, DateTimeKind.Local).AddTicks(3562), new DateTime(2025, 12, 15, 21, 14, 30, 815, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 21, 14, 30, 815, DateTimeKind.Local).AddTicks(3566), new DateTime(2025, 12, 15, 21, 14, 30, 815, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 21, 14, 30, 812, DateTimeKind.Local).AddTicks(9129), new DateTime(2025, 12, 15, 21, 14, 30, 814, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 21, 14, 30, 814, DateTimeKind.Local).AddTicks(3738), new DateTime(2025, 12, 15, 21, 14, 30, 814, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 21, 14, 30, 814, DateTimeKind.Local).AddTicks(3740), new DateTime(2025, 12, 15, 21, 14, 30, 814, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(1389), new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(2599), new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(5632), new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(5651), new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6054), new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6063), new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10006L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6066), new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10007L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6069), new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10008L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6073), new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10009L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10010L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6079), new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10011L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6082), new DateTime(2025, 12, 15, 13, 14, 30, 818, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 836, DateTimeKind.Utc).AddTicks(5205), new DateTime(2025, 12, 15, 13, 14, 30, 836, DateTimeKind.Utc).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000197001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(2157), new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000198001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(1230), new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105198501010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(2142), new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105199001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(2147), new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110108199003030001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(2155), new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100198502020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(2145), new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100199002020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(2149), new DateTime(2025, 12, 15, 13, 14, 30, 844, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "task_evidences",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 825, DateTimeKind.Utc).AddTicks(7688), new DateTime(2025, 12, 15, 13, 14, 30, 825, DateTimeKind.Utc).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 848, DateTimeKind.Utc).AddTicks(8770), new DateTime(2025, 12, 15, 13, 14, 30, 848, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 849, DateTimeKind.Utc).AddTicks(764), new DateTime(2025, 12, 14, 13, 14, 30, 849, DateTimeKind.Utc).AddTicks(768), new DateTime(2025, 12, 15, 13, 14, 30, 849, DateTimeKind.Utc).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 849, DateTimeKind.Utc).AddTicks(1012), new DateTime(2025, 12, 15, 13, 14, 30, 849, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 849, DateTimeKind.Utc).AddTicks(1014), new DateTime(2025, 12, 13, 13, 14, 30, 849, DateTimeKind.Utc).AddTicks(1015), new DateTime(2025, 12, 15, 13, 14, 30, 849, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 849, DateTimeKind.Utc).AddTicks(1016), new DateTime(2024, 12, 15, 13, 14, 30, 849, DateTimeKind.Utc).AddTicks(1018), new DateTime(2025, 12, 15, 13, 14, 30, 849, DateTimeKind.Utc).AddTicks(1017) });
        }
    }
}
