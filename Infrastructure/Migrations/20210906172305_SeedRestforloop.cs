using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SeedRestforloop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("014eec09-5f9d-4389-bb15-a16d6ddc4d0f"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });

            migrationBuilder.InsertData(
                table: "PdfFiles",
                columns: new[] { "Id", "AddedDate", "FileName", "FilePath" },
                values: new object[] { new Guid("096e06c6-412a-4f08-8349-1ad6b335bbbb"), new DateTime(2021, 9, 6, 20, 23, 4, 350, DateTimeKind.Local).AddTicks(8022), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[] { new Guid("beec9a21-5719-4c25-9278-5d2631ae3c64"), "Geotechnical", new DateTime(2021, 9, 6, 20, 23, 4, 355, DateTimeKind.Local).AddTicks(3389), "EditMe!", "serv-01.jpg", "EditMe!" });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "AddedDate", "SlideURL", "Text1", "Text2" },
                values: new object[,]
                {
                    { new Guid("63d8cd56-5a4b-4ffe-bc2b-5cee768b7e65"), new DateTime(2021, 9, 6, 20, 23, 4, 354, DateTimeKind.Local).AddTicks(5758), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("e3a052ca-aa15-4c50-bb19-7ca6db8b2203"), new DateTime(2021, 9, 6, 20, 23, 4, 354, DateTimeKind.Local).AddTicks(7309), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("047d885b-4e97-457a-bf0f-a5009a9fca6d"), new DateTime(2021, 9, 6, 20, 23, 4, 354, DateTimeKind.Local).AddTicks(7369), "slide-01.jpg", "EditMe!", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "SpecialServices",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[] { new Guid("844182f3-3c26-447a-afe3-b362a61c9a3c"), "Geotechnical", new DateTime(2021, 9, 6, 20, 23, 4, 355, DateTimeKind.Local).AddTicks(7290), "EditMe!", "sp-serv-01.jpg", "EditMe!" });

            migrationBuilder.InsertData(
                table: "WebSettings",
                columns: new[] { "Id", "Adress", "EmailAdress", "FbAdress", "FotterLogoURL", "FotterText", "InstaAdress", "LinkedinAdress", "LogoURL", "Phone", "WhatsApp" },
                values: new object[] { new Guid("2ded4f22-5449-454f-a9c1-10a816d6c43a"), "EditMe!", "EditMe!", "EditMe!", "fotter-logo.png", "EditME!", "EditMe!", "EditMe!", "main-logo.png", "EditMe!", "EditMe!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("014eec09-5f9d-4389-bb15-a16d6ddc4d0f"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("096e06c6-412a-4f08-8349-1ad6b335bbbb"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("beec9a21-5719-4c25-9278-5d2631ae3c64"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("047d885b-4e97-457a-bf0f-a5009a9fca6d"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("63d8cd56-5a4b-4ffe-bc2b-5cee768b7e65"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("e3a052ca-aa15-4c50-bb19-7ca6db8b2203"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("844182f3-3c26-447a-afe3-b362a61c9a3c"));

            migrationBuilder.DeleteData(
                table: "WebSettings",
                keyColumn: "Id",
                keyValue: new Guid("2ded4f22-5449-454f-a9c1-10a816d6c43a"));

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
    }
}
