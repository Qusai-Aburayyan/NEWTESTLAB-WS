using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SeedRestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("f62e3c53-ea98-4a2d-8ecb-81356a676830"));

            migrationBuilder.DeleteData(
                table: "WebSettings",
                keyColumn: "Id",
                keyValue: new Guid("54aba4ca-437e-4112-bcad-bcebc977b0fc"));

            migrationBuilder.InsertData(
                table: "Aboutus",
                columns: new[] { "Id", "ImageURL", "Para1", "Para2", "QPParagraph", "VisionMissionText" },
                values: new object[] { new Guid("002c2cea-d760-4ce3-906d-c60cda77bff3"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });

            migrationBuilder.InsertData(
                table: "PdfFiles",
                columns: new[] { "Id", "AddedDate", "FileName", "FilePath" },
                values: new object[] { new Guid("b19b31c2-5684-4f29-9062-5aa81a42c35d"), new DateTime(2021, 9, 6, 20, 11, 45, 375, DateTimeKind.Local).AddTicks(6408), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[] { new Guid("bad208cf-177e-4659-8064-e245807e4fc5"), "Geotechnical", new DateTime(2021, 9, 6, 20, 11, 45, 381, DateTimeKind.Local).AddTicks(4067), "EditMe!", "serv-01.jpg", "EditMe!" });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "AddedDate", "SlideURL", "Text1", "Text2" },
                values: new object[] { new Guid("f5388a66-5d8a-4172-ae2b-b6437ece8dba"), new DateTime(2021, 9, 6, 20, 11, 45, 380, DateTimeKind.Local).AddTicks(7057), "slide-01.jpg", "EditMe!", "EditMe!" });

            migrationBuilder.InsertData(
                table: "SpecialServices",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[] { new Guid("e97c1aae-522e-4a01-ba74-876630438e8c"), "Geotechnical", new DateTime(2021, 9, 6, 20, 11, 45, 381, DateTimeKind.Local).AddTicks(7612), "EditMe!", "sp-serv-01.jpg", "EditMe!" });

            migrationBuilder.InsertData(
                table: "WebSettings",
                columns: new[] { "Id", "Adress", "EmailAdress", "FbAdress", "FotterLogoURL", "FotterText", "InstaAdress", "LinkedinAdress", "LogoURL", "Phone", "WhatsApp" },
                values: new object[] { new Guid("2d39153d-037e-4b1a-a419-a16f45db59d7"), "EditMe!", "EditMe!", "EditMe!", "fotter-logo.png", "EditME!", "EditMe!", "EditMe!", "main-logo.png", "EditMe!", "EditMe!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("002c2cea-d760-4ce3-906d-c60cda77bff3"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("b19b31c2-5684-4f29-9062-5aa81a42c35d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("bad208cf-177e-4659-8064-e245807e4fc5"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("f5388a66-5d8a-4172-ae2b-b6437ece8dba"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("e97c1aae-522e-4a01-ba74-876630438e8c"));

            migrationBuilder.DeleteData(
                table: "WebSettings",
                keyColumn: "Id",
                keyValue: new Guid("2d39153d-037e-4b1a-a419-a16f45db59d7"));

            migrationBuilder.InsertData(
                table: "Aboutus",
                columns: new[] { "Id", "ImageURL", "Para1", "Para2", "QPParagraph", "VisionMissionText" },
                values: new object[] { new Guid("f62e3c53-ea98-4a2d-8ecb-81356a676830"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });

            migrationBuilder.InsertData(
                table: "WebSettings",
                columns: new[] { "Id", "Adress", "EmailAdress", "FbAdress", "FotterLogoURL", "FotterText", "InstaAdress", "LinkedinAdress", "LogoURL", "Phone", "WhatsApp" },
                values: new object[] { new Guid("54aba4ca-437e-4112-bcad-bcebc977b0fc"), "EditMe!", "EditMe!", "EditMe!", "fotter-logo.png", "EditME!", "EditMe!", "EditMe!", "main-logo.png", "EditMe!", "EditMe!" });
        }
    }
}
