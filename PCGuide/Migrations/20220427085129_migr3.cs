using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PCGuide.Migrations
{
    public partial class migr3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Delays",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "L1CacheCapacity",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "L2CachCapacity",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "L3CacheCapacity",
                table: "CPUs");

            migrationBuilder.RenameColumn(
                name: "Memory",
                table: "SSDs",
                newName: "MemoryCapacity");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "SSDs",
                newName: "ImageData");

            migrationBuilder.RenameColumn(
                name: "Memory",
                table: "RAM",
                newName: "MemoryCapacity");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "RAM",
                newName: "ImageData");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "PowerUnits",
                newName: "ImageData");

            migrationBuilder.RenameColumn(
                name: "Tags",
                table: "News",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "News",
                newName: "TagsString");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "News",
                newName: "ImageData");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Motherboards",
                newName: "ImageData");

            migrationBuilder.RenameColumn(
                name: "Memory",
                table: "HardDrives",
                newName: "MemoryCapacity");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "HardDrives",
                newName: "ImageData");

            migrationBuilder.RenameColumn(
                name: "Memory",
                table: "GPUs",
                newName: "MemoryCapacity");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "GPUs",
                newName: "ImageData");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Frames",
                newName: "ImageData");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "CPUs",
                newName: "ImageData");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "CPUCoolers",
                newName: "ImageData");

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "WriteSpeed",
                table: "SSDs",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "ReadSpeed",
                table: "SSDs",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Company",
                table: "SSDs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "ClockSpeed",
                table: "RAM",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Company",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Delay",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Company",
                table: "PowerUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Socket",
                table: "Motherboards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Chipset",
                table: "Motherboards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Company",
                table: "Motherboards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Company",
                table: "HardDrives",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TechnicalProcess",
                table: "GPUs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "ClockSpeed",
                table: "GPUs",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Company",
                table: "GPUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "GPUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Company",
                table: "Frames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TechnicalProcess",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Socket",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Series",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IntegratedGraphics",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Company",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "ClockSpeed",
                table: "CPUs",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "BoostClockSpeed",
                table: "CPUs",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CacheCapacity",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Company",
                table: "CPUCoolers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F113EC5E-FC39-41CD-8CD7-046E521C9A4C",
                column: "ConcurrencyStamp",
                value: "d7276dc1-7fcd-4379-8739-13f3090062f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "F83A39C9-6960-4934-8CDC-88D0AAB64AAF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5089fb7-2e5f-43fb-9df6-d98ab2683f47", "AQAAAAEAACcQAAAAEJK0XrF75ruKCI58GpFWB9Qgm2EW6tLu5f1/BAQN87pn5Br7671LrKBMljAX4o1VVA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("ebaa3373-f6ac-4ef8-a7ec-daab4f4fe3a9"),
                columns: new[] { "CodeWord", "Title" },
                values: new object[] { "PageFeedback", "Обратная связь" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "MetaTitle",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "SSDs");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "Delay",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "PowerUnits");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Motherboards");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "HardDrives");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "GPUs");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "GPUs");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Frames");

            migrationBuilder.DropColumn(
                name: "CacheCapacity",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "CPUCoolers");

            migrationBuilder.RenameColumn(
                name: "MemoryCapacity",
                table: "SSDs",
                newName: "Memory");

            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "SSDs",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "MemoryCapacity",
                table: "RAM",
                newName: "Memory");

            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "RAM",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "PowerUnits",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "News",
                newName: "Tags");

            migrationBuilder.RenameColumn(
                name: "TagsString",
                table: "News",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "News",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "Motherboards",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "MemoryCapacity",
                table: "HardDrives",
                newName: "Memory");

            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "HardDrives",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "MemoryCapacity",
                table: "GPUs",
                newName: "Memory");

            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "GPUs",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "Frames",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "CPUs",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "CPUCoolers",
                newName: "Image");

            migrationBuilder.AlterColumn<int>(
                name: "WriteSpeed",
                table: "SSDs",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "ReadSpeed",
                table: "SSDs",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "ClockSpeed",
                table: "RAM",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "Delays",
                table: "RAM",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Socket",
                table: "Motherboards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Chipset",
                table: "Motherboards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TechnicalProcess",
                table: "GPUs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClockSpeed",
                table: "GPUs",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "TechnicalProcess",
                table: "CPUs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Socket",
                table: "CPUs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Series",
                table: "CPUs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "IntegratedGraphics",
                table: "CPUs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Company",
                table: "CPUs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "ClockSpeed",
                table: "CPUs",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "BoostClockSpeed",
                table: "CPUs",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<double>(
                name: "L1CacheCapacity",
                table: "CPUs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "L2CachCapacity",
                table: "CPUs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "L3CacheCapacity",
                table: "CPUs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("ebaa3373-f6ac-4ef8-a7ec-daab4f4fe3a9"),
                columns: new[] { "CodeWord", "Title" },
                values: new object[] { "PageInfo", "Сведения" });
        }
    }
}
