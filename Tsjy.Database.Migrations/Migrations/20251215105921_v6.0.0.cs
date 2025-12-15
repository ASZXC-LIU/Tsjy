using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tsjy.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v600 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ScoreRatio",
                table: "expert_reviews",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinalScore",
                table: "expert_reviews",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "expert_reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ai_pre_evaluations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 266, DateTimeKind.Utc).AddTicks(6799), new DateTime(2025, 12, 15, 10, 59, 21, 266, DateTimeKind.Utc).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3160), new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3532), new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3533), new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3534), new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3535), new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3538), new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20006L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3539), new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20007L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3540), new DateTime(2025, 12, 15, 10, 59, 21, 288, DateTimeKind.Utc).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(571), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_OTH_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1353), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1331), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1348), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1342), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1333), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1349), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1343), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1334), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1336), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1344), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130102_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1346), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130104_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1351), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1341), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1347), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130402_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1352), new DateTime(2025, 12, 15, 10, 59, 21, 206, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3130), new DateTime(2026, 1, 4, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3735), new DateTime(2025, 12, 5, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3576), 2, new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3814), new DateTime(2026, 1, 19, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3816), new DateTime(2025, 12, 20, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3815), new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3817), new DateTime(2025, 12, 30, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3818), new DateTime(2025, 12, 13, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3818), 2, new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3819), new DateTime(2025, 1, 14, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3855), new DateTime(2024, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3820), 3, new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 261, DateTimeKind.Utc).AddTicks(7050), new DateTime(2025, 12, 15, 10, 59, 21, 261, DateTimeKind.Utc).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 261, DateTimeKind.Utc).AddTicks(7953), new DateTime(2025, 12, 15, 10, 59, 21, 261, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 261, DateTimeKind.Utc).AddTicks(8109), new DateTime(2025, 12, 15, 10, 59, 21, 261, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 261, DateTimeKind.Utc).AddTicks(8437), new DateTime(2025, 12, 15, 10, 59, 21, 261, DateTimeKind.Utc).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 261, DateTimeKind.Utc).AddTicks(8443), new DateTime(2025, 12, 15, 10, 59, 21, 261, DateTimeKind.Utc).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 269, DateTimeKind.Utc).AddTicks(6503), 0, new DateTime(2025, 12, 15, 10, 59, 21, 269, DateTimeKind.Utc).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 260, DateTimeKind.Utc).AddTicks(1235), new DateTime(2025, 12, 15, 10, 59, 21, 260, DateTimeKind.Utc).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 260, DateTimeKind.Utc).AddTicks(2205), new DateTime(2025, 12, 15, 10, 59, 21, 260, DateTimeKind.Utc).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 260, DateTimeKind.Utc).AddTicks(2313), new DateTime(2025, 12, 15, 10, 59, 21, 260, DateTimeKind.Utc).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 260, DateTimeKind.Utc).AddTicks(2410), new DateTime(2025, 12, 15, 10, 59, 21, 260, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 260, DateTimeKind.Utc).AddTicks(2414), new DateTime(2025, 12, 15, 10, 59, 21, 260, DateTimeKind.Utc).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 260, DateTimeKind.Utc).AddTicks(2419), new DateTime(2025, 12, 15, 10, 59, 21, 260, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "inspection_logs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 275, DateTimeKind.Utc).AddTicks(2288), new DateTime(2025, 12, 15, 10, 59, 21, 275, DateTimeKind.Utc).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "inspection_schedules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 273, DateTimeKind.Utc).AddTicks(8206), new DateTime(2025, 12, 15, 10, 59, 21, 273, DateTimeKind.Utc).AddTicks(8207), new DateTime(2025, 12, 17, 10, 59, 21, 274, DateTimeKind.Utc).AddTicks(743), new DateTime(2025, 12, 16, 10, 59, 21, 274, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "inspection_team_members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 271, DateTimeKind.Utc).AddTicks(6450), new DateTime(2025, 12, 15, 10, 59, 21, 271, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "inspection_teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 270, DateTimeKind.Utc).AddTicks(5535), new DateTime(2025, 12, 15, 10, 59, 21, 270, DateTimeKind.Utc).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 199, DateTimeKind.Utc).AddTicks(9500), new DateTime(2025, 12, 15, 10, 59, 21, 199, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110101",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(70), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(72), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110105",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(73), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110106",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(74), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110107",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(78), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110108",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(79), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110109",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(80), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110111",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(80), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110112",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(82), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110113",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(82), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110114",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(83), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110115",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(84), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110116",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(84), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110117",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(85), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110118",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(86), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110119",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(86), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(88), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(154), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(155), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130200",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(157), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130202",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(157), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130300",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(158), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130302",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(158), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130400",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(159), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130402",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(160), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130500",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(160), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130502",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(161), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130600",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(161), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130606",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(162), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130700",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(163), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130702",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(163), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130800",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(164), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130802",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(166), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130900",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(168), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130902",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(168), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(169), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(170), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(170), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(171), new DateTime(2025, 12, 15, 10, 59, 21, 200, DateTimeKind.Utc).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "review_allocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AssignedAt", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 268, DateTimeKind.Utc).AddTicks(4705), new DateTime(2025, 12, 15, 10, 59, 21, 268, DateTimeKind.Utc).AddTicks(4170), new DateTime(2025, 12, 15, 10, 59, 21, 268, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 18, 59, 21, 255, DateTimeKind.Local).AddTicks(3251), new DateTime(2025, 12, 15, 18, 59, 21, 255, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 18, 59, 21, 255, DateTimeKind.Local).AddTicks(3991), new DateTime(2025, 12, 15, 18, 59, 21, 255, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 18, 59, 21, 255, DateTimeKind.Local).AddTicks(3993), new DateTime(2025, 12, 15, 18, 59, 21, 255, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 18, 59, 21, 255, DateTimeKind.Local).AddTicks(3995), new DateTime(2025, 12, 15, 18, 59, 21, 255, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 18, 59, 21, 255, DateTimeKind.Local).AddTicks(3997), new DateTime(2025, 12, 15, 18, 59, 21, 255, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 18, 59, 21, 255, DateTimeKind.Local).AddTicks(4001), new DateTime(2025, 12, 15, 18, 59, 21, 255, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 18, 59, 21, 253, DateTimeKind.Local).AddTicks(447), new DateTime(2025, 12, 15, 18, 59, 21, 254, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 18, 59, 21, 254, DateTimeKind.Local).AddTicks(3848), new DateTime(2025, 12, 15, 18, 59, 21, 254, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 18, 59, 21, 254, DateTimeKind.Local).AddTicks(3850), new DateTime(2025, 12, 15, 18, 59, 21, 254, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(1112), new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(2311), new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5347), new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5376), new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5540), new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5549), new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10006L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5552), new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10007L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5556), new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10008L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5559), new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10009L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5564), new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10010L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5565), new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10011L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5568), new DateTime(2025, 12, 15, 10, 59, 21, 258, DateTimeKind.Utc).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 276, DateTimeKind.Utc).AddTicks(9996), new DateTime(2025, 12, 15, 10, 59, 21, 277, DateTimeKind.Utc).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000197001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(3624), new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000198001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(2788), new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105198501010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(3613), new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105199001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(3617), new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110108199003030001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(3623), new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100198502020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(3615), new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100199002020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(3618), new DateTime(2025, 12, 15, 10, 59, 21, 285, DateTimeKind.Utc).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "task_evidences",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 265, DateTimeKind.Utc).AddTicks(5773), new DateTime(2025, 12, 15, 10, 59, 21, 265, DateTimeKind.Utc).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 290, DateTimeKind.Utc).AddTicks(3040), new DateTime(2025, 12, 15, 10, 59, 21, 290, DateTimeKind.Utc).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 290, DateTimeKind.Utc).AddTicks(3645), new DateTime(2025, 12, 14, 10, 59, 21, 290, DateTimeKind.Utc).AddTicks(3647), new DateTime(2025, 12, 15, 10, 59, 21, 290, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 290, DateTimeKind.Utc).AddTicks(3828), new DateTime(2025, 12, 15, 10, 59, 21, 290, DateTimeKind.Utc).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 290, DateTimeKind.Utc).AddTicks(3830), new DateTime(2025, 12, 13, 10, 59, 21, 290, DateTimeKind.Utc).AddTicks(3831), new DateTime(2025, 12, 15, 10, 59, 21, 290, DateTimeKind.Utc).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 290, DateTimeKind.Utc).AddTicks(3832), new DateTime(2024, 12, 15, 10, 59, 21, 290, DateTimeKind.Utc).AddTicks(3833), new DateTime(2025, 12, 15, 10, 59, 21, 290, DateTimeKind.Utc).AddTicks(3832) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "expert_reviews");

            migrationBuilder.AlterColumn<decimal>(
                name: "ScoreRatio",
                table: "expert_reviews",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FinalScore",
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
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 935, DateTimeKind.Utc).AddTicks(9435), new DateTime(2025, 12, 12, 9, 31, 48, 935, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(7688), new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8043), new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8045), new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8046), new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8048), new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8050), new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20006L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8051), new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20007L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8052), new DateTime(2025, 12, 12, 9, 31, 48, 959, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2319), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_OTH_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3015), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2993), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3010), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3003), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2996), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3011), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3004), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130000_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2997), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2999), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3006), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130102_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3008), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130104_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3013), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3002), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_SPE_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3009), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130402_INC_01",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3014), new DateTime(2025, 12, 12, 9, 31, 48, 878, DateTimeKind.Utc).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(6469), new DateTime(2026, 1, 1, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(6993), new DateTime(2025, 12, 2, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(6903), 1, new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7076), new DateTime(2026, 1, 16, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7078), new DateTime(2025, 12, 17, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7078), new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7079), new DateTime(2025, 12, 27, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7081), new DateTime(2025, 12, 10, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7081), 1, new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7082), new DateTime(2025, 1, 11, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7120), new DateTime(2024, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7083), 2, new DateTime(2025, 12, 12, 9, 31, 48, 958, DateTimeKind.Utc).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(1312), new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2138), new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2235), new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2323), new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2327), new DateTime(2025, 12, 12, 9, 31, 48, 931, DateTimeKind.Utc).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 938, DateTimeKind.Utc).AddTicks(9994), new DateTime(2025, 12, 12, 9, 31, 48, 938, DateTimeKind.Utc).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(5449), new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6305), new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6409), new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6497), new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6502), new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6507), new DateTime(2025, 12, 12, 9, 31, 48, 929, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "inspection_logs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 944, DateTimeKind.Utc).AddTicks(7632), new DateTime(2025, 12, 12, 9, 31, 48, 944, DateTimeKind.Utc).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "inspection_schedules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 943, DateTimeKind.Utc).AddTicks(4112), new DateTime(2025, 12, 12, 9, 31, 48, 943, DateTimeKind.Utc).AddTicks(4113), new DateTime(2025, 12, 14, 9, 31, 48, 943, DateTimeKind.Utc).AddTicks(4589), new DateTime(2025, 12, 13, 9, 31, 48, 943, DateTimeKind.Utc).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "inspection_team_members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 941, DateTimeKind.Utc).AddTicks(2852), new DateTime(2025, 12, 12, 9, 31, 48, 941, DateTimeKind.Utc).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "inspection_teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 939, DateTimeKind.Utc).AddTicks(9084), new DateTime(2025, 12, 12, 9, 31, 48, 939, DateTimeKind.Utc).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7112), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110101",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7660), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7662), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110105",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7663), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110106",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7664), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110107",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7670), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110108",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7671), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110109",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7672), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110111",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7673), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110112",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7674), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110113",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7674), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110114",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7675), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110115",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7676), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110116",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7676), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110117",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7677), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110118",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7678), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110119",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7678), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7680), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7736), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7737), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130200",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7739), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130202",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7739), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130300",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7740), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130302",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7741), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130400",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7742), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130402",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7742), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130500",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7743), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130502",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7744), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130600",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7744), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130606",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7745), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130700",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7746), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130702",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7746), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130800",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7747), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130802",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7749), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130900",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7750), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130902",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7751), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7752), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7752), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7753), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7753), new DateTime(2025, 12, 12, 9, 31, 48, 874, DateTimeKind.Utc).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "review_allocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AssignedAt", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 937, DateTimeKind.Utc).AddTicks(8045), new DateTime(2025, 12, 12, 9, 31, 48, 937, DateTimeKind.Utc).AddTicks(7567), new DateTime(2025, 12, 12, 9, 31, 48, 937, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7045), new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7751), new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7753), new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7755), new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7756), new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7760), new DateTime(2025, 12, 12, 17, 31, 48, 924, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 17, 31, 48, 922, DateTimeKind.Local).AddTicks(2940), new DateTime(2025, 12, 12, 17, 31, 48, 923, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 17, 31, 48, 923, DateTimeKind.Local).AddTicks(7261), new DateTime(2025, 12, 12, 17, 31, 48, 923, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 17, 31, 48, 923, DateTimeKind.Local).AddTicks(7264), new DateTime(2025, 12, 12, 17, 31, 48, 923, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(5368), new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(6570), new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9601), new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9618), new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9749), new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10006L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9772), new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10007L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9776), new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10008L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9779), new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10009L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9783), new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10010L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9785), new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10011L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9788), new DateTime(2025, 12, 12, 9, 31, 48, 927, DateTimeKind.Utc).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 946, DateTimeKind.Utc).AddTicks(1501), new DateTime(2025, 12, 12, 9, 31, 48, 946, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000197001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4932), new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000198001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4042), new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105198501010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4913), new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105199001010001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4917), new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110108199003030001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4930), new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100198502020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4916), new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100199002020001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4919), new DateTime(2025, 12, 12, 9, 31, 48, 955, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "task_evidences",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 934, DateTimeKind.Utc).AddTicks(8086), new DateTime(2025, 12, 12, 9, 31, 48, 934, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(235), new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30001L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(853), new DateTime(2025, 12, 11, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(855), new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1053), new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30003L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1055), new DateTime(2025, 12, 10, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1056), new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30004L,
                columns: new[] { "CreatedAt", "SubmittedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1057), new DateTime(2024, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1059), new DateTime(2025, 12, 12, 9, 31, 48, 962, DateTimeKind.Utc).AddTicks(1058) });
        }
    }
}
