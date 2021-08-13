using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarterAppSolution.Data.Migrations
{
    public partial class _15072021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocationData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationData", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationData");

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 2, 12, 16, 25, 49, 589, DateTimeKind.Local).AddTicks(6024), new DateTime(2021, 2, 12, 16, 25, 49, 589, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 2, 12, 16, 25, 49, 589, DateTimeKind.Local).AddTicks(6210), new DateTime(2021, 2, 12, 16, 25, 49, 589, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastLoginDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 2, 12, 16, 25, 49, 587, DateTimeKind.Local).AddTicks(1344), new DateTime(2021, 2, 12, 16, 25, 49, 586, DateTimeKind.Local).AddTicks(9369), new DateTime(2021, 2, 12, 16, 25, 49, 587, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastLoginDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 2, 12, 16, 25, 49, 587, DateTimeKind.Local).AddTicks(2743), new DateTime(2021, 2, 12, 16, 25, 49, 587, DateTimeKind.Local).AddTicks(2707), new DateTime(2021, 2, 12, 16, 25, 49, 587, DateTimeKind.Local).AddTicks(2751) });
        }
    }
}
