using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tsjy.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v200 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TargetId",
                table: "tasks",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "OrgId",
                table: "sys_users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OrgId",
                table: "batch_targets",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "ai_pre_evaluations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 877, DateTimeKind.Utc).AddTicks(3594), new DateTime(2025, 12, 11, 1, 36, 59, 877, DateTimeKind.Utc).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "OrgId", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 900, DateTimeKind.Utc).AddTicks(17), "330106_EDU", new DateTime(2025, 12, 11, 1, 36, 59, 899, DateTimeKind.Utc).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "330100_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 811, DateTimeKind.Utc).AddTicks(5430), new DateTime(2025, 12, 11, 1, 36, 59, 811, DateTimeKind.Utc).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "330106_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 811, DateTimeKind.Utc).AddTicks(5526), new DateTime(2025, 12, 11, 1, 36, 59, 811, DateTimeKind.Utc).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 899, DateTimeKind.Utc).AddTicks(300), new DateTime(2025, 12, 11, 1, 36, 59, 898, DateTimeKind.Utc).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 870, DateTimeKind.Utc).AddTicks(3894), new DateTime(2025, 12, 11, 1, 36, 59, 870, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 870, DateTimeKind.Utc).AddTicks(4913), new DateTime(2025, 12, 11, 1, 36, 59, 870, DateTimeKind.Utc).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 870, DateTimeKind.Utc).AddTicks(5004), new DateTime(2025, 12, 11, 1, 36, 59, 870, DateTimeKind.Utc).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 881, DateTimeKind.Utc).AddTicks(659), new DateTime(2025, 12, 11, 1, 36, 59, 880, DateTimeKind.Utc).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 868, DateTimeKind.Utc).AddTicks(3556), new DateTime(2025, 12, 11, 1, 36, 59, 868, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 868, DateTimeKind.Utc).AddTicks(4401), new DateTime(2025, 12, 11, 1, 36, 59, 868, DateTimeKind.Utc).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 868, DateTimeKind.Utc).AddTicks(4487), new DateTime(2025, 12, 11, 1, 36, 59, 868, DateTimeKind.Utc).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "inspection_logs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 886, DateTimeKind.Utc).AddTicks(7701), new DateTime(2025, 12, 11, 1, 36, 59, 886, DateTimeKind.Utc).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "inspection_schedules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 885, DateTimeKind.Utc).AddTicks(4978), new DateTime(2025, 12, 11, 1, 36, 59, 885, DateTimeKind.Utc).AddTicks(4979), new DateTime(2025, 12, 13, 1, 36, 59, 885, DateTimeKind.Utc).AddTicks(5484), new DateTime(2025, 12, 12, 1, 36, 59, 885, DateTimeKind.Utc).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "inspection_team_members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 883, DateTimeKind.Utc).AddTicks(3340), new DateTime(2025, 12, 11, 1, 36, 59, 883, DateTimeKind.Utc).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "inspection_teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 882, DateTimeKind.Utc).AddTicks(4303), new DateTime(2025, 12, 11, 1, 36, 59, 882, DateTimeKind.Utc).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 808, DateTimeKind.Utc).AddTicks(1447), new DateTime(2025, 12, 11, 1, 36, 59, 808, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 808, DateTimeKind.Utc).AddTicks(1564), new DateTime(2025, 12, 11, 1, 36, 59, 808, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330106",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 808, DateTimeKind.Utc).AddTicks(1566), new DateTime(2025, 12, 11, 1, 36, 59, 808, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "review_allocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AssignedAt", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 879, DateTimeKind.Utc).AddTicks(8944), new DateTime(2025, 12, 11, 1, 36, 59, 879, DateTimeKind.Utc).AddTicks(8377), new DateTime(2025, 12, 11, 1, 36, 59, 879, DateTimeKind.Utc).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 862, DateTimeKind.Utc).AddTicks(7200), new DateTime(2025, 12, 11, 9, 36, 59, 862, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 862, DateTimeKind.Utc).AddTicks(7307), new DateTime(2025, 12, 11, 9, 36, 59, 862, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 862, DateTimeKind.Utc).AddTicks(7309), new DateTime(2025, 12, 11, 9, 36, 59, 862, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 862, DateTimeKind.Utc).AddTicks(7311), new DateTime(2025, 12, 11, 9, 36, 59, 862, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 861, DateTimeKind.Utc).AddTicks(2785), new DateTime(2025, 12, 11, 9, 36, 59, 861, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 866, DateTimeKind.Utc).AddTicks(3955), new DateTime(2025, 12, 11, 1, 36, 59, 866, DateTimeKind.Utc).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 866, DateTimeKind.Utc).AddTicks(4998), new DateTime(2025, 12, 11, 1, 36, 59, 866, DateTimeKind.Utc).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 866, DateTimeKind.Utc).AddTicks(5085), new DateTime(2025, 12, 11, 1, 36, 59, 866, DateTimeKind.Utc).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 888, DateTimeKind.Utc).AddTicks(1117), new DateTime(2025, 12, 11, 1, 36, 59, 888, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "123456789012345678",
                columns: new[] { "CreatedAt", "OrgId", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 896, DateTimeKind.Utc).AddTicks(9991), "330100_EDU", new DateTime(2025, 12, 11, 1, 36, 59, 897, DateTimeKind.Utc).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "123456789012345679",
                columns: new[] { "CreatedAt", "OrgId", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 897, DateTimeKind.Utc).AddTicks(325), "330106_EDU", new DateTime(2025, 12, 11, 1, 36, 59, 897, DateTimeKind.Utc).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "task_evidences",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 875, DateTimeKind.Utc).AddTicks(1987), new DateTime(2025, 12, 11, 1, 36, 59, 875, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "TargetId", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 902, DateTimeKind.Utc).AddTicks(209), new DateTime(2025, 12, 18, 1, 36, 59, 902, DateTimeKind.Utc).AddTicks(127), new DateTime(2025, 12, 11, 1, 36, 59, 902, DateTimeKind.Utc).AddTicks(41), "330100_EDU", new DateTime(2025, 12, 11, 1, 36, 59, 901, DateTimeKind.Utc).AddTicks(9475) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "TargetId",
                table: "tasks",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrgId",
                table: "sys_users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "OrgId",
                table: "batch_targets",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ai_pre_evaluations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 492, DateTimeKind.Utc).AddTicks(5547), new DateTime(2025, 12, 10, 7, 52, 15, 492, DateTimeKind.Utc).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "OrgId", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 514, DateTimeKind.Utc).AddTicks(6114), 1L, new DateTime(2025, 12, 10, 7, 52, 15, 514, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "330100_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 441, DateTimeKind.Utc).AddTicks(715), new DateTime(2025, 12, 10, 7, 52, 15, 440, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "330106_EDU",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 441, DateTimeKind.Utc).AddTicks(843), new DateTime(2025, 12, 10, 7, 52, 15, 441, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 513, DateTimeKind.Utc).AddTicks(6728), new DateTime(2025, 12, 10, 7, 52, 15, 513, DateTimeKind.Utc).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 487, DateTimeKind.Utc).AddTicks(5027), new DateTime(2025, 12, 10, 7, 52, 15, 487, DateTimeKind.Utc).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 487, DateTimeKind.Utc).AddTicks(6054), new DateTime(2025, 12, 10, 7, 52, 15, 487, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 487, DateTimeKind.Utc).AddTicks(6140), new DateTime(2025, 12, 10, 7, 52, 15, 487, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 496, DateTimeKind.Utc).AddTicks(5747), new DateTime(2025, 12, 10, 7, 52, 15, 496, DateTimeKind.Utc).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 485, DateTimeKind.Utc).AddTicks(7515), new DateTime(2025, 12, 10, 7, 52, 15, 485, DateTimeKind.Utc).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 485, DateTimeKind.Utc).AddTicks(8373), new DateTime(2025, 12, 10, 7, 52, 15, 485, DateTimeKind.Utc).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 485, DateTimeKind.Utc).AddTicks(8455), new DateTime(2025, 12, 10, 7, 52, 15, 485, DateTimeKind.Utc).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "inspection_logs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 502, DateTimeKind.Utc).AddTicks(726), new DateTime(2025, 12, 10, 7, 52, 15, 502, DateTimeKind.Utc).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "inspection_schedules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 500, DateTimeKind.Utc).AddTicks(7500), new DateTime(2025, 12, 10, 7, 52, 15, 500, DateTimeKind.Utc).AddTicks(7502), new DateTime(2025, 12, 12, 7, 52, 15, 500, DateTimeKind.Utc).AddTicks(7972), new DateTime(2025, 12, 11, 7, 52, 15, 500, DateTimeKind.Utc).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "inspection_team_members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 498, DateTimeKind.Utc).AddTicks(8335), new DateTime(2025, 12, 10, 7, 52, 15, 498, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "inspection_teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 497, DateTimeKind.Utc).AddTicks(7358), new DateTime(2025, 12, 10, 7, 52, 15, 497, DateTimeKind.Utc).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 437, DateTimeKind.Utc).AddTicks(1204), new DateTime(2025, 12, 10, 7, 52, 15, 437, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 437, DateTimeKind.Utc).AddTicks(1303), new DateTime(2025, 12, 10, 7, 52, 15, 437, DateTimeKind.Utc).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330106",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 437, DateTimeKind.Utc).AddTicks(1305), new DateTime(2025, 12, 10, 7, 52, 15, 437, DateTimeKind.Utc).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "review_allocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AssignedAt", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 495, DateTimeKind.Utc).AddTicks(3324), new DateTime(2025, 12, 10, 7, 52, 15, 495, DateTimeKind.Utc).AddTicks(2785), new DateTime(2025, 12, 10, 7, 52, 15, 495, DateTimeKind.Utc).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 482, DateTimeKind.Utc).AddTicks(1011), new DateTime(2025, 12, 10, 15, 52, 15, 482, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 482, DateTimeKind.Utc).AddTicks(1100), new DateTime(2025, 12, 10, 15, 52, 15, 482, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 482, DateTimeKind.Utc).AddTicks(1102), new DateTime(2025, 12, 10, 15, 52, 15, 482, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 482, DateTimeKind.Utc).AddTicks(1104), new DateTime(2025, 12, 10, 15, 52, 15, 482, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 481, DateTimeKind.Utc).AddTicks(566), new DateTime(2025, 12, 10, 15, 52, 15, 480, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 484, DateTimeKind.Utc).AddTicks(2818), new DateTime(2025, 12, 10, 7, 52, 15, 484, DateTimeKind.Utc).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 484, DateTimeKind.Utc).AddTicks(3835), new DateTime(2025, 12, 10, 7, 52, 15, 484, DateTimeKind.Utc).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 484, DateTimeKind.Utc).AddTicks(3924), new DateTime(2025, 12, 10, 7, 52, 15, 484, DateTimeKind.Utc).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 503, DateTimeKind.Utc).AddTicks(5666), new DateTime(2025, 12, 10, 7, 52, 15, 503, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "123456789012345678",
                columns: new[] { "CreatedAt", "OrgId", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 511, DateTimeKind.Utc).AddTicks(6530), 1, new DateTime(2025, 12, 10, 7, 52, 15, 511, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "123456789012345679",
                columns: new[] { "CreatedAt", "OrgId", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 511, DateTimeKind.Utc).AddTicks(6846), 1, new DateTime(2025, 12, 10, 7, 52, 15, 511, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "task_evidences",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 491, DateTimeKind.Utc).AddTicks(4644), new DateTime(2025, 12, 10, 7, 52, 15, 491, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "DueAt", "StartAt", "TargetId", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 52, 15, 516, DateTimeKind.Utc).AddTicks(6172), new DateTime(2025, 12, 17, 7, 52, 15, 516, DateTimeKind.Utc).AddTicks(6088), new DateTime(2025, 12, 10, 7, 52, 15, 516, DateTimeKind.Utc).AddTicks(5997), 1L, new DateTime(2025, 12, 10, 7, 52, 15, 516, DateTimeKind.Utc).AddTicks(5448) });
        }
    }
}
