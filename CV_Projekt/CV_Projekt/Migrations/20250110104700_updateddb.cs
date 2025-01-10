using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class updateddb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ReceiverHasDeleted",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SenderHasDeleted",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "178e31a7-700e-464f-85bb-8b47bb1776fc", "4dceaa26-673a-40fd-805a-634faee85d48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56bcae09-8f37-4835-a8e8-e50d3b41545b", "f9879378-0ba7-4861-b64e-e54184adff0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "59e66458-1bbe-40c9-8656-8ff05842c55d", "f85063f9-934f-4991-8b04-16fb818b82b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bc0301b5-ee55-427b-a413-cd73e5b12b16", "711265e5-fa90-4df8-97c7-e038a51d45ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82561167-462f-45b7-8da6-76771dc7699a", "7d204277-1ad1-4786-ba1f-54c68cf4deff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f4a06e98-a6ea-4256-88db-98f041b98c3d", "0d7ffd49-cef3-4af4-a52b-ad9e8ae78fe8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63094aec-31ad-4fa7-8d07-05c92734d9f7", "e91f1ed0-a7ff-4f4f-82fb-fddedffaf3fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "69e5a7c2-59e3-494a-985e-25079400949a", "ab955ce1-bf2d-4a7d-beb6-98a3a21eea78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c462bce4-21fb-4b3c-bca2-910d46952564", "0521db1f-3d51-42cb-8c27-f8b9d2238bf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9d19ddd-f206-4327-9497-f3f0ed53b39e", "fb60a30e-e025-4bbf-8be2-d2d5f9fe886c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ReceiverHasDeleted", "SenderHasDeleted" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ReceiverHasDeleted", "SenderHasDeleted" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ReceiverHasDeleted", "SenderHasDeleted" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ReceiverHasDeleted", "SenderHasDeleted" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ReceiverHasDeleted", "SenderHasDeleted" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ReceiverHasDeleted", "SenderHasDeleted" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ReceiverHasDeleted", "SenderHasDeleted" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ReceiverHasDeleted", "SenderHasDeleted" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ReceiverHasDeleted", "SenderHasDeleted" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ReceiverHasDeleted", "SenderHasDeleted" },
                values: new object[] { false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverHasDeleted",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderHasDeleted",
                table: "Messages");

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
    }
}
