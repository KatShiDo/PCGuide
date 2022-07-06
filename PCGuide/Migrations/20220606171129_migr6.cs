using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PCGuide.Migrations
{
    public partial class migr6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F113EC5E-FC39-41CD-8CD7-046E521C9A4C",
                column: "ConcurrencyStamp",
                value: "7b56b20b-ac00-4097-89af-492c464d3664");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F83A39C9-6960-4934-8CDC-88D0AAB64AAF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdfc8998-a63b-4638-9461-60ee352d1b45", "AQAAAAEAACcQAAAAEKQU2/4QrCtymgjZQi3OVGiY4Jxs++3CoGCjbqPGQt7+pJ5Jit//MysYgOniWAzQ+g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F113EC5E-FC39-41CD-8CD7-046E521C9A4C",
                column: "ConcurrencyStamp",
                value: "3972c99f-a068-45e7-a5b3-0e8c24ddf641");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F83A39C9-6960-4934-8CDC-88D0AAB64AAF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88a13bcb-fa17-4ef0-a93b-6d161bd01f13", "AQAAAAEAACcQAAAAELTC2MVcwpdcGScsdhs0FzDWmwQP2dnkw4ndnjw0ed4DZkCFxKkbJXCmWXOqFtW/Gw==" });
        }
    }
}
