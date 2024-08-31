using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UrlShortener.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LongUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urls_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", null, "Administrator", "ADMINISTRATOR" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "37bb0930-ee5b-483a-88a9-9fc2dab9a087", 0, "d5bce268-3155-4ead-a312-8a7e9f312b13", "user@localhost.com", true, false, null, "USER@LOCALHOST.COM", "USER", "AQAAAAIAAYagAAAAECUxnzhAtOwsINVt9gA2Vv8416J5zLgkh+BvImyWSmXCF+1+zp3EG94oKI8QQfLf2w==", null, false, "c4cc5963-4a45-4a5c-8a5d-7a57adb0db9c", false, "user" },
                    { "37bb0930-ee5b-483a-88a9-9fc2dab9a903", 0, "d51b9a03-e023-4a70-a67f-f46646036365", "user2@localhost.com", true, false, null, "USER2@LOCALHOST.COM", "USER2", "AQAAAAIAAYagAAAAELHtygJGaB2KLgNNaYZlk+UlIjeZsZAY//zQ1WKOVxfoHQtq64A5qD/YiMeXAy1wKQ==", null, false, "3ac15e2c-b413-4b15-84dc-9ebbfd226e62", false, "user2" },
                    { "ccf9bfb8-47d6-41bf-9c5d-502", 0, "9df6356e-bf2b-4263-b31e-9c4b282ffaee", "admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN", "AQAAAAIAAYagAAAAEHcB/8zOo32TC0e3b+WGHxYX12SUQ+/nbhUvTGQ04nM5/ibL8e2tIgUvUpD0hrqiZQ==", null, false, "c7a079d7-a6cd-4251-8028-bdb5aa22f89d", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "Text" },
                values: new object[] { 1, "Some Text" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "37bb0930-ee5b-483a-88a9-9fc2dab9a087" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "37bb0930-ee5b-483a-88a9-9fc2dab9a903" },
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "ccf9bfb8-47d6-41bf-9c5d-502" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urls_UserId",
                table: "Urls",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropTable(
                name: "Urls");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "37bb0930-ee5b-483a-88a9-9fc2dab9a087" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "37bb0930-ee5b-483a-88a9-9fc2dab9a903" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "ccf9bfb8-47d6-41bf-9c5d-502" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bb0930-ee5b-483a-88a9-9fc2dab9a087");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bb0930-ee5b-483a-88a9-9fc2dab9a903");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccf9bfb8-47d6-41bf-9c5d-502");
        }
    }
}
