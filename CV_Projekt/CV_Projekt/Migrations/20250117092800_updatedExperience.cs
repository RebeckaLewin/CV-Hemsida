using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class updatedExperience : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Experiences",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa47c098-ce27-4fec-9ee6-cec8e0994038", "AQAAAAIAAYagAAAAEAWi0DP4pRjYI7mkDT+4cVzdvih/6DjxamxzDsRS7qmCqfQUiLicmE7KcpN2A/LwuQ==", "ea7116c2-a49c-4fd1-81ae-3b103d464e4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5ab0318-6953-42c8-a9e3-d0ca5791f73d", "AQAAAAIAAYagAAAAEFtkr9u8a+IlrSimfcXvNcR8KY69msVIpBm1Y+7aMvbeydxpMK98Gjp7vnVkVxapdQ==", "4714ffbe-1d86-4f26-bc93-1f2478771cea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e5a81d4-810a-460c-83b8-8ec03e511a0e", "AQAAAAIAAYagAAAAEGW+BCsH01ryDlNXOHnTzTolwR44UirdgQrvpItUnPqPV1H1i3hqGqF9VjcLsuBIxg==", "187a7557-3a31-4dd9-84f2-baf136ba79da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d7662f4-c004-4654-bcda-bf6830325e63", "AQAAAAIAAYagAAAAEGHX4JwsPQeffjgjuC9ZDnasxSu+K/h6AAB+Z0jkkJ5kYzv0GiwFGVqz+lq02Wh46g==", "a8e80163-abbe-48df-9209-d2c94c9f853b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e69c7016-b72e-4bf1-992c-c6e4fdf638a9", "AQAAAAIAAYagAAAAEIJgbsZh4DTpXiMPOGwlRC+gNJ8bHrYlE/8p36cOZ2IXWYpBIr3nvEsNx0CXzegsPA==", "8788c107-b2bc-4914-8220-7da91137e24a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29b6b3f2-b78e-4b4b-8c87-7c4dc76d248d", "AQAAAAIAAYagAAAAEFZEbG/oJMqXXw1OTPkjYTXrUTTkcMRRYe/hPR63OpZrpsft6dIDB7zgJQNjvphJfQ==", "7f69f691-b347-47ff-9ac8-2eb0408b734b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f921f03-d61c-4050-9725-a6b04313db80", "AQAAAAIAAYagAAAAEKnA1Nh4DUoE7yL7ziowYwvtyaUMPNx8qz2sS91TdhZGhhu8LAejtQfrFFJCJmmzZA==", "7afd33fb-7d9e-442f-9ec2-a760b97699c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47de5270-4de8-41ec-80aa-9476389dc9b2", "AQAAAAIAAYagAAAAEEqmTVa92AAyup4y05mKe7r5u59bSLRWTqjh3wTxeTVqQDY01s7n1BajKtd8Y830JQ==", "b9e3ed2a-00ed-49f8-a90e-6668cec54f15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e04723ff-93d3-4200-a2e2-7029f0cf41c5", "AQAAAAIAAYagAAAAEOVxEDBplrHmOsER/lJJVWqLqp5t52zBzy8PvioDpWPw3gjH1zoLvwEGYhhFVoGN1g==", "cedfdb1b-0da3-47fc-addc-8da2c9e95b44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8582fec7-d168-4cfe-9e40-60dfe7ab3eff", "AQAAAAIAAYagAAAAEOVjaj0OiACX7n5VAtlKzjw5uGdmnaA9Dd/n/pIN84EoD0tPB9WBgKIsFUoS+STUyQ==", "3982c045-e82d-412d-9332-02ea87688231" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e64103a-249d-40c7-81d2-b2c49b07460c", "AQAAAAIAAYagAAAAECeEQzP5Zlw91B9GHDGFmX5piDQ0gSohPtShADjFFjidiykHvv1I6YDNcksc8DZk9Q==", "0b2e2c04-f825-45e9-891c-cc2714c1182a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f05df6f7-3ec9-4bfc-b994-88b2844f3cf4", "AQAAAAIAAYagAAAAEP1Quvy1UH9jcX+AkZe946LyAYvwtVM2bFz1mEfouwYE9rB8cQIln0/DURC40CS/Vw==", "5cf004d4-aed5-4e28-889a-4c9d00213c7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47117bd6-a75d-40e1-b008-bd58cc0fc29b", "AQAAAAIAAYagAAAAEHycdinMLi+Mmkzf3hhvOkDgocHyFfyCZFuD7Rk2PwN/k8LBL4vwKdBQQ5O6h2dJmQ==", "8c0a979a-2a06-4e48-bf1c-049adf306b8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5902743e-5ecf-4ba3-8e63-881228dbfbbe", "AQAAAAIAAYagAAAAEL4XxeVEle3otGhKb8mvPekSjtJzPEFmv9lGA5aMBNiL/GMEQskcFE20PVlG6DH/KQ==", "dfbebd97-62ca-43f9-af5b-9bb847f6d298" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99a13eb4-9bbe-489f-919d-bf67d4bcd27c", "AQAAAAIAAYagAAAAEDsPI5yAzo0pPgTQm80yD2h8DYi14xvGEVmnSNCCsHj5aNBt0VDOkl9kwqveq9qlnw==", "2d9a465d-f071-4637-ba31-30589c3f51b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d962b29-c82a-4deb-9481-4cfb9431da07", "AQAAAAIAAYagAAAAEGI63rRhj2xaP/OmsLrzHrH5JXSNrYxcalWn0/1OSgQRuVxBv34uElQ0wgM0iTgatQ==", "dc517f9d-75e1-4496-8510-17069a0f7371" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1be53c9-708c-4ca1-8d4e-eb058e0b8356", "AQAAAAIAAYagAAAAEDLin502WusdKI3Wh8tSLKO+TiZU9aKUdMnEhBrOXoEw9pI7b2KHLpFGOlG9ndZZgQ==", "35993e76-b7fe-4229-8a23-d1c0357a910b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a707aec4-bff9-414a-b656-ee48a6a1637c", "AQAAAAIAAYagAAAAELISlKLegtquXxgSqCdckfWtsRNmOGScXmZZG1qiUTQLoQA8H4hgyOYPq5yA982p0A==", "f5368d58-0a00-4eb9-93ae-f5b0983f6fcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e8e20e5-5a3f-4461-bd54-7d327fee0007", "AQAAAAIAAYagAAAAEMHdq8IEB1Q0hmBx/yUJnOcDJTMvu6a5D5ciGmcpb+c/Dx3DTB1EhqMEDvcrRfVqiw==", "be152f3f-2a34-42cd-9ee2-b32f7b297df8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea5550ee-ea71-41e3-8729-75f5e01aafdf", "AQAAAAIAAYagAAAAEJAkTGnt8DuCHwi8k54qcd6whnp3FVDfXZ6sVnR7a/q6z8bMNlWHwy0P3a1QiULf+A==", "14101ea0-5a26-4d0f-86c1-b664470bb223" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 4,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 5,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 6,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 7,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 8,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 9,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 10,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 12,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 14,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 16,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 17,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 18,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 19,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 21,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 22,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 23,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 24,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 25,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 26,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 27,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 28,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 29,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 30,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 32,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 34,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 35,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 36,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 37,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 38,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 39,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 40,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 41,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 42,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 43,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 44,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 45,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 46,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 47,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 48,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 49,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 50,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 51,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 52,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 53,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 54,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 55,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 56,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 57,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 58,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 59,
                column: "EndDate",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Experiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d125eeef-ef4b-4369-807a-b9b9b8ea8824", "AQAAAAIAAYagAAAAEDX0xF9XnygUUhP7xWrd7xyxFdNUI/aQbXDmTRDfffsl4qcv4yjLN/UJE/a5DwD+Cw==", "03d20bcb-083a-4857-9d7e-3bbfca7d1323" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56b4340e-b744-4bf7-8d8d-3f2d223c0a8b", "AQAAAAIAAYagAAAAELS3riOYDpiofKkh/M2P9ys/6Y9tJsTDCOcfWEvu1eCRUujDA7y7BmuGjJAvp9TDEQ==", "f9b27970-6d9b-4aa3-b97c-f5fb5852ea73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37535e35-2397-4394-9e75-ead8139c9e79", "AQAAAAIAAYagAAAAEPVNxkK/EkbBNjfHpZyqi9c4LPo+tDqvrlYlNrntrh2J50agZ8+NbM+PA7trKWNfdQ==", "c051dcee-d8d4-41ba-a12f-073c0ee8f49f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfad9971-f54f-4e02-83af-d04566287dbd", "AQAAAAIAAYagAAAAEKB7Bop1uiagUjQz0qxf5eO4SYGrjMl0E1Z1qOdYCotz4Cnk6KOAa8kJaEZT6reQXQ==", "58413727-f204-4e37-8396-6694b9fd30af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a9bf61e-5548-4ce3-b721-f86abb90de70", "AQAAAAIAAYagAAAAEEzOFQikeebEI8RPS2ZRIBvK/sUYhe4Y63RclsZyDf8GeUEtLxnxlyubhb+uQszERA==", "f8f6332e-64e9-4162-9fb6-1fb3e9b5ed8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9415be7c-59c7-47d5-93bf-0d2253739567", "AQAAAAIAAYagAAAAEJuhRPOKLY3lmHrUUaH5PrVGm5lXyt8ixx54bx0s5yn7Q13vdNRjmA+C4F+PsV9/GQ==", "edfc0992-4080-4566-b5d8-92fa2b6acf8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ee7df28-9ed6-42ba-b5c9-05d5b5e1db6b", "AQAAAAIAAYagAAAAEKN/Hx8+ybgugnINS/CWFYpsKnxPali3paEqmxhOgFKAbDgXy4c04E2cUM0uXY92Kw==", "914762d6-8dcc-4f53-999a-74391fa7448b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b277cd6f-8000-403d-920f-0af7e1df86d8", "AQAAAAIAAYagAAAAEJ6Xc+CHf7Tno4qaXAKm4/3f2AhEELdUAUP6Iw6jW2q27oHPRvL7hng8RfRc2STxyA==", "1f53e788-804f-43e3-957d-bd960637afe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ec05370-2ba1-4f35-90ae-965caa04dd40", "AQAAAAIAAYagAAAAEIy5PIH6CiD7hkQKbG4ARorjkcJPtHtu1CmfkNV6xQcdq+GdTprZP1t0wGm1rhiMGg==", "5fae1068-dd3f-40e8-8e76-ab83d0a2664d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8e54626-3a69-4c2a-ac72-d2283ca38f61", "AQAAAAIAAYagAAAAEKtFz1I6NaCxFIlp54cAYx9B4BxUzDi2oXSMl7Izw53tielP+fUCS7pVfhYSDhs7wA==", "7489a159-5861-4735-9bea-195bef60c80f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27a510b6-11ed-4f48-8632-dbfd530269f7", "AQAAAAIAAYagAAAAEJmzK60wEDKXrcZL1zPymyLH9RtjhDRJEJGHdHwwayBwqgs30xL/rV7Z4Pihsc8p8g==", "b600cc27-9b69-4ee2-8e13-6476a6658bf5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1048532f-66e1-456b-9e56-f40d3203e735", "AQAAAAIAAYagAAAAEGAymT/npIAh37+PNbiIkRegC/viHs/n6/JAGu0RacF+NXAIrHsSSUCoU9rQg3Gicw==", "bf3c7a3b-c3a9-4088-a984-9aa9b6bd9244" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36443119-4741-435e-bc98-964ed2fe94a1", "AQAAAAIAAYagAAAAELycj/NUZpPyDMBZkpHPexPsAYvfuJLIukUGa8Xlbl4y4RzJ/B2lgGupVXTmAo36wA==", "558fab0c-9f19-4e7f-b925-309de49474e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ffdca9c-6444-4504-81ec-2c62f646d4bc", "AQAAAAIAAYagAAAAEHisZ4dPVsXh/VwWgc5h3EBUxWgPtsRFOh2bSecGifeuax0OX3WKdF4Xla02jfaS3Q==", "37fb5390-c5a8-465d-907e-59cf61490d67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e52d893-cf3a-432a-b7ac-bba74e6eeea1", "AQAAAAIAAYagAAAAEPdK3jjSLZH+7zvey/zt9Nfvu8Nqtt4XJr7NZjw+DRoN7Wvz+xwXuIeS0KLKbIKv0w==", "dc4902f1-4fa0-4d2b-a86f-78ca311324b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fd24d01-98ef-4a2f-a70d-4c3592a1eb30", "AQAAAAIAAYagAAAAEFu2tatUEwybCIhsom+58WbOP8KGETZ2gxB1imfo9Xw/YtwJi2R5TJtWUG9fNjOR1w==", "63eeff07-37b8-46da-8028-d8ad1dd36bc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22c19a11-0ff3-4c64-aa01-0649645cd339", "AQAAAAIAAYagAAAAEHQy/06O4yYbscllagDzttCJKvr2N1DeSpLoLBJaouVdQoJ1MpsvrxK9cvXrsFQmVg==", "4e91363e-a296-40e8-91b5-9872d96ee716" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8778504-a5a5-42ae-af1c-f62290b1ba75", "AQAAAAIAAYagAAAAEOLErQ6cQqzc4uX6odXY6AB6l2EDV93d1gibLfcYEvifVTm4mUjMv723UZ6Jm8nz0g==", "87a3d308-b161-4195-9125-fd538c5ae431" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bac5cf09-b9c9-4920-bca1-724f8a1caeda", "AQAAAAIAAYagAAAAEMjQyzvug8hI5XLyIwoL2m07AWu3MpQbha0XXNHz9XXlQWW3BUaWH+crgIHLen4m2w==", "9d42d615-c651-429d-a936-2d63ebba5339" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d422e71-0548-4644-b893-7062885fa10c", "AQAAAAIAAYagAAAAEHyPNmNFpdsQoXcZMx+dayity5LHGWHqwRJD/j6bKnBTErpZ203hd7xotUTEvCyS2A==", "5955b643-02b6-4313-a58b-3b05a13dcb57" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 3,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 4,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 5,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 6,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 7,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 8,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 9,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 10,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 12,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 14,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 16,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 17,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 18,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 19,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 21,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 22,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 23,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 24,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 25,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 26,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 27,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 28,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 29,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 30,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 32,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 34,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 35,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 36,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 37,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 38,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 39,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 40,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 41,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 42,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 43,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 44,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 45,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 46,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 47,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 48,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 49,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 50,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 51,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 52,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 53,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 54,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 55,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 56,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 57,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 58,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 59,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
