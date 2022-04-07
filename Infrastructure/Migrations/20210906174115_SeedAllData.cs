using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SeedAllData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("bdfc8866-ba7a-4f95-93de-0a7133edb530"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "AddedDate", "CertificationName", "CertificationURL" },
                values: new object[,]
                {
                    { new Guid("d2ebc5df-a447-4bc0-83a2-d82e9f64024a"), new DateTime(2021, 9, 6, 20, 41, 15, 142, DateTimeKind.Local).AddTicks(8652), "EditMe!", "certification-01.jpg" },
                    { new Guid("cececca1-f220-492a-805f-f3e4a94ea92f"), new DateTime(2021, 9, 6, 20, 41, 15, 143, DateTimeKind.Local).AddTicks(796), "EditMe!", "certification-01.jpg" },
                    { new Guid("6fee13f6-d70b-4574-a80b-aa704f24e780"), new DateTime(2021, 9, 6, 20, 41, 15, 143, DateTimeKind.Local).AddTicks(858), "EditMe!", "certification-01.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PdfFiles",
                columns: new[] { "Id", "AddedDate", "FileName", "FilePath" },
                values: new object[,]
                {
                    { new Guid("243a9059-5679-4d15-84a4-93b24c09b65c"), new DateTime(2021, 9, 6, 20, 41, 15, 138, DateTimeKind.Local).AddTicks(3700), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" },
                    { new Guid("11b68358-d180-4acb-8233-7a19f43f5886"), new DateTime(2021, 9, 6, 20, 41, 15, 141, DateTimeKind.Local).AddTicks(9267), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" }
                });

            migrationBuilder.InsertData(
                table: "QualityPolicies",
                columns: new[] { "Id", "AddedDate", "Point" },
                values: new object[,]
                {
                    { new Guid("00354313-c0d5-4bca-a84d-67f192319788"), new DateTime(2021, 9, 6, 20, 41, 15, 143, DateTimeKind.Local).AddTicks(1548), "EditMe!" },
                    { new Guid("95d09e95-d182-43e5-ae41-7f72a1c6c13f"), new DateTime(2021, 9, 6, 20, 41, 15, 143, DateTimeKind.Local).AddTicks(3127), "EditMe!" },
                    { new Guid("aa064fd9-624f-417b-ad10-c87fffe31c90"), new DateTime(2021, 9, 6, 20, 41, 15, 143, DateTimeKind.Local).AddTicks(3183), "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("b6391318-e4ff-4174-8c53-19b3466e003d"), "Geotechnical", new DateTime(2021, 9, 6, 20, 41, 15, 143, DateTimeKind.Local).AddTicks(7234), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("fb2ff28b-571c-41e3-a67b-8ae5f7352ca5"), "Geotechnical", new DateTime(2021, 9, 6, 20, 41, 15, 143, DateTimeKind.Local).AddTicks(4953), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("ec671598-8863-421e-9282-cd487c5aaa1a"), "Geotechnical", new DateTime(2021, 9, 6, 20, 41, 15, 143, DateTimeKind.Local).AddTicks(7177), "EditMe!", "serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "AddedDate", "SlideURL", "Text1", "Text2" },
                values: new object[,]
                {
                    { new Guid("5994d462-9e75-4a2e-84dc-9d2c382056da"), new DateTime(2021, 9, 6, 20, 41, 15, 142, DateTimeKind.Local).AddTicks(1456), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("df47574c-347e-4c3f-9f72-808f6d55bc53"), new DateTime(2021, 9, 6, 20, 41, 15, 142, DateTimeKind.Local).AddTicks(3286), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("b037dfad-0684-4e2c-a715-53d5496e273c"), new DateTime(2021, 9, 6, 20, 41, 15, 142, DateTimeKind.Local).AddTicks(3356), "slide-01.jpg", "EditMe!", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "SpecialServices",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("6a7dac5e-1675-419a-826d-59286e1d7eca"), "Robotic", new DateTime(2021, 9, 6, 20, 41, 15, 143, DateTimeKind.Local).AddTicks(9140), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("65843f17-973a-4ae5-9345-3719bb9839e7"), "Robotic", new DateTime(2021, 9, 6, 20, 41, 15, 144, DateTimeKind.Local).AddTicks(1079), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("4e92d690-7876-47ad-ab12-fc598f4e38b9"), "Robotic", new DateTime(2021, 9, 6, 20, 41, 15, 144, DateTimeKind.Local).AddTicks(1137), "EditMe!", "sp-serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "WebSettings",
                columns: new[] { "Id", "Adress", "EmailAdress", "FbAdress", "FotterLogoURL", "FotterText", "InstaAdress", "LinkedinAdress", "LogoURL", "Phone", "WhatsApp" },
                values: new object[] { new Guid("c0859c28-ee64-46e5-a3ce-28cbf3e81869"), "EditMe!", "EditMe!", "EditMe!", "fotter-logo.png", "EditME!", "EditMe!", "EditMe!", "main-logo.png", "EditMe!", "EditMe!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("bdfc8866-ba7a-4f95-93de-0a7133edb530"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("6fee13f6-d70b-4574-a80b-aa704f24e780"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("cececca1-f220-492a-805f-f3e4a94ea92f"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("d2ebc5df-a447-4bc0-83a2-d82e9f64024a"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("11b68358-d180-4acb-8233-7a19f43f5886"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("243a9059-5679-4d15-84a4-93b24c09b65c"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("00354313-c0d5-4bca-a84d-67f192319788"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("95d09e95-d182-43e5-ae41-7f72a1c6c13f"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("aa064fd9-624f-417b-ad10-c87fffe31c90"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b6391318-e4ff-4174-8c53-19b3466e003d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ec671598-8863-421e-9282-cd487c5aaa1a"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("fb2ff28b-571c-41e3-a67b-8ae5f7352ca5"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("5994d462-9e75-4a2e-84dc-9d2c382056da"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("b037dfad-0684-4e2c-a715-53d5496e273c"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("df47574c-347e-4c3f-9f72-808f6d55bc53"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("4e92d690-7876-47ad-ab12-fc598f4e38b9"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("65843f17-973a-4ae5-9345-3719bb9839e7"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("6a7dac5e-1675-419a-826d-59286e1d7eca"));

            migrationBuilder.DeleteData(
                table: "WebSettings",
                keyColumn: "Id",
                keyValue: new Guid("c0859c28-ee64-46e5-a3ce-28cbf3e81869"));

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
    }
}
