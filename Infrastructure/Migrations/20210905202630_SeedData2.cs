using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("f81c1ebc-1206-4fd8-a04c-eaf0dcccd688"));

            migrationBuilder.InsertData(
                table: "Aboutus",
                columns: new[] { "Id", "ImageURL", "Para1", "Para2", "QPParagraph", "VisionMissionText" },
                values: new object[] { new Guid("e2614df4-d44e-4a43-87c4-1eaa5c923c48"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("e2614df4-d44e-4a43-87c4-1eaa5c923c48"));

            migrationBuilder.InsertData(
                table: "Aboutus",
                columns: new[] { "Id", "ImageURL", "Para1", "Para2", "QPParagraph", "VisionMissionText" },
                values: new object[] { new Guid("f81c1ebc-1206-4fd8-a04c-eaf0dcccd688"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });
        }
    }
}
