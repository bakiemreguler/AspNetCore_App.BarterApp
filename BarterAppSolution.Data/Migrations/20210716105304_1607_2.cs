using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarterAppSolution.Data.Migrations
{
    public partial class _1607_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppState",
                table: "LocationData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 7, 16, 13, 53, 3, 708, DateTimeKind.Local).AddTicks(4391), new DateTime(2021, 7, 16, 13, 53, 3, 708, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 7, 16, 13, 53, 3, 708, DateTimeKind.Local).AddTicks(4424), new DateTime(2021, 7, 16, 13, 53, 3, 708, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastLoginDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 7, 16, 13, 53, 3, 707, DateTimeKind.Local).AddTicks(22), new DateTime(2021, 7, 16, 13, 53, 3, 706, DateTimeKind.Local).AddTicks(8597), new DateTime(2021, 7, 16, 13, 53, 3, 707, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastLoginDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 7, 16, 13, 53, 3, 707, DateTimeKind.Local).AddTicks(1081), new DateTime(2021, 7, 16, 13, 53, 3, 707, DateTimeKind.Local).AddTicks(1048), new DateTime(2021, 7, 16, 13, 53, 3, 707, DateTimeKind.Local).AddTicks(1086) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppState",
                table: "LocationData");

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 7, 16, 13, 46, 12, 147, DateTimeKind.Local).AddTicks(8362), new DateTime(2021, 7, 16, 13, 46, 12, 147, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 7, 16, 13, 46, 12, 147, DateTimeKind.Local).AddTicks(8397), new DateTime(2021, 7, 16, 13, 46, 12, 147, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastLoginDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 7, 16, 13, 46, 12, 146, DateTimeKind.Local).AddTicks(4150), new DateTime(2021, 7, 16, 13, 46, 12, 146, DateTimeKind.Local).AddTicks(2737), new DateTime(2021, 7, 16, 13, 46, 12, 146, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastLoginDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 7, 16, 13, 46, 12, 146, DateTimeKind.Local).AddTicks(5144), new DateTime(2021, 7, 16, 13, 46, 12, 146, DateTimeKind.Local).AddTicks(5111), new DateTime(2021, 7, 16, 13, 46, 12, 146, DateTimeKind.Local).AddTicks(5150) });
        }
    }
}
