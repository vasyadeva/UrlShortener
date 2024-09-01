using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrlShortener.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesSetting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bb0930-ee5b-483a-88a9-9fc2dab9a087",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ec4ad9b-48cb-4527-b8a9-6ac08a26a2f4", "AQAAAAIAAYagAAAAEB7S+xb/Le5Mbs0CeLaUbtJbp5amwN29tPtvQDKEYchx+CfxSwpZtb1Imgg6qVvf8Q==", "79e54dba-230d-465b-8627-f7b69751112b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bb0930-ee5b-483a-88a9-9fc2dab9a903",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "761944d1-6ed4-4ce0-add2-d2443d573d9a", "AQAAAAIAAYagAAAAEKU/OHAbKBoNFOkZr+PTBBslVzZPNOuUb1ww+QJeP/4YINddriDwYghApnZj0o5izw==", "e0dc016b-5391-4f53-b589-306c4cde96bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccf9bfb8-47d6-41bf-9c5d-502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fc47296-9dee-4e42-8778-fcdf9bdbc525", "AQAAAAIAAYagAAAAEEWOQhF8zjpMWwhZ4myKiI2RigF5ROLM3efXlNDKqh9CvSvEZDLw+M7MmEZhtAMdQA==", "e7e185b0-73e7-449e-b93a-00676fbc70da" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bb0930-ee5b-483a-88a9-9fc2dab9a087",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5bce268-3155-4ead-a312-8a7e9f312b13", "AQAAAAIAAYagAAAAECUxnzhAtOwsINVt9gA2Vv8416J5zLgkh+BvImyWSmXCF+1+zp3EG94oKI8QQfLf2w==", "c4cc5963-4a45-4a5c-8a5d-7a57adb0db9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bb0930-ee5b-483a-88a9-9fc2dab9a903",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d51b9a03-e023-4a70-a67f-f46646036365", "AQAAAAIAAYagAAAAELHtygJGaB2KLgNNaYZlk+UlIjeZsZAY//zQ1WKOVxfoHQtq64A5qD/YiMeXAy1wKQ==", "3ac15e2c-b413-4b15-84dc-9ebbfd226e62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccf9bfb8-47d6-41bf-9c5d-502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9df6356e-bf2b-4263-b31e-9c4b282ffaee", "AQAAAAIAAYagAAAAEHcB/8zOo32TC0e3b+WGHxYX12SUQ+/nbhUvTGQ04nM5/ibL8e2tIgUvUpD0hrqiZQ==", "c7a079d7-a6cd-4251-8028-bdb5aa22f89d" });
        }
    }
}
