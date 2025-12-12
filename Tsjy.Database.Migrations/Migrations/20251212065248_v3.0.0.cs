using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tsjy.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v300 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "edu_eval_nodes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "inc_eval_nodes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "123456789012345678");

            migrationBuilder.DeleteData(
                table: "sys_users",
                keyColumn: "IDNumber",
                keyValue: "123456789012345679");

            migrationBuilder.DropColumn(
                name: "DueAt",
                table: "tasks");

            migrationBuilder.DropColumn(
                name: "StartAt",
                table: "tasks");

            migrationBuilder.AddColumn<DateTime>(
                name: "DueAt",
                table: "distribution_batches",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartAt",
                table: "distribution_batches",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ai_pre_evaluations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 286, DateTimeKind.Utc).AddTicks(5624), new DateTime(2025, 12, 12, 6, 52, 48, 286, DateTimeKind.Utc).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "batch_targets",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "OrgId", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6883), "330106_SPE_01", new DateTime(2025, 12, 12, 6, 52, 48, 308, DateTimeKind.Utc).AddTicks(6519) });

            migrationBuilder.InsertData(
                table: "batch_targets",
                columns: new[] { "Id", "BatchId", "CreatedAt", "IsDeleted", "OrgId", "UpdatedAt" },
                values: new object[,]
                {
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
                keyValue: "330100_EDU",
                columns: new[] { "Address", "CreatedAt", "UpdatedAt" },
                values: new object[] { "杭州市xx路1号", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(3874), new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "330106_EDU",
                columns: new[] { "Address", "CreatedAt", "Phone", "UpdatedAt" },
                values: new object[] { "西湖区xx路2号", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5267), 88888881, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Code", "Address", "CreatedAt", "IncSchoolsNum", "IsDeleted", "Level", "Name", "OrgType", "Phone", "RegionCode", "SpeSchoolsNum", "UpdatedAt" },
                values: new object[,]
                {
                    { "130100_EDU", "石家庄xx路1号", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5272), 150L, false, 1, "石家庄市教育局", 2, 66666666, "130100", 10L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5272) },
                    { "130100_SPE_01", "石家庄市中心路", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5281), 0L, false, 1, "石家庄特教学校", 0, 66661111, "130100", 0L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5281) },
                    { "130102_EDU", "长安区xx路1号", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5274), 50L, false, 2, "长安区教育局", 2, 66666667, "130102", 3L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5274) },
                    { "130102_INC_01", "长安区建设路", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5287), 0L, false, 2, "石家庄长安一小", 1, 66662222, "130102", 0L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5288) },
                    { "130102_SPE_01", "长安区xx街道", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5282), 0L, false, 2, "长安区启智学校", 0, 66661112, "130102", 0L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5283) },
                    { "330106_INC_01", "西湖区保俶路", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5284), 0L, false, 2, "西湖区第一小学", 1, 87654321, "330106", 0L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5285) },
                    { "330106_SPE_01", "西湖区紫荆花路", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5278), 0L, false, 2, "杭州紫荆花学校", 0, 12345678, "330106", 0L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5278) },
                    { "330108_EDU", "滨江区xx路3号", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5270), 30L, false, 2, "滨江区教育局", 2, 88888882, "330108", 1L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5270) },
                    { "330108_INC_01", "滨江区江南大道", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5286), 0L, false, 2, "滨江实验小学", 1, 87654322, "330108", 0L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5286) },
                    { "330108_SPE_01", "滨江区江虹路", new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5279), 0L, false, 2, "杭州滨江特教学校", 0, 12345679, "330108", 0L, new DateTime(2025, 12, 12, 6, 52, 48, 229, DateTimeKind.Utc).AddTicks(5280) }
                });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "DueAt", "Name", "StartAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5772), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2025年度杭州特教普查", new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5258), new DateTime(2025, 12, 12, 6, 52, 48, 307, DateTimeKind.Utc).AddTicks(5261) });

            migrationBuilder.InsertData(
                table: "distribution_batches",
                columns: new[] { "Id", "CreatedAt", "DueAt", "IsDeleted", "Name", "StartAt", "Status", "TreeId", "UpdatedAt" },
                values: new object[,]
                {
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
                keyValue: "330000",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(3993), new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330100",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4424), new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "330106",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4425), new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4425) });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "Code", "CreatedAt", "IsDeleted", "Level", "Name", "ParentCode", "UpdatedAt" },
                values: new object[,]
                {
                    { "110000", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4436), false, 0, "北京市", null, new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4437) },
                    { "110101", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4437), false, 2, "东城区", "110000", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4438) },
                    { "130000", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4432), false, 0, "河北省", null, new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4432) },
                    { "130100", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4433), false, 1, "石家庄市", "130000", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4433) },
                    { "130102", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4434), false, 2, "长安区", "130100", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4434) },
                    { "130104", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4435), false, 2, "桥西区", "130100", new DateTime(2025, 12, 12, 6, 52, 48, 225, DateTimeKind.Utc).AddTicks(4436) },
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
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4098), "完全符合", new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4789), "基本符合", new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4791), "部分符合", new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4793), "不符合", new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.InsertData(
                table: "scoring_template_items",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "LevelCode", "Ratio", "ScoringModelId", "Sort", "TemplateId", "UpdatedAt" },
                values: new object[,]
                {
                    { 5L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4794), "符合要求", false, "是", 1.0m, null, 1, 2L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4795) },
                    { 6L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4798), "不符合要求", false, "否", 0.0m, null, 2, 2L, new DateTime(2025, 12, 12, 14, 52, 48, 274, DateTimeKind.Local).AddTicks(4799) },
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

            migrationBuilder.InsertData(
                table: "scoring_templates",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 2L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1962), false, "是否合格(是/否)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1961) },
                    { 3L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1964), false, "五星评价(1-5星)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1963) },
                    { 4L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1966), false, "三级评价(优/良/差)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1965) },
                    { 5L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1967), false, "百分比系数(100%-0%)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1966) },
                    { 6L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1972), false, "落实程度(完全/部分/未落实)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1971) },
                    { 7L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1973), false, "满意度调查(满意/一般/不满意)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1973) },
                    { 8L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1975), false, "达标情况(达标/基本达标/不达标)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1974) },
                    { 9L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1976), false, "存在问题(无/轻微/严重)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1976) },
                    { 10L, new DateTime(2025, 12, 12, 6, 52, 48, 273, DateTimeKind.Utc).AddTicks(1978), false, "简单二元(1分/0分)", new DateTime(2025, 12, 12, 14, 52, 48, 273, DateTimeKind.Local).AddTicks(1978) }
                });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(3992), new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(5139), new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "spe_eval_nodes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "MaxScore", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8084), 10m, "坚持党的领导", new DateTime(2025, 12, 12, 6, 52, 48, 277, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.InsertData(
                table: "spe_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "TargetId", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 52, 48, 312, DateTimeKind.Utc).AddTicks(1058), "330106_SPE_01", new DateTime(2025, 12, 12, 6, 52, 48, 311, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.InsertData(
                table: "tasks",
                columns: new[] { "Id", "BatchId", "CreatedAt", "FinalScore", "IsDeleted", "Status", "SubmittedAt", "TargetId", "TargetType", "TreeId", "UpdatedAt" },
                values: new object[,]
                {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "130100_EDU");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "130100_SPE_01");

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
                keyValue: "130102_SPE_01");

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
                keyValue: "110000");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "110101");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130000");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130100");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130102");

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Code",
                keyValue: "130104");

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
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 6L);

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
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 3L);

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

            migrationBuilder.DropColumn(
                name: "DueAt",
                table: "distribution_batches");

            migrationBuilder.DropColumn(
                name: "StartAt",
                table: "distribution_batches");

            migrationBuilder.AddColumn<DateTime>(
                name: "DueAt",
                table: "tasks",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartAt",
                table: "tasks",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                columns: new[] { "Address", "CreatedAt", "UpdatedAt" },
                values: new object[] { "杭州市某某路1号", new DateTime(2025, 12, 11, 1, 36, 59, 811, DateTimeKind.Utc).AddTicks(5430), new DateTime(2025, 12, 11, 1, 36, 59, 811, DateTimeKind.Utc).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Code",
                keyValue: "330106_EDU",
                columns: new[] { "Address", "CreatedAt", "Phone", "UpdatedAt" },
                values: new object[] { "西湖区某某路2号", new DateTime(2025, 12, 11, 1, 36, 59, 811, DateTimeKind.Utc).AddTicks(5526), 66666666, new DateTime(2025, 12, 11, 1, 36, 59, 811, DateTimeKind.Utc).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "distribution_batches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 899, DateTimeKind.Utc).AddTicks(300), "2025年度第一次普查", new DateTime(2025, 12, 11, 1, 36, 59, 898, DateTimeKind.Utc).AddTicks(9820) });

            migrationBuilder.InsertData(
                table: "edu_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2025, 12, 11, 1, 36, 59, 870, DateTimeKind.Utc).AddTicks(3894), 0, false, 100m, "河北省特教评价2025", 0, null, "0", null, 202501L, 0, new DateTime(2025, 12, 11, 1, 36, 59, 870, DateTimeKind.Utc).AddTicks(3895) },
                    { 2L, "1", new DateTime(2025, 12, 11, 1, 36, 59, 870, DateTimeKind.Utc).AddTicks(4913), 1, false, 20m, "办学方向", 0, 1L, "0,1", null, 202501L, 1, new DateTime(2025, 12, 11, 1, 36, 59, 870, DateTimeKind.Utc).AddTicks(4914) },
                    { 3L, "1.1", new DateTime(2025, 12, 11, 1, 36, 59, 870, DateTimeKind.Utc).AddTicks(5004), 2, false, 5m, "坚持办学方向", 0, 2L, "0,1,2", 1L, 202501L, 4, new DateTime(2025, 12, 11, 1, 36, 59, 870, DateTimeKind.Utc).AddTicks(5004) }
                });

            migrationBuilder.UpdateData(
                table: "expert_reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 881, DateTimeKind.Utc).AddTicks(659), new DateTime(2025, 12, 11, 1, 36, 59, 880, DateTimeKind.Utc).AddTicks(9951) });

            migrationBuilder.InsertData(
                table: "inc_eval_nodes",
                columns: new[] { "Id", "Code", "CreatedAt", "Depth", "IsDeleted", "MaxScore", "Name", "OrderIndex", "ParentId", "Path", "ScoringTemplateId", "TreeId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2025, 12, 11, 1, 36, 59, 868, DateTimeKind.Utc).AddTicks(3556), 0, false, 100m, "河北省特教评价2025", 0, null, "0", null, 202501L, 0, new DateTime(2025, 12, 11, 1, 36, 59, 868, DateTimeKind.Utc).AddTicks(3557) },
                    { 2L, "1", new DateTime(2025, 12, 11, 1, 36, 59, 868, DateTimeKind.Utc).AddTicks(4401), 1, false, 20m, "办学方向", 0, 1L, "0,1", null, 202501L, 1, new DateTime(2025, 12, 11, 1, 36, 59, 868, DateTimeKind.Utc).AddTicks(4402) },
                    { 3L, "1.1", new DateTime(2025, 12, 11, 1, 36, 59, 868, DateTimeKind.Utc).AddTicks(4487), 2, false, 5m, "坚持办学方向", 0, 2L, "0,1,2", 1L, 202501L, 4, new DateTime(2025, 12, 11, 1, 36, 59, 868, DateTimeKind.Utc).AddTicks(4488) }
                });

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
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 862, DateTimeKind.Utc).AddTicks(7200), "完全符合指标要求，佐证材料详实", new DateTime(2025, 12, 11, 9, 36, 59, 862, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 862, DateTimeKind.Utc).AddTicks(7307), "基本符合，存在少量非关键性缺失", new DateTime(2025, 12, 11, 9, 36, 59, 862, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 862, DateTimeKind.Utc).AddTicks(7309), "部分符合，存在明显问题或材料不足", new DateTime(2025, 12, 11, 9, 36, 59, 862, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "scoring_template_items",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 862, DateTimeKind.Utc).AddTicks(7311), "不符合要求或未开展此项工作", new DateTime(2025, 12, 11, 9, 36, 59, 862, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "scoring_templates",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 861, DateTimeKind.Utc).AddTicks(2785), "通用四级评分标准(A/B/C/D)", new DateTime(2025, 12, 11, 9, 36, 59, 861, DateTimeKind.Local).AddTicks(1997) });

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
                columns: new[] { "CreatedAt", "MaxScore", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 866, DateTimeKind.Utc).AddTicks(5085), 5m, "坚持办学方向", new DateTime(2025, 12, 11, 1, 36, 59, 866, DateTimeKind.Utc).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 36, 59, 888, DateTimeKind.Utc).AddTicks(1117), new DateTime(2025, 12, 11, 1, 36, 59, 888, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.InsertData(
                table: "sys_users",
                columns: new[] { "IDNumber", "CreatedAt", "IsDeleted", "OrgId", "OrgType", "Password", "Phone", "RealName", "Role", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "123456789012345678", new DateTime(2025, 12, 11, 1, 36, 59, 896, DateTimeKind.Utc).AddTicks(9991), false, "330100_EDU", 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000000", "超级管理员", 0, new DateTime(2025, 12, 11, 1, 36, 59, 897, DateTimeKind.Utc).AddTicks(96), "admin" },
                    { "123456789012345679", new DateTime(2025, 12, 11, 1, 36, 59, 897, DateTimeKind.Utc).AddTicks(325), false, "330106_EDU", 2, "7C4A8D09CA3762AF61E59520943DC26494F8941B", "13800000000", "超级管理员", 0, new DateTime(2025, 12, 11, 1, 36, 59, 897, DateTimeKind.Utc).AddTicks(326), "100" }
                });

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
    }
}
