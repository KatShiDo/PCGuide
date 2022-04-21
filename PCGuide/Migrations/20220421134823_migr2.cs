using Microsoft.EntityFrameworkCore.Migrations;

namespace PCGuide.Migrations
{
    public partial class migr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F113EC5E-FC39-41CD-8CD7-046E521C9A4C",
                column: "ConcurrencyStamp",
                value: "4ae99cd0-5a63-4ff8-a9cd-1440fb3a630e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F83A39C9-6960-4934-8CDC-88D0AAB64AAF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "524a7d9b-408e-467f-aec3-2980b46bca70", "AQAAAAEAACcQAAAAEGsbXKz6gwBB1ldglOFfrzEF/8s0RNWZvn1F2EOqA2e+qm7+BDUDBUGlx8C7KlLGIA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                table: "News");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F113EC5E-FC39-41CD-8CD7-046E521C9A4C",
                column: "ConcurrencyStamp",
                value: "f2149921-6e9f-4bbf-945d-ca5da7e58fda");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F83A39C9-6960-4934-8CDC-88D0AAB64AAF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f61f9a79-ae64-4ed7-b3e3-7895afba0997", "AQAAAAEAACcQAAAAEFWC3s2QY9xUAAaO142Cbxcj44SF8ZFA9j7dtELQmm/7e09+/vAVeH+lz4dYDKDAPw==" });
        }
    }
}
