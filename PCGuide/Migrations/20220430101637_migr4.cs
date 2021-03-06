using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PCGuide.Migrations
{
    public partial class migr4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CPUCoolerUser",
                columns: table => new
                {
                    FavouriteCPUCoolersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUCoolerUser", x => new { x.FavouriteCPUCoolersId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_CPUCoolerUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUCoolerUser_CPUCoolers_FavouriteCPUCoolersId",
                        column: x => x.FavouriteCPUCoolersId,
                        principalTable: "CPUCoolers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CPUUser",
                columns: table => new
                {
                    FavouriteCPUsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUUser", x => new { x.FavouriteCPUsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_CPUUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUUser_CPUs_FavouriteCPUsId",
                        column: x => x.FavouriteCPUsId,
                        principalTable: "CPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FrameUser",
                columns: table => new
                {
                    FavouriteFramesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameUser", x => new { x.FavouriteFramesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_FrameUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FrameUser_Frames_FavouriteFramesId",
                        column: x => x.FavouriteFramesId,
                        principalTable: "Frames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GPUUser",
                columns: table => new
                {
                    FavouriteGPUsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUUser", x => new { x.FavouriteGPUsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_GPUUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GPUUser_GPUs_FavouriteGPUsId",
                        column: x => x.FavouriteGPUsId,
                        principalTable: "GPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HardDriveUser",
                columns: table => new
                {
                    FavouriteHardDrivesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardDriveUser", x => new { x.FavouriteHardDrivesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_HardDriveUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HardDriveUser_HardDrives_FavouriteHardDrivesId",
                        column: x => x.FavouriteHardDrivesId,
                        principalTable: "HardDrives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotherboardUser",
                columns: table => new
                {
                    FavouriteMotherboardsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotherboardUser", x => new { x.FavouriteMotherboardsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MotherboardUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotherboardUser_Motherboards_FavouriteMotherboardsId",
                        column: x => x.FavouriteMotherboardsId,
                        principalTable: "Motherboards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PowerUnitUser",
                columns: table => new
                {
                    FavouritePowerUnitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerUnitUser", x => new { x.FavouritePowerUnitsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_PowerUnitUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PowerUnitUser_PowerUnits_FavouritePowerUnitsId",
                        column: x => x.FavouritePowerUnitsId,
                        principalTable: "PowerUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RAMUser",
                columns: table => new
                {
                    FavouriteRAMId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMUser", x => new { x.FavouriteRAMId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RAMUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RAMUser_RAM_FavouriteRAMId",
                        column: x => x.FavouriteRAMId,
                        principalTable: "RAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SSDUser",
                columns: table => new
                {
                    FavouriteSSDId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSDUser", x => new { x.FavouriteSSDId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_SSDUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SSDUser_SSDs_FavouriteSSDId",
                        column: x => x.FavouriteSSDId,
                        principalTable: "SSDs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("ebaa3373-f6ac-4ef8-a7ec-daab4f4fe3a9"),
                columns: new[] { "CodeWord", "Title" },
                values: new object[] { "PageAccount", "Аккаунт" });

            migrationBuilder.CreateIndex(
                name: "IX_CPUCoolerUser_UsersId",
                table: "CPUCoolerUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUUser_UsersId",
                table: "CPUUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_FrameUser_UsersId",
                table: "FrameUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_GPUUser_UsersId",
                table: "GPUUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_HardDriveUser_UsersId",
                table: "HardDriveUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_MotherboardUser_UsersId",
                table: "MotherboardUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_PowerUnitUser_UsersId",
                table: "PowerUnitUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMUser_UsersId",
                table: "RAMUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_SSDUser_UsersId",
                table: "SSDUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CPUCoolerUser");

            migrationBuilder.DropTable(
                name: "CPUUser");

            migrationBuilder.DropTable(
                name: "FrameUser");

            migrationBuilder.DropTable(
                name: "GPUUser");

            migrationBuilder.DropTable(
                name: "HardDriveUser");

            migrationBuilder.DropTable(
                name: "MotherboardUser");

            migrationBuilder.DropTable(
                name: "PowerUnitUser");

            migrationBuilder.DropTable(
                name: "RAMUser");

            migrationBuilder.DropTable(
                name: "SSDUser");

            migrationBuilder.DropColumn(
                name: "DateCreate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "AspNetUsers");

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
    }
}
