using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tsjy.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v900 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "InspectionEnd",
                table: "distribution_batches",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InspectionStart",
                table: "distribution_batches",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReviewEnd",
                table: "distribution_batches",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReviewStart",
                table: "distribution_batches",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UploadEnd",
                table: "distribution_batches",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UploadStart",
                table: "distribution_batches",
                type: "datetime(6)",
                nullable: true);

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
                columns: new[] { "CreatedAt", "DueAt", "InspectionEnd", "InspectionStart", "ReviewEnd", "ReviewStart", "StartAt", "UpdatedAt", "UploadEnd", "UploadStart" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(2873), new DateTime(2026, 1, 4, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3438), null, null, null, null, new DateTime(2025, 12, 5, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3339), new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(2873), null, null });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10001L,
                columns: new[] { "CreatedAt", "DueAt", "InspectionEnd", "InspectionStart", "ReviewEnd", "ReviewStart", "StartAt", "UpdatedAt", "UploadEnd", "UploadStart" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3520), new DateTime(2026, 1, 19, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3522), null, null, null, null, new DateTime(2025, 12, 20, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3521), new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3520), null, null });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10002L,
                columns: new[] { "CreatedAt", "DueAt", "InspectionEnd", "InspectionStart", "ReviewEnd", "ReviewStart", "StartAt", "UpdatedAt", "UploadEnd", "UploadStart" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3523), new DateTime(2025, 12, 30, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3525), null, null, null, null, new DateTime(2025, 12, 13, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3524), new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3524), null, null });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10003L,
                columns: new[] { "CreatedAt", "DueAt", "InspectionEnd", "InspectionStart", "ReviewEnd", "ReviewStart", "StartAt", "UpdatedAt", "UploadEnd", "UploadStart" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 1, 14, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3564), null, null, null, null, new DateTime(2024, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3527), new DateTime(2025, 12, 15, 12, 46, 52, 523, DateTimeKind.Utc).AddTicks(3526), null, null });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 504, DateTimeKind.Utc).AddTicks(9652), new DateTime(2025, 12, 15, 12, 46, 52, 504, DateTimeKind.Utc).AddTicks(8938) });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 46, 52, 506, DateTimeKind.Utc).AddTicks(7564), new DateTime(2025, 12, 15, 12, 46, 52, 506, DateTimeKind.Utc).AddTicks(7177) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InspectionEnd",
                table: "distribution_batches");

            migrationBuilder.DropColumn(
                name: "InspectionStart",
                table: "distribution_batches");

            migrationBuilder.DropColumn(
                name: "ReviewEnd",
                table: "distribution_batches");

            migrationBuilder.DropColumn(
                name: "ReviewStart",
                table: "distribution_batches");

            migrationBuilder.DropColumn(
                name: "UploadEnd",
                table: "distribution_batches");

            migrationBuilder.DropColumn(
                name: "UploadStart",
                table: "distribution_batches");

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
    }
}
