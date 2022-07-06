using Microsoft.EntityFrameworkCore.Migrations;

namespace PCGuide.Migrations
{
    public partial class migr5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F113EC5E-FC39-41CD-8CD7-046E521C9A4C",
                column: "ConcurrencyStamp",
                value: "84546c1f-05ee-48e4-aa6d-cfc8c30d9ea0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F83A39C9-6960-4934-8CDC-88D0AAB64AAF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "93b786ab-f9cf-4a63-abf9-f71f7ffbb878", "AQAAAAEAACcQAAAAEHZPCFgDXbeMUskjFsco0hcPj3hIcUzb3nQDFlepihCf2jiJIzaZKrkzT7VxRmHNIw==" });
        }
    }
}
