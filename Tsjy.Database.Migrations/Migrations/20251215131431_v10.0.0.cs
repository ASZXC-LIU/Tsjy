using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Tsjy.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v1000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sys_user");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "inspection_team_members",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ReviewerId",
                table: "expert_reviews",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

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
                columns: new[] { "CreatedAt", "ReviewerId", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 830, DateTimeKind.Utc).AddTicks(216), "100", new DateTime(2025, 12, 15, 13, 14, 30, 829, DateTimeKind.Utc).AddTicks(9403) });

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
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 14, 30, 831, DateTimeKind.Utc).AddTicks(8362), new DateTime(2025, 12, 15, 13, 14, 30, 831, DateTimeKind.Utc).AddTicks(7854), "100" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "inspection_team_members",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ReviewerId",
                table: "expert_reviews",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "sys_user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Account = table.Column<string>(type: "longtext", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    OrgId = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false),
                    Phone = table.Column<string>(type: "longtext", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    User_type = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_user", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ai_pre_evaluations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 501, DateTimeKind.Utc).AddTicks(9778), new DateTime(2025, 12, 15, 12, 46, 52, 501, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(7894), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_OTH_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8674), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8653), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8670), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8663), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8655), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8671), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8665), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8656), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8658), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8666), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130102_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8667), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130104_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8672), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8669), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130402_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8673), new DateTime(2025, 12, 15, 12, 46, 52, 441, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(2873), new DateTime(2026, 1, 4, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3438), new DateTime(2025, 12, 5, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3339), new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3520), new DateTime(2026, 1, 19, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3522), new DateTime(2025, 12, 20, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3521), new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3523), new DateTime(2025, 12, 30, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3525), new DateTime(2025, 12, 13, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3524), new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 1, 14, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3564), new DateTime(2024, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3527), new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 496, DateTimeKind.Utc).AddTicks(3059), new DateTime(2025, 12, 15, 12, 46, 52, 496, DateTimeKind.Utc).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 496, DateTimeKind.Utc).AddTicks(4172), new DateTime(2025, 12, 15, 12, 46, 52, 496, DateTimeKind.Utc).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 496, DateTimeKind.Utc).AddTicks(4285), new DateTime(2025, 12, 15, 12, 46, 52, 496, DateTimeKind.Utc).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 496, DateTimeKind.Utc).AddTicks(4409), new DateTime(2025, 12, 15, 12, 46, 52, 496, DateTimeKind.Utc).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 496, DateTimeKind.Utc).AddTicks(4414), new DateTime(2025, 12, 15, 12, 46, 52, 496, DateTimeKind.Utc).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ReviewerId", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 504, DateTimeKind.Utc).AddTicks(9652), 100L, new DateTime(2025, 12, 15, 12, 46, 52, 504, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 493, DateTimeKind.Utc).AddTicks(6695), new DateTime(2025, 12, 15, 12, 46, 52, 493, DateTimeKind.Utc).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 493, DateTimeKind.Utc).AddTicks(7888), new DateTime(2025, 12, 15, 12, 46, 52, 493, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 493, DateTimeKind.Utc).AddTicks(8024), new DateTime(2025, 12, 15, 12, 46, 52, 493, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 493, DateTimeKind.Utc).AddTicks(8113), new DateTime(2025, 12, 15, 12, 46, 52, 493, DateTimeKind.Utc).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 493, DateTimeKind.Utc).AddTicks(8117), new DateTime(2025, 12, 15, 12, 46, 52, 493, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 493, DateTimeKind.Utc).AddTicks(8123), new DateTime(2025, 12, 15, 12, 46, 52, 493, DateTimeKind.Utc).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "inspection_logs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 509, DateTimeKind.Utc).AddTicks(8100), new DateTime(2025, 12, 15, 12, 46, 52, 509, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "inspection_schedules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 508, DateTimeKind.Utc).AddTicks(4981), new DateTime(2025, 12, 15, 12, 46, 52, 508, DateTimeKind.Utc).AddTicks(4982), new DateTime(2025, 12, 17, 12, 46, 52, 508, DateTimeKind.Utc).AddTicks(5490), new DateTime(2025, 12, 16, 12, 46, 52, 508, DateTimeKind.Utc).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "inspection_team_members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 506, DateTimeKind.Utc).AddTicks(7564), new DateTime(2025, 12, 15, 12, 46, 52, 506, DateTimeKind.Utc).AddTicks(7177), 100L });

            migrationBuilder.UpdateData(
                table: "inspection_teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 505, DateTimeKind.Utc).AddTicks(8779), new DateTime(2025, 12, 15, 12, 46, 52, 505, DateTimeKind.Utc).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 437, DateTimeKind.Utc).AddTicks(9801), new DateTime(2025, 12, 15, 12, 46, 52, 437, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110101",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(294), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(296), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110105",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(297), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110106",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(297), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110107",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(301), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110108",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(302), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110109",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(302), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110111",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(303), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110112",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(304), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110113",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(305), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110114",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(306), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110115",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(306), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110116",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(307), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110117",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(308), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110118",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(308), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110119",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(309), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(310), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(356), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(357), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130200",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(358), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130202",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(359), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130300",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(360), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130302",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(360), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130400",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(361), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130402",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(361), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130500",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(362), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130502",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(363), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130600",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(363), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130606",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(364), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130700",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(364), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130702",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(365), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130800",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(365), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130802",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(377), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130900",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(378), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130902",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(378), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(379), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(380), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(380), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(381), new DateTime(2025, 12, 15, 12, 46, 52, 438, DateTimeKind.Utc).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 20, 46, 52, 488, DateTimeKind.Local).AddTicks(4607), new DateTime(2025, 12, 15, 20, 46, 52, 488, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 20, 46, 52, 488, DateTimeKind.Local).AddTicks(5457), new DateTime(2025, 12, 15, 20, 46, 52, 488, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 20, 46, 52, 488, DateTimeKind.Local).AddTicks(5469), new DateTime(2025, 12, 15, 20, 46, 52, 488, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 20, 46, 52, 488, DateTimeKind.Local).AddTicks(5471), new DateTime(2025, 12, 15, 20, 46, 52, 488, DateTimeKind.Local).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 20, 46, 52, 488, DateTimeKind.Local).AddTicks(5472), new DateTime(2025, 12, 15, 20, 46, 52, 488, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 20, 46, 52, 488, DateTimeKind.Local).AddTicks(5476), new DateTime(2025, 12, 15, 20, 46, 52, 488, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 20, 46, 52, 486, DateTimeKind.Local).AddTicks(1255), new DateTime(2025, 12, 15, 20, 46, 52, 487, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 20, 46, 52, 487, DateTimeKind.Local).AddTicks(5816), new DateTime(2025, 12, 15, 20, 46, 52, 487, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 20, 46, 52, 487, DateTimeKind.Local).AddTicks(5819), new DateTime(2025, 12, 15, 20, 46, 52, 487, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(4772), new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(5868), new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9242), new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9268), new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9434), new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9443), new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10006L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9446), new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10007L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9449), new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10008L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9452), new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10009L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9456), new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10010L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9458), new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10011L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9460), new DateTime(2025, 12, 15, 12, 46, 52, 491, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 511, DateTimeKind.Utc).AddTicks(5316), new DateTime(2025, 12, 15, 12, 46, 52, 511, DateTimeKind.Utc).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000197001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(3503), new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000198001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(5), new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105198501010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(3487), new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105199001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(3493), new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110108199003030001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(3501), new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100198502020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(3491), new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100199002020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(3495), new DateTime(2025, 12, 15, 12, 46, 52, 520, DateTimeKind.Utc).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "task_evidences",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 500, DateTimeKind.Utc).AddTicks(8069), new DateTime(2025, 12, 15, 12, 46, 52, 500, DateTimeKind.Utc).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 526, DateTimeKind.Utc).AddTicks(3992), new DateTime(2025, 12, 15, 12, 46, 52, 526, DateTimeKind.Utc).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 526, DateTimeKind.Utc).AddTicks(4612), new DateTime(2025, 12, 14, 12, 46, 52, 526, DateTimeKind.Utc).AddTicks(4614), new DateTime(2025, 12, 15, 12, 46, 52, 526, DateTimeKind.Utc).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 526, DateTimeKind.Utc).AddTicks(4823), new DateTime(2025, 12, 15, 12, 46, 52, 526, DateTimeKind.Utc).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 526, DateTimeKind.Utc).AddTicks(4825), new DateTime(2025, 12, 13, 12, 46, 52, 526, DateTimeKind.Utc).AddTicks(4826), new DateTime(2025, 12, 15, 12, 46, 52, 526, DateTimeKind.Utc).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 526, DateTimeKind.Utc).AddTicks(4827), new DateTime(2024, 12, 15, 12, 46, 52, 526, DateTimeKind.Utc).AddTicks(4828), new DateTime(2025, 12, 15, 12, 46, 52, 526, DateTimeKind.Utc).AddTicks(4827) });
        }
    }
}
