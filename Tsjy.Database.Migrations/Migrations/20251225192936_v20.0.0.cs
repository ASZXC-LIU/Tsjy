using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Tsjy.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v2000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inspection_logs");

            migrationBuilder.DropTable(
                name: "inspection_schedules");

            migrationBuilder.DropTable(
                name: "inspection_team_members");

            migrationBuilder.DropTable(
                name: "inspection_teams");

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
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 260, DateTimeKind.Utc).AddTicks(4959), new DateTime(2025, 12, 25, 19, 29, 36, 260, DateTimeKind.Utc).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(3324), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_OTH_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4054), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4032), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4049), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4042), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4034), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4050), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4043), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4035), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4037), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4045), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130102_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4047), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130104_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4052), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4041), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4048), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130402_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4053), new DateTime(2025, 12, 25, 19, 29, 36, 203, DateTimeKind.Utc).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(414), new DateTime(2026, 1, 14, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(1081), new DateTime(2025, 12, 15, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(888), new DateTime(2025, 12, 25, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(1167), new DateTime(2026, 1, 29, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(1170), new DateTime(2025, 12, 30, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(1169), new DateTime(2025, 12, 25, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(1171), new DateTime(2026, 1, 9, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(1172), new DateTime(2025, 12, 23, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(1172), new DateTime(2025, 12, 25, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(1173), new DateTime(2025, 1, 24, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 12, 25, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(1174), new DateTime(2025, 12, 25, 19, 29, 36, 273, DateTimeKind.Utc).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 255, DateTimeKind.Utc).AddTicks(3346), new DateTime(2025, 12, 25, 19, 29, 36, 255, DateTimeKind.Utc).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 255, DateTimeKind.Utc).AddTicks(4238), new DateTime(2025, 12, 25, 19, 29, 36, 255, DateTimeKind.Utc).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 255, DateTimeKind.Utc).AddTicks(4332), new DateTime(2025, 12, 25, 19, 29, 36, 255, DateTimeKind.Utc).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 255, DateTimeKind.Utc).AddTicks(4423), new DateTime(2025, 12, 25, 19, 29, 36, 255, DateTimeKind.Utc).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 255, DateTimeKind.Utc).AddTicks(4427), new DateTime(2025, 12, 25, 19, 29, 36, 255, DateTimeKind.Utc).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 263, DateTimeKind.Utc).AddTicks(4429), new DateTime(2025, 12, 25, 19, 29, 36, 263, DateTimeKind.Utc).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 253, DateTimeKind.Utc).AddTicks(8656), new DateTime(2025, 12, 25, 19, 29, 36, 253, DateTimeKind.Utc).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 253, DateTimeKind.Utc).AddTicks(9589), new DateTime(2025, 12, 25, 19, 29, 36, 253, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 253, DateTimeKind.Utc).AddTicks(9688), new DateTime(2025, 12, 25, 19, 29, 36, 253, DateTimeKind.Utc).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 253, DateTimeKind.Utc).AddTicks(9779), new DateTime(2025, 12, 25, 19, 29, 36, 253, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 253, DateTimeKind.Utc).AddTicks(9784), new DateTime(2025, 12, 25, 19, 29, 36, 253, DateTimeKind.Utc).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 253, DateTimeKind.Utc).AddTicks(9789), new DateTime(2025, 12, 25, 19, 29, 36, 253, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(7497), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110101",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8083), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8085), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110105",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8085), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110106",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8086), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110107",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8092), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110108",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8093), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110109",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8093), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110111",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8094), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110112",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8095), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110113",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8096), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110114",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8097), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110115",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8097), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110116",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8098), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110117",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8098), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110118",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8099), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110119",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8100), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8111), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8163), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8164), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130200",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8166), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130202",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8166), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130300",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8167), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130302",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8168), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130400",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8168), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130402",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8169), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130500",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8169), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130502",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8170), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130600",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8171), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130606",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8171), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130700",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8172), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130702",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8173), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130800",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8173), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130802",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8176), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130900",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8177), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130902",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8178), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8178), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8179), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8180), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8180), new DateTime(2025, 12, 25, 19, 29, 36, 199, DateTimeKind.Utc).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 3, 29, 36, 248, DateTimeKind.Local).AddTicks(9404), new DateTime(2025, 12, 26, 3, 29, 36, 248, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 3, 29, 36, 249, DateTimeKind.Local).AddTicks(131), new DateTime(2025, 12, 26, 3, 29, 36, 249, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 3, 29, 36, 249, DateTimeKind.Local).AddTicks(133), new DateTime(2025, 12, 26, 3, 29, 36, 249, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 3, 29, 36, 249, DateTimeKind.Local).AddTicks(135), new DateTime(2025, 12, 26, 3, 29, 36, 249, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 3, 29, 36, 249, DateTimeKind.Local).AddTicks(136), new DateTime(2025, 12, 26, 3, 29, 36, 249, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 3, 29, 36, 249, DateTimeKind.Local).AddTicks(139), new DateTime(2025, 12, 26, 3, 29, 36, 249, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 3, 29, 36, 245, DateTimeKind.Local).AddTicks(9331), new DateTime(2025, 12, 26, 3, 29, 36, 248, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 3, 29, 36, 248, DateTimeKind.Local).AddTicks(998), new DateTime(2025, 12, 26, 3, 29, 36, 248, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 26, 3, 29, 36, 248, DateTimeKind.Local).AddTicks(1001), new DateTime(2025, 12, 26, 3, 29, 36, 248, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(4183), new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(5277), new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8048), new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8065), new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8233), new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8240), new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10006L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8244), new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10007L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8247), new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10008L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8250), new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10009L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8254), new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10010L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8256), new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10011L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8259), new DateTime(2025, 12, 25, 19, 29, 36, 251, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 264, DateTimeKind.Utc).AddTicks(5905), new DateTime(2025, 12, 25, 19, 29, 36, 264, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000197001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(8498), new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000198001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(7666), new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105198501010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(8484), new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105199001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(8489), new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110108199003030001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(8497), new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100198502020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(8487), new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100199002020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(8490), new DateTime(2025, 12, 25, 19, 29, 36, 270, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "task_evidences",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 259, DateTimeKind.Utc).AddTicks(2910), new DateTime(2025, 12, 25, 19, 29, 36, 259, DateTimeKind.Utc).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 275, DateTimeKind.Utc).AddTicks(1652), new DateTime(2025, 12, 25, 19, 29, 36, 275, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 275, DateTimeKind.Utc).AddTicks(2272), new DateTime(2025, 12, 24, 19, 29, 36, 275, DateTimeKind.Utc).AddTicks(2274), new DateTime(2025, 12, 25, 19, 29, 36, 275, DateTimeKind.Utc).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 275, DateTimeKind.Utc).AddTicks(2464), new DateTime(2025, 12, 25, 19, 29, 36, 275, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 275, DateTimeKind.Utc).AddTicks(2466), new DateTime(2025, 12, 23, 19, 29, 36, 275, DateTimeKind.Utc).AddTicks(2467), new DateTime(2025, 12, 25, 19, 29, 36, 275, DateTimeKind.Utc).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 25, 19, 29, 36, 275, DateTimeKind.Utc).AddTicks(2468), new DateTime(2024, 12, 25, 19, 29, 36, 275, DateTimeKind.Utc).AddTicks(2469), new DateTime(2025, 12, 25, 19, 29, 36, 275, DateTimeKind.Utc).AddTicks(2468) });
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

            migrationBuilder.CreateTable(
                name: "inspection_logs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    EvidenceFiles = table.Column<string>(type: "json", nullable: true),
                    Findings = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NodeId = table.Column<long>(type: "bigint", nullable: false),
                    ScheduleId = table.Column<long>(type: "bigint", nullable: false),
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
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    VisitEndAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    VisitStartAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<string>(type: "longtext", nullable: true)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inspection_teams", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

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

            migrationBuilder.InsertData(
                table: "inspection_logs",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EvidenceFiles", "Findings", "IsDeleted", "NodeId", "ScheduleId", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2025, 12, 15, 13, 14, 30, 835, DateTimeKind.Utc).AddTicks(2222), 100L, "[\"photo1.jpg\"]", "现场查看符合要求", false, 3L, 1L, new DateTime(2025, 12, 15, 13, 14, 30, 835, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.InsertData(
                table: "inspection_schedules",
                columns: new[] { "Id", "AssignmentId", "CreatedAt", "IsDeleted", "Status", "TeamId", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { 1L, 1L, new DateTime(2025, 12, 15, 13, 14, 30, 833, DateTimeKind.Utc).AddTicks(6742), false, 0, 1L, new DateTime(2025, 12, 15, 13, 14, 30, 833, DateTimeKind.Utc).AddTicks(6743), new DateTime(2025, 12, 17, 13, 14, 30, 833, DateTimeKind.Utc).AddTicks(7365), new DateTime(2025, 12, 16, 13, 14, 30, 833, DateTimeKind.Utc).AddTicks(7187) });

            migrationBuilder.InsertData(
                table: "inspection_team_members",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "TeamId", "UpdatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2025, 12, 15, 13, 14, 30, 831, DateTimeKind.Utc).AddTicks(8362), false, 1L, new DateTime(2025, 12, 15, 13, 14, 30, 831, DateTimeKind.Utc).AddTicks(7854), "100" });

            migrationBuilder.InsertData(
                table: "inspection_teams",
                columns: new[] { "Id", "BatchId", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { 1L, 1L, new DateTime(2025, 12, 15, 13, 14, 30, 830, DateTimeKind.Utc).AddTicks(9431), false, "第一视导组", new DateTime(2025, 12, 15, 13, 14, 30, 830, DateTimeKind.Utc).AddTicks(9052) });

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
