using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tsjy.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v400 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130102_EDU");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130102_INC_01");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "330100_EDU");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "330106_EDU");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "330106_INC_01");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "330106_SPE_01");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "330108_EDU");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "330108_INC_01");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "330108_SPE_01");

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 2000L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 2001L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 2002L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 2003L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 2004L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 2005L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 2006L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 2007L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1000L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1001L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1002L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1003L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1004L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1005L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1006L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1007L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1008L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1009L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1010L);

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130104");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330000");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330100");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330106");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330108");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330200");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330203");

            migrationBuilder.DeleteData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "100000000000000000");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "111111111111111111");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "222222222222222222");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "333333333333333333");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "444444444444444444");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "555555555555555555");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "666666666666666666");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "777777777777777777");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "888888888888888888");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "999999999999999999");

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.AlterColumn<string>(
                name: "LevelCode",
                table: "scoring_template_items",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "ai_pre_evaluations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 915, DateTimeKind.Utc).AddTicks(5314), new DateTime(2025, 12, 12, 7, 33, 53, 915, DateTimeKind.Utc).AddTicks(5315) });

            migrationBuilder.InsertData(
                table: "batch_targets",
                columns: new[] { "Id", "BatchId", "CreatedAt", "IsDeleted", "OrgId", "UpdatedAt" },
                values: new object[,]
                {
                    { 20000L, 10000L, new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1130), false, "110105_SPE_01", new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1132) },
                    { 20001L, 10000L, new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1480), false, "110108_SPE_01", new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1480) },
                    { 20002L, 10000L, new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1481), false, "130100_SPE_01", new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1482) },
                    { 20003L, 10001L, new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1482), false, "110108_INC_01", new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1483) },
                    { 20004L, 10001L, new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1483), false, "130104_INC_01", new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1484) },
                    { 20005L, 10002L, new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1486), false, "110105_EDU", new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1487) },
                    { 20006L, 10002L, new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1487), false, "130100_EDU", new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1488) },
                    { 20007L, 10003L, new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1488), false, "130400_SPE_01", new DateTime(2025, 12, 12, 7, 33, 53, 936, DateTimeKind.Utc).AddTicks(1489) }
                });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_EDU",
                columns: new[] { "Address", "CreatedAt", "IncSchoolsNum", "Phone", "SpeSchoolsNum", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(191), 200L, 0, 12L, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_SPE_01",
                columns: new[] { "Address", "CreatedAt", "Name", "Phone", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(198), "石家庄市特殊教育学校", 0, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130102_SPE_01",
                columns: new[] { "Address", "CreatedAt", "Name", "Phone", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(200), "石家庄市长安区启智学校", 0, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Code", "Address", "CreatedAt", "IncSchoolsNum", "IsDeleted", "Level", "Name", "OrgType", "Phone", "RegionCode", "SpeSchoolsNum", "UpdatedAt" },
                values: new object[,]
                {
                    { "110000_EDU", null, new DateTime(2025, 12, 12, 7, 33, 53, 863, DateTimeKind.Utc).AddTicks(9531), 1000L, false, 0, "北京市教委", 2, 0, "110000", 20L, new DateTime(2025, 12, 12, 7, 33, 53, 863, DateTimeKind.Utc).AddTicks(9534) },
                    { "110000_OTH_01", null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(207), 0L, false, 0, "北师大特教研究所", 3, 0, "110000", 0L, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(207) },
                    { "110105_EDU", null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(185), 150L, false, 2, "朝阳区教委", 2, 0, "110105", 3L, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(186) },
                    { "110105_INC_01", null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(202), 0L, false, 2, "朝阳区实验小学", 1, 0, "110105", 0L, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(202) },
                    { "110105_SPE_01", null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(195), 0L, false, 2, "北京市朝阳区安华学校", 0, 0, "110105", 0L, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(195) },
                    { "110108_EDU", null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(187), 180L, false, 2, "海淀区教委", 2, 0, "110108", 4L, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(188) },
                    { "110108_INC_01", null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(203), 0L, false, 2, "中关村第一小学", 1, 0, "110108", 0L, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(203) },
                    { "110108_SPE_01", null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(196), 0L, false, 2, "北京市海淀区特殊教育学校", 0, 0, "110108", 0L, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(197) },
                    { "130000_EDU", null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(189), 3000L, false, 0, "河北省教育厅", 2, 0, "130000", 150L, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(189) },
                    { "130104_INC_01", null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(204), 0L, false, 2, "石家庄草场街小学", 1, 0, "130104", 0L, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(205) },
                    { "130400_EDU", null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(194), 180L, false, 1, "邯郸市教育局", 2, 0, "130400", 10L, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(194) },
                    { "130400_SPE_01", null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(201), 0L, false, 1, "邯郸市特殊教育中心", 0, 0, "130400", 0L, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(201) },
                    { "130402_INC_01", null, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(206), 0L, false, 2, "邯郸市邯山区实验小学", 1, 0, "130402", 0L, new DateTime(2025, 12, 12, 7, 33, 53, 864, DateTimeKind.Utc).AddTicks(206) }
                });

            migrationBuilder.InsertData(
                table: "distribution_batches",
                columns: new[] { "Id", "CreatedAt", "DueAt", "IsDeleted", "Name", "StartAt", "Status", "TreeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 10000L, new DateTime(2025, 12, 12, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(580), new DateTime(2026, 1, 1, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(1090), false, "2025年特教学校春季普查", new DateTime(2025, 12, 2, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(999), 1, 202501L, new DateTime(2025, 12, 12, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(581) },
                    { 10001L, new DateTime(2025, 12, 12, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(1172), new DateTime(2026, 1, 16, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(1174), false, "海淀区随班就读质量监测", new DateTime(2025, 12, 17, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(1174), 0, 202502L, new DateTime(2025, 12, 12, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(1172) },
                    { 10002L, new DateTime(2025, 12, 12, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(1175), new DateTime(2025, 12, 27, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(1177), false, "2025区域特教发展绩效评价", new DateTime(2025, 12, 10, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(1177), 1, 202503L, new DateTime(2025, 12, 12, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(1176) },
                    { 10003L, new DateTime(2025, 12, 12, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(1178), new DateTime(2025, 1, 11, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(1212), false, "2024年终考核存档", new DateTime(2024, 12, 12, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(1179), 2, 202401L, new DateTime(2025, 12, 12, 7, 33, 53, 935, DateTimeKind.Utc).AddTicks(1178) }
                });

            migrationBuilder.InsertData(
                table: "edu_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 30000L, null, new DateTime(2025, 12, 12, 7, 33, 53, 910, DateTimeKind.Utc).AddTicks(5235), 0, false, 100m, "2025区域特教发展评价", 0, null, "0", null, 202503L, 0, new DateTime(2025, 12, 12, 7, 33, 53, 910, DateTimeKind.Utc).AddTicks(5237) },
                    { 30001L, "1", new DateTime(2025, 12, 12, 7, 33, 53, 910, DateTimeKind.Utc).AddTicks(6190), 1, false, 60m, "经费保障", 0, 30000L, "0,30000", null, 202503L, 1, new DateTime(2025, 12, 12, 7, 33, 53, 910, DateTimeKind.Utc).AddTicks(6190) },
                    { 30002L, "1.1", new DateTime(2025, 12, 12, 7, 33, 53, 910, DateTimeKind.Utc).AddTicks(6285), 2, false, 60m, "生均公用经费标准", 0, 30001L, "0,30000,30001", 1L, 202503L, 4, new DateTime(2025, 12, 12, 7, 33, 53, 910, DateTimeKind.Utc).AddTicks(6286) },
                    { 30003L, "2", new DateTime(2025, 12, 12, 7, 33, 53, 910, DateTimeKind.Utc).AddTicks(6375), 1, false, 40m, "入学率", 0, 30000L, "0,30000", null, 202503L, 1, new DateTime(2025, 12, 12, 7, 33, 53, 910, DateTimeKind.Utc).AddTicks(6375) },
                    { 30004L, "2.1", new DateTime(2025, 12, 12, 7, 33, 53, 910, DateTimeKind.Utc).AddTicks(6379), 2, false, 40m, "义务教育入学率", 0, 30003L, "0,30000,30003", 1L, 202503L, 4, new DateTime(2025, 12, 12, 7, 33, 53, 910, DateTimeKind.Utc).AddTicks(6379) }
                });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 918, DateTimeKind.Utc).AddTicks(6348), new DateTime(2025, 12, 12, 7, 33, 53, 918, DateTimeKind.Utc).AddTicks(5699) });

            migrationBuilder.InsertData(
                table: "inc_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 20000L, null, new DateTime(2025, 12, 12, 7, 33, 53, 908, DateTimeKind.Utc).AddTicks(9001), 0, false, 100m, "2025随班就读质量监测", 0, null, "0", null, 202502L, 0, new DateTime(2025, 12, 12, 7, 33, 53, 908, DateTimeKind.Utc).AddTicks(9002) },
                    { 20001L, "1", new DateTime(2025, 12, 12, 7, 33, 53, 908, DateTimeKind.Utc).AddTicks(9942), 1, false, 50m, "资源教室", 0, 20000L, "0,20000", null, 202502L, 1, new DateTime(2025, 12, 12, 7, 33, 53, 908, DateTimeKind.Utc).AddTicks(9942) },
                    { 20002L, "1.1", new DateTime(2025, 12, 12, 7, 33, 53, 909, DateTimeKind.Utc).AddTicks(48), 2, false, 25m, "资源教师配备", 0, 20001L, "0,20000,20001", 2L, 202502L, 4, new DateTime(2025, 12, 12, 7, 33, 53, 909, DateTimeKind.Utc).AddTicks(49) },
                    { 20003L, "1.2", new DateTime(2025, 12, 12, 7, 33, 53, 909, DateTimeKind.Utc).AddTicks(138), 2, false, 25m, "设备使用率", 0, 20001L, "0,20000,20001", 1L, 202502L, 4, new DateTime(2025, 12, 12, 7, 33, 53, 909, DateTimeKind.Utc).AddTicks(138) },
                    { 20004L, "2", new DateTime(2025, 12, 12, 7, 33, 53, 909, DateTimeKind.Utc).AddTicks(143), 1, false, 50m, "融合文化", 0, 20000L, "0,20000", null, 202502L, 1, new DateTime(2025, 12, 12, 7, 33, 53, 909, DateTimeKind.Utc).AddTicks(143) },
                    { 20005L, "2.1", new DateTime(2025, 12, 12, 7, 33, 53, 909, DateTimeKind.Utc).AddTicks(150), 2, false, 50m, "普特融合活动", 0, 20004L, "0,20000,20004", 1L, 202502L, 4, new DateTime(2025, 12, 12, 7, 33, 53, 909, DateTimeKind.Utc).AddTicks(150) }
                });

            migrationBuilder.UpdateData(
                table: "inspection_logs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 923, DateTimeKind.Utc).AddTicks(9988), new DateTime(2025, 12, 12, 7, 33, 53, 923, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "inspection_schedules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 922, DateTimeKind.Utc).AddTicks(5622), new DateTime(2025, 12, 12, 7, 33, 53, 922, DateTimeKind.Utc).AddTicks(5624), new DateTime(2025, 12, 14, 7, 33, 53, 922, DateTimeKind.Utc).AddTicks(6106), new DateTime(2025, 12, 13, 7, 33, 53, 922, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "inspection_team_members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 920, DateTimeKind.Utc).AddTicks(5586), new DateTime(2025, 12, 12, 7, 33, 53, 920, DateTimeKind.Utc).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "inspection_teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 919, DateTimeKind.Utc).AddTicks(6182), new DateTime(2025, 12, 12, 7, 33, 53, 919, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6091), new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110101",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6578), new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6607), new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6661), new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6662), new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6662) });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "Code", "CreatedAt", "IsDeleted", "Level", "Name", "ParentCode", "UpdatedAt" },
                values: new object[,]
                {
                    { "110102", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6592), false, 2, "西城区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6593) },
                    { "110105", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6593), false, 2, "朝阳区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6593) },
                    { "110106", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6594), false, 2, "丰台区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6594) },
                    { "110107", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6598), false, 2, "石景山区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6598) },
                    { "110108", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6599), false, 2, "海淀区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6599) },
                    { "110109", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6600), false, 2, "门头沟区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6600) },
                    { "110111", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6600), false, 2, "房山区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6600) },
                    { "110112", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6601), false, 2, "通州区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6602) },
                    { "110113", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6602), false, 2, "顺义区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6602) },
                    { "110114", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6603), false, 2, "昌平区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6603) },
                    { "110115", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6603), false, 2, "大兴区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6604) },
                    { "110116", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6604), false, 2, "怀柔区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6604) },
                    { "110117", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6605), false, 2, "平谷区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6605) },
                    { "110118", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6605), false, 2, "密云区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6605) },
                    { "110119", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6606), false, 2, "延庆区", "110000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6606) },
                    { "130200", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6663), false, 1, "唐山市", "130000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6663) },
                    { "130202", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6664), false, 2, "路南区", "130200", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6664) },
                    { "130300", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6665), false, 1, "秦皇岛市", "130000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6665) },
                    { "130302", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6665), false, 2, "海港区", "130300", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6666) },
                    { "130400", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6666), false, 1, "邯郸市", "130000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6666) },
                    { "130402", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6667), false, 2, "邯山区", "130400", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6667) },
                    { "130500", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6667), false, 1, "邢台市", "130000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6668) },
                    { "130502", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6668), false, 2, "襄都区", "130500", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6668) },
                    { "130600", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6669), false, 1, "保定市", "130000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6669) },
                    { "130606", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6669), false, 2, "莲池区", "130600", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6669) },
                    { "130700", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6670), false, 1, "张家口市", "130000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6670) },
                    { "130702", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6670), false, 2, "桥东区", "130700", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6671) },
                    { "130800", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6671), false, 1, "承德市", "130000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6671) },
                    { "130802", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6674), false, 2, "双桥区", "130800", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6674) },
                    { "130900", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6675), false, 1, "沧州市", "130000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6675) },
                    { "130902", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6676), false, 2, "新华区", "130900", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6676) },
                    { "131000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6676), false, 1, "廊坊市", "130000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6676) },
                    { "131003", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6677), false, 2, "广阳区", "131000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6677) },
                    { "131100", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6677), false, 1, "衡水市", "130000", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6677) },
                    { "131102", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6678), false, 2, "桃城区", "131100", new DateTime(2025, 12, 12, 7, 33, 53, 860, DateTimeKind.Utc).AddTicks(6678) }
                });

            migrationBuilder.UpdateData(
                table: "review_allocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AssignedAt", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 917, DateTimeKind.Utc).AddTicks(4363), new DateTime(2025, 12, 12, 7, 33, 53, 917, DateTimeKind.Utc).AddTicks(3829), new DateTime(2025, 12, 12, 7, 33, 53, 917, DateTimeKind.Utc).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 15, 33, 53, 903, DateTimeKind.Local).AddTicks(9366), new DateTime(2025, 12, 12, 15, 33, 53, 903, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 15, 33, 53, 904, DateTimeKind.Local).AddTicks(158), new DateTime(2025, 12, 12, 15, 33, 53, 904, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 15, 33, 53, 904, DateTimeKind.Local).AddTicks(161), new DateTime(2025, 12, 12, 15, 33, 53, 904, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 15, 33, 53, 904, DateTimeKind.Local).AddTicks(163), new DateTime(2025, 12, 12, 15, 33, 53, 904, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 15, 33, 53, 904, DateTimeKind.Local).AddTicks(165), "合格", new DateTime(2025, 12, 12, 15, 33, 53, 904, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 15, 33, 53, 904, DateTimeKind.Local).AddTicks(168), "不合格", new DateTime(2025, 12, 12, 15, 33, 53, 904, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 15, 33, 53, 901, DateTimeKind.Local).AddTicks(6847), "四级评分(A/B/C/D)", new DateTime(2025, 12, 12, 15, 33, 53, 902, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 15, 33, 53, 903, DateTimeKind.Local).AddTicks(416), new DateTime(2025, 12, 12, 15, 33, 53, 903, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 15, 33, 53, 903, DateTimeKind.Local).AddTicks(418), new DateTime(2025, 12, 12, 15, 33, 53, 903, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.InsertData(
                table: "spe_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 10000L, null, new DateTime(2025, 12, 12, 7, 33, 53, 906, DateTimeKind.Utc).AddTicks(6311), 0, false, 100m, "2025特教学校办学质量评价", 0, null, "0", null, 202501L, 0, new DateTime(2025, 12, 12, 7, 33, 53, 906, DateTimeKind.Utc).AddTicks(6313) },
                    { 10001L, "1", new DateTime(2025, 12, 12, 7, 33, 53, 906, DateTimeKind.Utc).AddTicks(7577), 1, false, 20m, "办学方向", 0, 10000L, "0,10000", null, 202501L, 1, new DateTime(2025, 12, 12, 7, 33, 53, 906, DateTimeKind.Utc).AddTicks(7578) },
                    { 10002L, "1.1", new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(768), 2, false, 10m, "党的领导", 0, 10001L, "0,10000,10001", null, 202501L, 2, new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(768) },
                    { 10003L, "1.1.1", new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(790), 3, false, 10m, "党建工作常态化", 0, 10002L, "0,10000,10001,10002", 2L, 202501L, 4, new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(790) },
                    { 10004L, "2", new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(929), 1, false, 40m, "教育教学", 0, 10000L, "0,10000", null, 202501L, 1, new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(929) },
                    { 10005L, "2.1", new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(942), 2, false, 20m, "个别化教育", 0, 10004L, "0,10000,10004", null, 202501L, 2, new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(942) },
                    { 10006L, "2.1.1", new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(945), 3, false, 10m, "IEP制定规范", 0, 10005L, "0,10000,10004,10005", null, 202501L, 3, new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(946) },
                    { 10007L, null, new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(949), 4, false, null, "查阅10份学生档案，检查IEP要素是否齐全。", 0, 10006L, "0,10000,10004,10005,10006", null, 202501L, 5, new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(949) },
                    { 10008L, "2.1.2", new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(952), 3, false, 10m, "IEP实施效果", 0, 10005L, "0,10000,10004,10005", 1L, 202501L, 4, new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(952) },
                    { 10009L, null, new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(956), 0, false, 100m, "2024河北省特教质量监测", 0, null, "0", null, 202401L, 0, new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(957) },
                    { 10010L, "A", new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(958), 1, false, 50m, "校园安全", 0, 10009L, "0,10009", null, 202401L, 1, new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(958) },
                    { 10011L, "A-1", new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(961), 2, false, 50m, "无障碍设施", 0, 10010L, "0,10009,10010", 1L, 202401L, 4, new DateTime(2025, 12, 12, 7, 33, 53, 907, DateTimeKind.Utc).AddTicks(961) }
                });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 925, DateTimeKind.Utc).AddTicks(3289), new DateTime(2025, 12, 12, 7, 33, 53, 925, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.InsertData(
                table: "sys_users",
                columns: new[] { "IDNumber", "CreatedAt", "IsDeleted", "OrgId", "OrgType", "Password", "Phone", "RealName", "Role", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "110000197001010001", new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(915), false, "110000_OTH_01", 3, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13600000001", "特教专家", 1, new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(915), "expert_01" },
                    { "110000198001010001", new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(20), false, "110000_EDU", 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000000", "超级管理员", 0, new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(22), "admin" },
                    { "110105198501010001", new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(878), false, "110105_EDU", 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000001", "朝阳区管理员", 0, new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(878), "admin_cy" },
                    { "110105199001010001", new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(906), false, "110105_SPE_01", 0, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13900000001", "安华学校校长", 2, new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(906), "sch_cy_spe" },
                    { "110108199003030001", new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(913), false, "110108_INC_01", 1, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13900000003", "中关村校长", 2, new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(913), "sch_hd_inc" },
                    { "130100198502020001", new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(881), false, "130100_EDU", 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000002", "石家庄管理员", 0, new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(881), "admin_sjz" },
                    { "130100199002020001", new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(908), false, "130100_SPE_01", 0, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13900000002", "石特校长", 2, new DateTime(2025, 12, 12, 7, 33, 53, 933, DateTimeKind.Utc).AddTicks(908), "sch_sjz_spe" }
                });

            migrationBuilder.UpdateData(
                table: "task_evidences",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 33, 53, 914, DateTimeKind.Utc).AddTicks(3888), new DateTime(2025, 12, 12, 7, 33, 53, 914, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.InsertData(
                table: "tasks",
                columns: new[] { "Id", "BatchId", "CreatedAt", "FinalScore", "IsDeleted", "Status", "SubmittedAt", "TargetId", "TargetType", "TreeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 30000L, 10000L, new DateTime(2025, 12, 12, 7, 33, 53, 938, DateTimeKind.Utc).AddTicks(4316), null, false, 2, null, "110105_SPE_01", 0, 202501L, new DateTime(2025, 12, 12, 7, 33, 53, 938, DateTimeKind.Utc).AddTicks(4317) },
                    { 30001L, 10000L, new DateTime(2025, 12, 12, 7, 33, 53, 938, DateTimeKind.Utc).AddTicks(4852), null, false, 3, new DateTime(2025, 12, 11, 7, 33, 53, 938, DateTimeKind.Utc).AddTicks(4854), "130100_SPE_01", 0, 202501L, new DateTime(2025, 12, 12, 7, 33, 53, 938, DateTimeKind.Utc).AddTicks(4853) },
                    { 30002L, 10001L, new DateTime(2025, 12, 12, 7, 33, 53, 938, DateTimeKind.Utc).AddTicks(5029), null, false, 0, null, "110108_INC_01", 1, 202502L, new DateTime(2025, 12, 12, 7, 33, 53, 938, DateTimeKind.Utc).AddTicks(5029) },
                    { 30003L, 10002L, new DateTime(2025, 12, 12, 7, 33, 53, 938, DateTimeKind.Utc).AddTicks(5030), null, false, 4, new DateTime(2025, 12, 10, 7, 33, 53, 938, DateTimeKind.Utc).AddTicks(5031), "110105_EDU", 2, 202503L, new DateTime(2025, 12, 12, 7, 33, 53, 938, DateTimeKind.Utc).AddTicks(5031) },
                    { 30004L, 10003L, new DateTime(2025, 12, 12, 7, 33, 53, 938, DateTimeKind.Utc).AddTicks(5032), 88.5m, false, 6, new DateTime(2024, 12, 12, 7, 33, 53, 938, DateTimeKind.Utc).AddTicks(5033), "130400_SPE_01", 0, 202401L, new DateTime(2025, 12, 12, 7, 33, 53, 938, DateTimeKind.Utc).AddTicks(5033) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20000L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20001L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20002L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20003L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20004L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20005L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20006L);

            migrationBuilder.DeleteData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 20007L);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_EDU");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110000_OTH_01");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_EDU");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_INC_01");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110105_SPE_01");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_EDU");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_INC_01");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "110108_SPE_01");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130000_EDU");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130104_INC_01");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_EDU");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130400_SPE_01");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130402_INC_01");

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10000L);

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10001L);

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10002L);

            migrationBuilder.DeleteData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 10003L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30000L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30001L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30002L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30003L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 30004L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20000L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20001L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20002L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20003L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20004L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 20005L);

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110102");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110105");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110106");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110107");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110108");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110109");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110111");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110112");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110113");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110114");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110115");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110116");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110117");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110118");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110119");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130200");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130202");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130300");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130302");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130400");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130402");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130500");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130502");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130600");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130606");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130700");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130702");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130800");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130802");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130900");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130902");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131000");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131003");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131100");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "131102");

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10000L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10001L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10002L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10003L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10004L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10005L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10006L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10007L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10008L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10009L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10010L);

            migrationBuilder.DeleteData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 10011L);

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000197001010001");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110000198001010001");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105198501010001");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110105199001010001");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "110108199003030001");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100198502020001");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "130100199002020001");

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30000L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30001L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30002L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30003L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 30004L);

            migrationBuilder.AlterColumn<string>(
                name: "LevelCode",
                table: "scoring_template_items",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ai_pre_evaluations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 286, DateTimeKind.Utc).AddTicks(5624), new DateTime(2025, 12, 12, 6, 52, 48, 286, DateTimeKind.Utc).AddTicks(5626) });

            migrationBuilder.InsertData(
                table: "batch_targets",
                columns: new[] { "Id", "BatchId", "CreatedAt", "IsDeleted", "OrgId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6883), false, "330106_SPE_01", new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6519) },
                    { 2L, 1L, new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6986), false, "330108_SPE_01", new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6985) },
                    { 3L, 2L, new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6987), false, "130100_SPE_01", new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6987) },
                    { 4L, 2L, new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6989), false, "130102_SPE_01", new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6988) },
                    { 5L, 3L, new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6990), false, "330106_INC_01", new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6989) },
                    { 6L, 3L, new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6994), false, "330106_SPE_01", new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6993) },
                    { 7L, 4L, new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6995), false, "330106_SPE_01", new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6995) },
                    { 8L, 4L, new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6997), false, "330108_SPE_01", new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6996) },
                    { 9L, 4L, new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6998), false, "130100_SPE_01", new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6998) },
                    { 10L, 7L, new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(7000), false, "330106_INC_01", new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6999) }
                });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_EDU",
                columns: new[] { "Address", "CreatedAt", "IncSchoolsNum", "Phone", "SpeSchoolsNum", "UpdatedAt" },
                values: new object[] { "石家庄xx路1号", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5272), 150L, 66666666, 10L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_SPE_01",
                columns: new[] { "Address", "CreatedAt", "Name", "Phone", "UpdatedAt" },
                values: new object[] { "石家庄市中心路", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5281), "石家庄特教学校", 66661111, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130102_SPE_01",
                columns: new[] { "Address", "CreatedAt", "Name", "Phone", "UpdatedAt" },
                values: new object[] { "长安区xx街道", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5282), "长安区启智学校", 66661112, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5283) });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Code", "Address", "CreatedAt", "IncSchoolsNum", "IsDeleted", "Level", "Name", "OrgType", "Phone", "RegionCode", "SpeSchoolsNum", "UpdatedAt" },
                values: new object[,]
                {
                    { "130102_EDU", "长安区xx路1号", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5274), 50L, false, 2, "长安区教育局", 2, 66666667, "130102", 3L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5274) },
                    { "130102_INC_01", "长安区建设路", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5287), 0L, false, 2, "石家庄长安一小", 1, 66662222, "130102", 0L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5288) },
                    { "330100_EDU", "杭州市xx路1号", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(3874), 120L, false, 1, "杭州市教育局", 2, 88888888, "330100", 8L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(3878) },
                    { "330106_EDU", "西湖区xx路2号", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5267), 45L, false, 2, "西湖区教育局", 2, 88888881, "330106", 2L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5267) },
                    { "330106_INC_01", "西湖区保俶路", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5284), 0L, false, 2, "西湖区第一小学", 1, 87654321, "330106", 0L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5285) },
                    { "330106_SPE_01", "西湖区紫荆花路", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5278), 0L, false, 2, "杭州紫荆花学校", 0, 12345678, "330106", 0L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5278) },
                    { "330108_EDU", "滨江区xx路3号", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5270), 30L, false, 2, "滨江区教育局", 2, 88888882, "330108", 1L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5270) },
                    { "330108_INC_01", "滨江区江南大道", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5286), 0L, false, 2, "滨江实验小学", 1, 87654322, "330108", 0L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5286) },
                    { "330108_SPE_01", "滨江区江虹路", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5279), 0L, false, 2, "杭州滨江特教学校", 0, 12345679, "330108", 0L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5280) }
                });

            migrationBuilder.InsertData(
                table: "distribution_batches",
                columns: new[] { "Id", "CreatedAt", "DueAt", "IsDeleted", "Name", "StartAt", "Status", "TreeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5772), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2025年度杭州特教普查", new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5258), 1, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5261) },
                    { 2L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5881), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2025年度石家庄特教普查", new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5880), 0, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5880) },
                    { 3L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5883), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2025年度西湖区融合教育抽查", new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5882), 1, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5882) },
                    { 4L, new DateTime(2024, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5885), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2024年度全省期末考评", new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5884), 2, 202401L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5884) },
                    { 5L, new DateTime(2024, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5961), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2024年度上半年自查", new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5960), 2, 202401L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5960) },
                    { 6L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5967), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2025专项整改回头看", new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5966), 0, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5967) },
                    { 7L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5969), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2025第一季度巡视", new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5968), 1, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5968) },
                    { 8L, new DateTime(2024, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5971), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2024年终总结评估", new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5970), 2, 202401L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5970) },
                    { 9L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5973), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2025示范校创建评估", new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5972), 0, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5972) },
                    { 10L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5975), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2025随班就读质量监测", new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5974), 0, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5975) }
                });

            migrationBuilder.InsertData(
                table: "edu_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 2000L, null, new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(4771), 0, false, 100m, "区域特教发展评价2025", 0, null, "0", null, 202501L, 0, new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(4773) },
                    { 2001L, "1", new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(5812), 1, false, 50m, "区域规划", 0, 2000L, "0,2000", null, 202501L, 1, new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(5812) },
                    { 2002L, "1.1", new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(5903), 2, false, 50m, "特教发展三年行动计划", 0, 2001L, "0,2000,2001", 1L, 202501L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(5903) },
                    { 2003L, "2", new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(5987), 1, false, 50m, "财政投入", 0, 2000L, "0,2000", null, 202501L, 1, new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(5987) },
                    { 2004L, "2.1", new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(5991), 2, false, 50m, "特教专项经费占比", 0, 2003L, "0,2000,2003", 1L, 202501L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(5991) },
                    { 2005L, null, new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(5997), 0, false, 100m, "区域特教2024", 0, null, "0", null, 202401L, 0, new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(5997) },
                    { 2006L, "1", new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(5999), 1, false, 100m, "总体情况", 0, 2005L, "0,2005", null, 202401L, 1, new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(5999) },
                    { 2007L, "1.1", new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(6001), 2, false, 100m, "普及程度", 0, 2006L, "0,2005,2006", 1L, 202401L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 281, DateTimeKind.Utc).AddTicks(6002) }
                });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 290, DateTimeKind.Utc).AddTicks(3972), new DateTime(2025, 12, 12, 6, 52, 48, 290, DateTimeKind.Utc).AddTicks(3349) });

            migrationBuilder.InsertData(
                table: "inc_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1000L, null, new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(6790), 0, false, 100m, "融合教育质量评价2025", 0, null, "0", null, 202501L, 0, new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(6792) },
                    { 1001L, "A", new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7662), 1, false, 50m, "入学安置", 0, 1000L, "0,1000", null, 202501L, 1, new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7663) },
                    { 1002L, "A-1", new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7763), 2, false, 25m, "残疾儿童入学率", 0, 1001L, "0,1000,1001", 1L, 202501L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7763) },
                    { 1003L, "A-2", new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7846), 2, false, 25m, "安置评估流程", 0, 1001L, "0,1000,1001", 2L, 202501L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7847) },
                    { 1004L, "B", new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7851), 1, false, 50m, "资源教室建设", 0, 1000L, "0,1000", null, 202501L, 1, new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7851) },
                    { 1005L, "B-1", new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7858), 2, false, 20m, "资源教师配备", 0, 1004L, "0,1000,1004", 1L, 202501L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7858) },
                    { 1006L, "B-2", new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7861), 2, false, 30m, "设备利用率", 0, 1004L, "0,1000,1004", 3L, 202501L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7861) },
                    { 1007L, null, new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7864), 0, false, 100m, "融合教育2024", 0, null, "0", null, 202401L, 0, new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7864) },
                    { 1008L, "1", new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7866), 1, false, 100m, "组织管理", 0, 1007L, "0,1007", null, 202401L, 1, new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7866) },
                    { 1009L, "1.1", new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7870), 2, false, 50m, "融合教育委员会", 0, 1008L, "0,1007,1008", 2L, 202401L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7870) },
                    { 1010L, "1.2", new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7873), 2, false, 50m, "制度建设", 0, 1008L, "0,1007,1008", 1L, 202401L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 279, DateTimeKind.Utc).AddTicks(7873) }
                });

            migrationBuilder.UpdateData(
                table: "inspection_logs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 295, DateTimeKind.Utc).AddTicks(8219), new DateTime(2025, 12, 12, 6, 52, 48, 295, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "inspection_schedules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt", "VisitEndAt", "VisitStartAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 294, DateTimeKind.Utc).AddTicks(4381), new DateTime(2025, 12, 12, 6, 52, 48, 294, DateTimeKind.Utc).AddTicks(4384), new DateTime(2025, 12, 14, 6, 52, 48, 294, DateTimeKind.Utc).AddTicks(4945), new DateTime(2025, 12, 13, 6, 52, 48, 294, DateTimeKind.Utc).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "inspection_team_members",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 292, DateTimeKind.Utc).AddTicks(3351), new DateTime(2025, 12, 12, 6, 52, 48, 292, DateTimeKind.Utc).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "inspection_teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 291, DateTimeKind.Utc).AddTicks(4422), new DateTime(2025, 12, 12, 6, 52, 48, 291, DateTimeKind.Utc).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4436), new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110101",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4437), new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4432), new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4433), new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130102",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4434), new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4434) });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "Code", "CreatedAt", "IsDeleted", "Level", "Name", "ParentCode", "UpdatedAt" },
                values: new object[,]
                {
                    { "130104", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4435), false, 2, "桥西区", "130100", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4436) },
                    { "330000", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(3993), false, 0, "浙江省", null, new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(3998) },
                    { "330100", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4424), false, 1, "杭州市", "330000", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4424) },
                    { "330106", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4425), false, 2, "西湖区", "330100", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4425) },
                    { "330108", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4426), false, 2, "滨江区", "330100", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4427) },
                    { "330200", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4427), false, 1, "宁波市", "330000", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4428) },
                    { "330203", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4431), false, 2, "海曙区", "330200", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4431) }
                });

            migrationBuilder.UpdateData(
                table: "review_allocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AssignedAt", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 289, DateTimeKind.Utc).AddTicks(916), new DateTime(2025, 12, 12, 6, 52, 48, 289, DateTimeKind.Utc).AddTicks(489), new DateTime(2025, 12, 12, 6, 52, 48, 289, DateTimeKind.Utc).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4098), new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4789), new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4791), new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4793), new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4794), "符合要求", new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4798), "不符合要求", new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.InsertData(
                table: "scoring_template_items",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "LevelCode", "Ratio", "ScoringModelId", "Sort", "TemplateId", "UpdatedAt" },
                values: new object[,]
                {
                    { 7L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4800), "优秀", false, "5星", 1.0m, null, 1, 3L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4800) },
                    { 8L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4801), "良好", false, "4星", 0.8m, null, 2, 3L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4802) },
                    { 9L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4803), "及格", false, "3星", 0.6m, null, 3, 3L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4803) },
                    { 10L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4814), "较差", false, "2星", 0.4m, null, 4, 3L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4814) },
                    { 11L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4816), "极差", false, "1星", 0.2m, null, 5, 3L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4816) },
                    { 12L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4817), "工作出色", false, "优", 1.0m, null, 1, 4L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4817) },
                    { 13L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4819), "工作良好", false, "良", 0.7m, null, 2, 4L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4819) },
                    { 14L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4820), "工作不到位", false, "差", 0.0m, null, 3, 4L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4820) },
                    { 15L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4821), "完全落实", false, "完全", 1.0m, null, 1, 6L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4822) },
                    { 16L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4823), "部分落实", false, "部分", 0.5m, null, 2, 6L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4823) },
                    { 17L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4824), "未开展", false, "未落实", 0.0m, null, 3, 6L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4824) }
                });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1807), "通用四级评分(A/B/C/D)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1962), new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1964), new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.InsertData(
                table: "scoring_templates",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 4L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1966), false, "三级评价(优/良/差)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1965) },
                    { 5L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1967), false, "百分比系数(100%-0%)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1966) },
                    { 6L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1972), false, "落实程度(完全/部分/未落实)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1971) },
                    { 7L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1973), false, "满意度调查(满意/一般/不满意)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1973) },
                    { 8L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1975), false, "达标情况(达标/基本达标/不达标)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1974) },
                    { 9L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1976), false, "存在问题(无/轻微/严重)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1976) },
                    { 10L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1978), false, "简单二元(1分/0分)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1978) }
                });

            migrationBuilder.InsertData(
                table: "spe_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(3992), 0, false, 100m, "河北省特教评价2025", 0, null, "0", null, 202501L, 0, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(3993) },
                    { 2L, "1", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(5139), 1, false, 20m, "办学方向", 0, 1L, "0,1", null, 202501L, 1, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(5139) },
                    { 3L, "1.1", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8084), 2, false, 10m, "坚持党的领导", 0, 2L, "0,1,2", 1L, 202501L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8085) },
                    { 4L, "1.2", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8252), 2, false, 10m, "立德树人根本任务", 0, 2L, "0,1,2", 1L, 202501L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8252) },
                    { 5L, "2", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8257), 1, false, 40m, "课程教学", 0, 1L, "0,1", null, 202501L, 1, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8257) },
                    { 6L, "2.1", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8265), 2, false, 15m, "课程设置规范性", 0, 5L, "0,1,5", 3L, 202501L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8266) },
                    { 7L, "2.2", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8279), 2, false, 15m, "个别化教育计划(IEP)", 0, 5L, "0,1,5", 1L, 202501L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8280) },
                    { 8L, "2.3", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8283), 2, false, 10m, "送教上门服务", 0, 5L, "0,1,5", 2L, 202501L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8283) },
                    { 9L, "3", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8286), 1, false, 40m, "教师队伍", 0, 1L, "0,1", null, 202501L, 1, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8286) },
                    { 10L, "3.1", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8289), 2, false, 20m, "师德师风建设", 0, 9L, "0,1,9", 6L, 202501L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8290) },
                    { 11L, "3.2", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8292), 2, false, 20m, "专业技能培训", 0, 9L, "0,1,9", 4L, 202501L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8293) },
                    { 12L, null, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8295), 0, false, 100m, "河北省特教评价2024(历史)", 0, null, "0", null, 202401L, 0, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8296) },
                    { 13L, "1", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8297), 1, false, 30m, "基础设施", 0, 12L, "0,12", null, 202401L, 1, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8297) },
                    { 14L, "1.1", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8300), 2, false, 15m, "无障碍设施", 0, 13L, "0,12,13", 2L, 202401L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8300) },
                    { 15L, "1.2", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8303), 2, false, 15m, "康复设备配置", 0, 13L, "0,12,13", 1L, 202401L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8303) },
                    { 16L, "2", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8306), 1, false, 70m, "经费保障", 0, 12L, "0,12", null, 202401L, 1, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8306) },
                    { 17L, "2.1", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8308), 2, false, 40m, "生均公用经费", 0, 16L, "0,12,16", 1L, 202401L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8309) },
                    { 18L, "2.2", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8312), 2, false, 30m, "专项补贴落实", 0, 16L, "0,12,16", 6L, 202401L, 4, new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8312) }
                });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 297, DateTimeKind.Utc).AddTicks(935), new DateTime(2025, 12, 12, 6, 52, 48, 297, DateTimeKind.Utc).AddTicks(1019) });

            migrationBuilder.InsertData(
                table: "sys_users",
                columns: new[] { "IDNumber", "CreatedAt", "IsDeleted", "OrgId", "OrgType", "Password", "Phone", "RealName", "Role", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "100000000000000000", new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1712), false, "330100_EDU", 3, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13900000003", "王专家", 1, new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1712), "expert3" },
                    { "111111111111111111", new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(615), false, "330100_EDU", 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000000", "超级管理员", 0, new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(618), "admin" },
                    { "222222222222222222", new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1692), false, "330100_EDU", 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000001", "杭州管理员", 0, new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1692), "hz_admin" },
                    { "333333333333333333", new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1695), false, "330106_EDU", 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000002", "西湖管理员", 0, new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1695), "xh_admin" },
                    { "444444444444444444", new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1697), false, "330108_EDU", 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000003", "滨江管理员", 0, new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1697), "bj_admin" },
                    { "555555555555555555", new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1699), false, "330106_SPE_01", 0, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000004", "紫荆花校长", 2, new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1699), "xh_spe_user" },
                    { "666666666666666666", new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1705), false, "330108_SPE_01", 0, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000005", "滨江特教校长", 2, new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1706), "bj_spe_user" },
                    { "777777777777777777", new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1707), false, "330106_INC_01", 1, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000006", "西湖一小校长", 2, new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1707), "xh_inc_user" },
                    { "888888888888888888", new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1708), false, "330100_EDU", 3, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13900000001", "张专家", 1, new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1709), "expert1" },
                    { "999999999999999999", new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1710), false, "330100_EDU", 3, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13900000002", "李专家", 1, new DateTime(2025, 12, 12, 6, 52, 48, 305, DateTimeKind.Utc).AddTicks(1710), "expert2" }
                });

            migrationBuilder.UpdateData(
                table: "task_evidences",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 285, DateTimeKind.Utc).AddTicks(2783), new DateTime(2025, 12, 12, 6, 52, 48, 285, DateTimeKind.Utc).AddTicks(2178) });

            migrationBuilder.InsertData(
                table: "tasks",
                columns: new[] { "Id", "BatchId", "CreatedAt", "FinalScore", "IsDeleted", "Status", "SubmittedAt", "TargetId", "TargetType", "TreeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1058), null, false, 2, null, "330106_SPE_01", 0, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 311, DateTimeKind.Utc).AddTicks(9908) },
                    { 2L, 1L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1388), null, false, 3, new DateTime(2025, 12, 12, 4, 52, 48, 312, DateTimeKind.Utc).AddTicks(1174), "330108_SPE_01", 0, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1172) },
                    { 3L, 2L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1390), null, false, 0, null, "130100_SPE_01", 0, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1389) },
                    { 4L, 2L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1392), null, false, 0, null, "130102_SPE_01", 0, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1391) },
                    { 5L, 4L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1501), 95.5m, false, 6, new DateTime(2024, 12, 17, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1394), "330106_SPE_01", 0, 202401L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1393) },
                    { 6L, 4L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1509), 88.0m, false, 6, new DateTime(2024, 12, 18, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1507), "330108_SPE_01", 0, 202401L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1506) },
                    { 7L, 4L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1512), 92.0m, false, 6, new DateTime(2024, 12, 19, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1511), "130100_SPE_01", 0, 202401L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1510) },
                    { 8L, 3L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1514), null, false, 1, null, "330106_INC_01", 1, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1513) },
                    { 9L, 7L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1516), null, false, 4, new DateTime(2025, 12, 11, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1516), "330106_INC_01", 1, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1515) },
                    { 10L, 1L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1520), null, false, 5, new DateTime(2025, 12, 11, 20, 52, 48, 312, DateTimeKind.Utc).AddTicks(1519), "130100_SPE_01", 0, 202501L, new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1518) }
                });
        }
    }
}
