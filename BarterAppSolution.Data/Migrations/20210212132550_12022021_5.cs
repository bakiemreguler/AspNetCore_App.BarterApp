using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarterAppSolution.Data.Migrations
{
    public partial class _12022021_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Application = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Callsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Logged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Logger = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 2, 12, 14, 31, 52, 660, DateTimeKind.Local).AddTicks(9985), new DateTime(2021, 2, 12, 14, 31, 52, 660, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 2, 12, 14, 31, 52, 661, DateTimeKind.Local).AddTicks(83), new DateTime(2021, 2, 12, 14, 31, 52, 661, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastLoginDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 2, 12, 14, 31, 52, 657, DateTimeKind.Local).AddTicks(2902), new DateTime(2021, 2, 12, 14, 31, 52, 656, DateTimeKind.Local).AddTicks(8725), new DateTime(2021, 2, 12, 14, 31, 52, 657, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastLoginDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 2, 12, 14, 31, 52, 657, DateTimeKind.Local).AddTicks(5682), new DateTime(2021, 2, 12, 14, 31, 52, 657, DateTimeKind.Local).AddTicks(5609), new DateTime(2021, 2, 12, 14, 31, 52, 657, DateTimeKind.Local).AddTicks(5704) });
        }
    }
}
