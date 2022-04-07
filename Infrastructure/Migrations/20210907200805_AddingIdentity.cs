using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new Guid("8d1c7142-2922-405f-89d0-7d6a54eb3642"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "AddedDate", "CertificationName", "CertificationURL" },
                values: new object[,]
                {
                    { new Guid("a0020dc4-5d50-486d-8741-c12ba50fe112"), new DateTime(2021, 9, 7, 23, 8, 4, 489, DateTimeKind.Local).AddTicks(5767), "EditMe!", "certification-01.jpg" },
                    { new Guid("28d8d71b-ed45-4ee3-9dae-34a8e7a1abe2"), new DateTime(2021, 9, 7, 23, 8, 4, 489, DateTimeKind.Local).AddTicks(7784), "EditMe!", "certification-01.jpg" },
                    { new Guid("bfddd34d-3c20-4891-8434-ea24f92c3149"), new DateTime(2021, 9, 7, 23, 8, 4, 489, DateTimeKind.Local).AddTicks(7857), "EditMe!", "certification-01.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PdfFiles",
                columns: new[] { "Id", "AddedDate", "FileName", "FilePath" },
                values: new object[,]
                {
                    { new Guid("3795fd84-e1f6-4cfa-b0de-40f00b20bfea"), new DateTime(2021, 9, 7, 23, 8, 4, 485, DateTimeKind.Local).AddTicks(2321), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" },
                    { new Guid("9c9d4a9f-8927-4961-8434-5490a38b78b3"), new DateTime(2021, 9, 7, 23, 8, 4, 488, DateTimeKind.Local).AddTicks(7454), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" }
                });

            migrationBuilder.InsertData(
                table: "QualityPolicies",
                columns: new[] { "Id", "AddedDate", "Point" },
                values: new object[,]
                {
                    { new Guid("7ea5e615-791d-47ce-9c71-46802aa9a917"), new DateTime(2021, 9, 7, 23, 8, 4, 489, DateTimeKind.Local).AddTicks(8583), "EditMe!" },
                    { new Guid("af4bb45f-95ae-425f-a11b-87f9ccd8e208"), new DateTime(2021, 9, 7, 23, 8, 4, 490, DateTimeKind.Local).AddTicks(14), "EditMe!" },
                    { new Guid("44f6d5e2-ccaa-4a52-b8ff-51820a897bee"), new DateTime(2021, 9, 7, 23, 8, 4, 490, DateTimeKind.Local).AddTicks(66), "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("26549cc2-838c-459a-a182-c9f3105f5626"), "Geotechnical", new DateTime(2021, 9, 7, 23, 8, 4, 490, DateTimeKind.Local).AddTicks(4001), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("602a926d-fe91-4dd1-845e-a584ec9d5af5"), "Geotechnical", new DateTime(2021, 9, 7, 23, 8, 4, 490, DateTimeKind.Local).AddTicks(1977), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("6e610ac3-dacb-41b6-a94f-d91457a10330"), "Geotechnical", new DateTime(2021, 9, 7, 23, 8, 4, 490, DateTimeKind.Local).AddTicks(3946), "EditMe!", "serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "AddedDate", "SlideURL", "Text1", "Text2" },
                values: new object[,]
                {
                    { new Guid("f4d12e84-0a76-49b0-8883-814d2f3b4332"), new DateTime(2021, 9, 7, 23, 8, 4, 488, DateTimeKind.Local).AddTicks(9564), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("924dbf14-7d60-41aa-bb13-399f4f4f5ac2"), new DateTime(2021, 9, 7, 23, 8, 4, 489, DateTimeKind.Local).AddTicks(1095), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("217eb3f2-317c-4b6e-bb03-a9dd1ec9a0bc"), new DateTime(2021, 9, 7, 23, 8, 4, 489, DateTimeKind.Local).AddTicks(1151), "slide-01.jpg", "EditMe!", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "SpecialServices",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("2e1362bc-aa05-411e-a267-9f669e2979a9"), "Robotic", new DateTime(2021, 9, 7, 23, 8, 4, 490, DateTimeKind.Local).AddTicks(5824), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("a3875ed3-5913-43d0-804b-efc7ee144172"), "Robotic", new DateTime(2021, 9, 7, 23, 8, 4, 490, DateTimeKind.Local).AddTicks(7787), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("10c99b22-54af-4eee-a46c-282e41ecfcaf"), "Robotic", new DateTime(2021, 9, 7, 23, 8, 4, 490, DateTimeKind.Local).AddTicks(7842), "EditMe!", "sp-serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "WebSettings",
                columns: new[] { "Id", "Adress", "EmailAdress", "FbAdress", "FotterLogoURL", "FotterText", "InstaAdress", "LinkedinAdress", "LogoURL", "Phone", "WhatsApp" },
                values: new object[] { new Guid("2b198320-3d82-438b-9b47-0fb8eb85c783"), "EditMe!", "EditMe!", "EditMe!", "fotter-logo.png", "EditME!", "EditMe!", "EditMe!", "main-logo.png", "EditMe!", "EditMe!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("8d1c7142-2922-405f-89d0-7d6a54eb3642"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("28d8d71b-ed45-4ee3-9dae-34a8e7a1abe2"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("a0020dc4-5d50-486d-8741-c12ba50fe112"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("bfddd34d-3c20-4891-8434-ea24f92c3149"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("3795fd84-e1f6-4cfa-b0de-40f00b20bfea"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("9c9d4a9f-8927-4961-8434-5490a38b78b3"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("44f6d5e2-ccaa-4a52-b8ff-51820a897bee"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("7ea5e615-791d-47ce-9c71-46802aa9a917"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("af4bb45f-95ae-425f-a11b-87f9ccd8e208"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("26549cc2-838c-459a-a182-c9f3105f5626"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("602a926d-fe91-4dd1-845e-a584ec9d5af5"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6e610ac3-dacb-41b6-a94f-d91457a10330"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("217eb3f2-317c-4b6e-bb03-a9dd1ec9a0bc"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("924dbf14-7d60-41aa-bb13-399f4f4f5ac2"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("f4d12e84-0a76-49b0-8883-814d2f3b4332"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("10c99b22-54af-4eee-a46c-282e41ecfcaf"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("2e1362bc-aa05-411e-a267-9f669e2979a9"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("a3875ed3-5913-43d0-804b-efc7ee144172"));

            migrationBuilder.DeleteData(
                table: "WebSettings",
                keyColumn: "Id",
                keyValue: new Guid("2b198320-3d82-438b-9b47-0fb8eb85c783"));

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
    }
}
