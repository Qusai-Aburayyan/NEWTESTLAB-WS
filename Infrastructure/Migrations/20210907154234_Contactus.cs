using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Contactus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Contactus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    MessageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Aboutus",
                columns: new[] { "Id", "ImageURL", "Para1", "Para2", "QPParagraph", "VisionMissionText" },
                values: new object[] { new Guid("4f47aa61-9071-4bd7-b017-001759a9e493"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "AddedDate", "CertificationName", "CertificationURL" },
                values: new object[,]
                {
                    { new Guid("2dd6c755-36b7-4fd8-9648-82355ae88c4f"), new DateTime(2021, 9, 7, 18, 42, 33, 633, DateTimeKind.Local).AddTicks(2322), "EditMe!", "certification-01.jpg" },
                    { new Guid("11d9c242-b21b-47e5-9128-5a115bfe1267"), new DateTime(2021, 9, 7, 18, 42, 33, 633, DateTimeKind.Local).AddTicks(4407), "EditMe!", "certification-01.jpg" },
                    { new Guid("08087cb7-ad5b-42ff-a69b-5f9249d95123"), new DateTime(2021, 9, 7, 18, 42, 33, 633, DateTimeKind.Local).AddTicks(4472), "EditMe!", "certification-01.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PdfFiles",
                columns: new[] { "Id", "AddedDate", "FileName", "FilePath" },
                values: new object[,]
                {
                    { new Guid("8991a533-0695-48f7-961c-13e4eebf8094"), new DateTime(2021, 9, 7, 18, 42, 33, 628, DateTimeKind.Local).AddTicks(6875), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" },
                    { new Guid("17ddc5b0-f1b9-41e6-83f3-a884cfdc2982"), new DateTime(2021, 9, 7, 18, 42, 33, 632, DateTimeKind.Local).AddTicks(3707), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" }
                });

            migrationBuilder.InsertData(
                table: "QualityPolicies",
                columns: new[] { "Id", "AddedDate", "Point" },
                values: new object[,]
                {
                    { new Guid("d9604248-fbfd-4cf2-9f51-2172682961a3"), new DateTime(2021, 9, 7, 18, 42, 33, 633, DateTimeKind.Local).AddTicks(5155), "EditMe!" },
                    { new Guid("4ed527df-4b10-49d0-b631-91f0cfeda800"), new DateTime(2021, 9, 7, 18, 42, 33, 633, DateTimeKind.Local).AddTicks(6611), "EditMe!" },
                    { new Guid("64253033-544a-4e29-9340-3e666159ab62"), new DateTime(2021, 9, 7, 18, 42, 33, 633, DateTimeKind.Local).AddTicks(6666), "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("7fab4bf1-c614-45c6-a084-ec896acab46b"), "Geotechnical", new DateTime(2021, 9, 7, 18, 42, 33, 634, DateTimeKind.Local).AddTicks(1174), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("ffcf3076-bddb-4298-a44b-4969c90aa41a"), "Geotechnical", new DateTime(2021, 9, 7, 18, 42, 33, 633, DateTimeKind.Local).AddTicks(8534), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("4ba477f8-3780-4a82-9459-255fa605097b"), "Geotechnical", new DateTime(2021, 9, 7, 18, 42, 33, 634, DateTimeKind.Local).AddTicks(1086), "EditMe!", "serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "AddedDate", "SlideURL", "Text1", "Text2" },
                values: new object[,]
                {
                    { new Guid("c8df43a7-e0d4-46f2-bdc1-c14f8a67e88d"), new DateTime(2021, 9, 7, 18, 42, 33, 632, DateTimeKind.Local).AddTicks(5880), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("fd30b79e-e957-4770-a2fd-dd772e21c82c"), new DateTime(2021, 9, 7, 18, 42, 33, 632, DateTimeKind.Local).AddTicks(7513), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("061bef60-a1ea-49a5-86ea-840f6c2f2cf9"), new DateTime(2021, 9, 7, 18, 42, 33, 632, DateTimeKind.Local).AddTicks(7579), "slide-01.jpg", "EditMe!", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "SpecialServices",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("7a895460-f8c2-40df-9066-45c522e3c5ba"), "Robotic", new DateTime(2021, 9, 7, 18, 42, 33, 634, DateTimeKind.Local).AddTicks(3880), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("ef5dc090-7990-4ff7-aa15-87bc86b5d6fa"), "Robotic", new DateTime(2021, 9, 7, 18, 42, 33, 634, DateTimeKind.Local).AddTicks(6672), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("406e9993-3440-40da-be03-fe199f096282"), "Robotic", new DateTime(2021, 9, 7, 18, 42, 33, 634, DateTimeKind.Local).AddTicks(6763), "EditMe!", "sp-serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "WebSettings",
                columns: new[] { "Id", "Adress", "EmailAdress", "FbAdress", "FotterLogoURL", "FotterText", "InstaAdress", "LinkedinAdress", "LogoURL", "Phone", "WhatsApp" },
                values: new object[] { new Guid("6c244d7e-7b85-42b7-be80-f295a8e6a4a9"), "EditMe!", "EditMe!", "EditMe!", "fotter-logo.png", "EditME!", "EditMe!", "EditMe!", "main-logo.png", "EditMe!", "EditMe!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contactus");

            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("4f47aa61-9071-4bd7-b017-001759a9e493"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("08087cb7-ad5b-42ff-a69b-5f9249d95123"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("11d9c242-b21b-47e5-9128-5a115bfe1267"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("2dd6c755-36b7-4fd8-9648-82355ae88c4f"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("17ddc5b0-f1b9-41e6-83f3-a884cfdc2982"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("8991a533-0695-48f7-961c-13e4eebf8094"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("4ed527df-4b10-49d0-b631-91f0cfeda800"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("64253033-544a-4e29-9340-3e666159ab62"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("d9604248-fbfd-4cf2-9f51-2172682961a3"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("4ba477f8-3780-4a82-9459-255fa605097b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7fab4bf1-c614-45c6-a084-ec896acab46b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ffcf3076-bddb-4298-a44b-4969c90aa41a"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("061bef60-a1ea-49a5-86ea-840f6c2f2cf9"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("c8df43a7-e0d4-46f2-bdc1-c14f8a67e88d"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("fd30b79e-e957-4770-a2fd-dd772e21c82c"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("406e9993-3440-40da-be03-fe199f096282"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("7a895460-f8c2-40df-9066-45c522e3c5ba"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("ef5dc090-7990-4ff7-aa15-87bc86b5d6fa"));

            migrationBuilder.DeleteData(
                table: "WebSettings",
                keyColumn: "Id",
                keyValue: new Guid("6c244d7e-7b85-42b7-be80-f295a8e6a4a9"));

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
    }
}
