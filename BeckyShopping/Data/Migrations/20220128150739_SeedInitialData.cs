using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeckyShopping.Data.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 1, 28, 15, 7, 38, 253, DateTimeKind.Utc).AddTicks(9909));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 1, 28, 13, 35, 47, 46, DateTimeKind.Utc).AddTicks(8987));
        }
    }
}
