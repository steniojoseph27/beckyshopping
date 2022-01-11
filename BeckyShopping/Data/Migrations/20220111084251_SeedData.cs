using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeckyShopping.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 1, 11, 8, 42, 51, 6, DateTimeKind.Utc).AddTicks(2797));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 1, 11, 8, 35, 35, 604, DateTimeKind.Utc).AddTicks(8069));
        }
    }
}
