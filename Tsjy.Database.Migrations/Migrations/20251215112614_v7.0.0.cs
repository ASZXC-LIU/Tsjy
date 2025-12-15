using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tsjy.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v700 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ai_pre_evaluations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 377, DateTimeKind.Utc).AddTicks(1477), new DateTime(2025, 12, 15, 11, 26, 14, 377, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20000L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(8921), new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20001L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9306), new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20002L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9307), new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20003L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9309), new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20004L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9310), new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20005L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9312), new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20006L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9313), new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20007L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9314), new DateTime(2025, 12, 15, 11, 26, 14, 398, DateTimeKind.Utc).AddTicks(9314) });

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

            migrationBuilder.UpdateData(
                table: "review_allocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AssignedAt", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 26, 14, 379, DateTimeKind.Utc).AddTicks(984), new DateTime(2025, 12, 15, 11, 26, 14, 379, DateTimeKind.Utc).AddTicks(463), new DateTime(2025, 12, 15, 11, 26, 14, 379, DateTimeKind.Utc).AddTicks(464) });

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
                name: "IX_expert_reviews_NodeId",
                table: "expert_reviews",
                column: "NodeId");

            migrationBuilder.CreateIndex(
                name: "IX_expert_reviews_ReviewerId",
                table: "expert_reviews",
                column: "ReviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_expert_reviews_ReviewerId_Status",
                table: "expert_reviews",
                columns: new[] { "ReviewerId", "Status" });

            migrationBuilder.CreateIndex(
                name: "IX_expert_reviews_TaskId",
                table: "expert_reviews",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_batch_targets_BatchId",
                table: "batch_targets",
                column: "BatchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_expert_reviews_NodeId",
                table: "expert_reviews");

            migrationBuilder.DropIndex(
                name: "IX_expert_reviews_ReviewerId",
                table: "expert_reviews");

            migrationBuilder.DropIndex(
                name: "IX_expert_reviews_ReviewerId_Status",
                table: "expert_reviews");

            migrationBuilder.DropIndex(
                name: "IX_expert_reviews_TaskId",
                table: "expert_reviews");

            migrationBuilder.DropIndex(
                name: "IX_batch_targets_BatchId",
                table: "batch_targets");

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
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3130), new DateTime(2026, 1, 4, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3735), new DateTime(2025, 12, 5, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3576), new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3130) });

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
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3817), new DateTime(2025, 12, 30, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3818), new DateTime(2025, 12, 13, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3818), new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3819), new DateTime(2025, 1, 14, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3855), new DateTime(2024, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3820), new DateTime(2025, 12, 15, 10, 59, 21, 287, DateTimeKind.Utc).AddTicks(3820) });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 59, 21, 269, DateTimeKind.Utc).AddTicks(6503), new DateTime(2025, 12, 15, 10, 59, 21, 269, DateTimeKind.Utc).AddTicks(5782) });

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
    }
}
