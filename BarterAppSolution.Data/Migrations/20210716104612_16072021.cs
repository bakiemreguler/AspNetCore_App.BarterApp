using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarterAppSolution.Data.Migrations
{
    public partial class _16072021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeviceMac",
                table: "LocationData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeviceTitle",
                table: "LocationData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Explanation",
                table: "LocationData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceTitle",
                table: "LocationData",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeviceMac",
                table: "LocationData");

            migrationBuilder.DropColumn(
                name: "DeviceTitle",
                table: "LocationData");

            migrationBuilder.DropColumn(
                name: "Explanation",
                table: "LocationData");

            migrationBuilder.DropColumn(
                name: "ServiceTitle",
                table: "LocationData");

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 7, 15, 20, 16, 41, 949, DateTimeKind.Local).AddTicks(7285), new DateTime(2021, 7, 15, 20, 16, 41, 949, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 7, 15, 20, 16, 41, 949, DateTimeKind.Local).AddTicks(7316), new DateTime(2021, 7, 15, 20, 16, 41, 949, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastLoginDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 7, 15, 20, 16, 41, 948, DateTimeKind.Local).AddTicks(3980), new DateTime(2021, 7, 15, 20, 16, 41, 948, DateTimeKind.Local).AddTicks(2623), new DateTime(2021, 7, 15, 20, 16, 41, 948, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastLoginDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 7, 15, 20, 16, 41, 948, DateTimeKind.Local).AddTicks(4934), new DateTime(2021, 7, 15, 20, 16, 41, 948, DateTimeKind.Local).AddTicks(4902), new DateTime(2021, 7, 15, 20, 16, 41, 948, DateTimeKind.Local).AddTicks(4939) });
        }
    }
}
