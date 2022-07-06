using Microsoft.EntityFrameworkCore.Migrations;

namespace PCGuide.Migrations
{
    public partial class migr7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F113EC5E-FC39-41CD-8CD7-046E521C9A4C",
                column: "ConcurrencyStamp",
                value: "702e1e83-8e45-40f8-9d15-6ecb8a7698e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F83A39C9-6960-4934-8CDC-88D0AAB64AAF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61ef988f-f3fe-46a2-a57e-bfeba47d94e7", "AQAAAAEAACcQAAAAEEgrfJ2XGdAzmhS2Zn0R0Ig2XoZmghFSk5AYO1j17FpW6nZehjxUHqey1DQ84iCXjw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
