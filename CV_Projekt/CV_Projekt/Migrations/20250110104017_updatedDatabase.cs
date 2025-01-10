using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class updatedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1dd6b93b-19f0-4a12-ba4c-763be6abbc2c", "51a6cdd0-9db2-44c8-a70c-07c767dc566e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c013bbf-8dc7-4e2e-8944-090116a0651b", "ebd1a228-ad38-4153-967b-266a79636454" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a084b898-92fc-47c3-8dbe-a0a1e102f9f5", "75f5c428-e71f-426c-a728-717466ae8b75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0133f9d6-29cf-46cb-b2d2-711e09114e69", "fd89cbab-a9fd-45df-9bcf-5bb1e2853ae3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "75071aa0-5bf5-495a-a87c-26b01ac01e2d", "1e7d4b3f-6e77-4f29-94d4-1a9fb2c74325" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0278ceb-15c9-4629-889c-cb375923a1ac", "af432105-eb94-49b1-8d65-ab94f57d90eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "73e17a18-c777-4a7a-acca-03deba22f78c", "12c01ae0-cf1e-4739-aa6b-5aa05c2d8f74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca894931-50f4-4d1b-896a-3adaafb830bf", "29be0d39-f7d9-4b2a-91b3-05cfffc95789" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "467cbb25-197e-495c-9c33-037df0b11685", "786ec99b-0a3b-4c94-bf88-e7df363e768c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6f1858c-3b05-4c8c-bf33-ce53313da37f", "8cbb839c-7bcf-470b-bee4-4a42c48adde5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3a025e52-8bd4-4c3d-8b18-ad52b675cfd8", "020b4926-4011-4055-9673-6af6eed66b2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "30c2a46f-2917-41ca-a2dc-698c7feef951", "90df8617-04a8-4f0c-ab4f-30dd5d1b3616" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8bae7dce-b0c4-49c3-a6e9-35aab74223bf", "ec7fd55a-a06b-49de-981a-8aa88346e617" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7e6f7f9-5a17-4c8f-a642-98e418a006a0", "2e2de5c7-029f-48da-8c1e-e21215a1f952" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8f08276-51b0-4b9c-abd1-6c17d2c756f3", "2b9aa51b-a8d0-42fb-891b-160b724be6a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f6ab7dd-2737-46d1-9ff4-4f38c7f66567", "7fcb5256-85c7-423b-a905-cc2e7b544e69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aaf0f7c0-cd56-4803-ba8e-449054604b33", "f4c1b34f-d307-4a1b-8849-f686600e355c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5840bee-02f6-40c7-81c9-1b10c266221e", "719d0613-b097-4999-9db8-93f50c1b7de3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24e791d0-8f0b-4f5f-91c8-31414025acd8", "3f83e834-d979-489b-b134-63d2765d1d88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0127ab32-c71a-4d59-ab30-f98687cb4e74", "a8dc1b33-0fac-4d13-bb03-93b00f0b648e" });
        }
    }
}
