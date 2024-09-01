using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrlShortener.Data.Migrations
{
    /// <inheritdoc />
    public partial class DescriptionInitialAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bb0930-ee5b-483a-88a9-9fc2dab9a087",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8d03755-1824-49f6-abfd-b0ed4595797b", "AQAAAAIAAYagAAAAEHKD0CgdBvl5ims04qs+yF0iGymlZHeSeOv770ZrR0amEBSqKVBkFY8sprQMN1kHcw==", "157e1363-23d3-442d-85ba-8d5f55cbc801" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bb0930-ee5b-483a-88a9-9fc2dab9a903",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5fefe1a-195f-4320-8f66-e75f9383557c", "AQAAAAIAAYagAAAAEDTYiQSpUQTeiojEwRdjoMN2je3PPNbeccjAg/ouSTGNP3jWLdUKSQqsf03jRcY0hw==", "1c655db3-0012-40d6-9d68-b25c979e2bfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccf9bfb8-47d6-41bf-9c5d-502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba6be20f-1a58-4d10-b8df-e6ae2ed87f7c", "AQAAAAIAAYagAAAAEJ9bBnTgMxxqi38gKuOTHGUrIPEdOHKM9MB2hBmfidD7tz7tfopTDCr8IttzGdkzoA==", "cc371b18-03ac-4ab5-86ab-e7dcdd029ed4" });

            migrationBuilder.UpdateData(
                table: "Descriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "URL shortener service is designed to simplify and enhance the management of long web addresses. Whether you’re sharing links on social media, in emails, or anywhere else, the tool helps by converting lengthy URLs into shorter, more manageable links.\r\n\r\nHow It Works:\r\n\r\n    Creating Short URLs:\r\n        When you provide a long URL, the service generates a unique short link for you. This short link redirects users to the original long URL, but in a much more convenient format.\r\n\r\n    Generating Unique Short Codes:\r\n        Each short link is created using a combination of letters and numbers, ensuring that every link is unique. This short code is what users will see and click on, making it easy to remember and share.\r\n\r\n    Managing Your Links:\r\n        You can view all the short URLs you’ve created, along with details like the original long URL and the date it was created. If you have administrator privileges, you can also manage and delete URLs.\r\n\r\n    Permissions and Security:\r\n        Only authorized users, like administrators or the original creators, can delete or modify URLs. This ensures that your links are secure and only accessible by those who have the right permissions.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Descriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "Some Text");
        }
    }
}
