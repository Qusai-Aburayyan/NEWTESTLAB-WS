using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SeedDataWeb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Aboutus",
                columns: new[] { "Id", "ImageURL", "Para1", "Para2", "QPParagraph", "VisionMissionText" },
                values: new object[] { new Guid("f62e3c53-ea98-4a2d-8ecb-81356a676830"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });

            migrationBuilder.InsertData(
                table: "WebSettings",
                columns: new[] { "Id", "Adress", "EmailAdress", "FbAdress", "FotterLogoURL", "FotterText", "InstaAdress", "LinkedinAdress", "LogoURL", "Phone", "WhatsApp" },
                values: new object[] { new Guid("54aba4ca-437e-4112-bcad-bcebc977b0fc"), "EditMe!", "EditMe!", "EditMe!", "fotter-logo.png", "EditME!", "EditMe!", "EditMe!", "main-logo.png", "EditMe!", "EditMe!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("f62e3c53-ea98-4a2d-8ecb-81356a676830"));

            migrationBuilder.DeleteData(
                table: "WebSettings",
                keyColumn: "Id",
                keyValue: new Guid("54aba4ca-437e-4112-bcad-bcebc977b0fc"));
        }
    }
}
