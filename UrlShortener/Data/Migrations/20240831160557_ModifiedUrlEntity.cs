using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrlShortener.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedUrlEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Urls",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bb0930-ee5b-483a-88a9-9fc2dab9a087",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "165dbe08-be38-400e-af21-79067d6168be", "AQAAAAIAAYagAAAAEDES4cdPPldfq/7+8qQWSUJHnGH0c2sQT2XpQyE+JWL3cp5bk4z+eLHtdyjK7liv6w==", "5a04198b-b18e-43d0-aa58-c8b01d6f5efb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bb0930-ee5b-483a-88a9-9fc2dab9a903",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "119165ff-0535-4e6f-a5ec-68a1cac52626", "AQAAAAIAAYagAAAAEFKdAMkntYBDg8UAE3jlDMQVDpR803zw/P/eSgZnEQx2Ot3weARxyKDglixO5Rxmdw==", "42be050f-260c-4ad4-a9b0-177ac9f8177e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccf9bfb8-47d6-41bf-9c5d-502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "439727c3-4180-493d-b3c5-ddc7e75ee860", "AQAAAAIAAYagAAAAEBoawfLHAkXrmZ/OLrUIGenAZduP8Z2pOJ+j9pB3Yk8NBhfO3Y5hL8rPoQpeEnaSHw==", "561b5adb-acb7-400c-b7bc-5ba5f4512ecd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Urls");

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
    }
}
