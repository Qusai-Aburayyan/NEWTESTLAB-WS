using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ExtendIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("45a9e4af-30b2-461d-b924-efd62c551b45"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "AddedDate", "CertificationName", "CertificationURL" },
                values: new object[,]
                {
                    { new Guid("1c621308-15d4-42d9-b31f-7ffe977f0d9a"), new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(5824), "EditMe!", "certification-01.jpg" },
                    { new Guid("1f31842c-83f2-43d3-946d-ac8cc3365125"), new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(7816), "EditMe!", "certification-01.jpg" },
                    { new Guid("6cf82ea7-c63e-4370-992a-91bba5d16308"), new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(7869), "EditMe!", "certification-01.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PdfFiles",
                columns: new[] { "Id", "AddedDate", "FileName", "FilePath" },
                values: new object[,]
                {
                    { new Guid("0602fc04-365d-4bcf-8561-27f36146b753"), new DateTime(2021, 9, 8, 21, 59, 33, 385, DateTimeKind.Local).AddTicks(3767), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" },
                    { new Guid("d727d02e-e837-4e41-bfdf-b3af151a5153"), new DateTime(2021, 9, 8, 21, 59, 33, 388, DateTimeKind.Local).AddTicks(7428), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" }
                });

            migrationBuilder.InsertData(
                table: "QualityPolicies",
                columns: new[] { "Id", "AddedDate", "Point" },
                values: new object[,]
                {
                    { new Guid("bb4186c7-7870-4c4a-9dd3-f3b455f1fe45"), new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(8519), "EditMe!" },
                    { new Guid("9d9f757c-eaac-48a7-aa93-f63fd079fd01"), new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(9912), "EditMe!" },
                    { new Guid("61bcf16d-dee5-4e18-8e6f-67860148f091"), new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(9964), "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("2e1b2938-3d95-4424-87b8-ebccc2dd2621"), "Geotechnical", new DateTime(2021, 9, 8, 21, 59, 33, 390, DateTimeKind.Local).AddTicks(3714), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("63a2835c-31e1-4b47-946b-387ce45b853e"), "Geotechnical", new DateTime(2021, 9, 8, 21, 59, 33, 390, DateTimeKind.Local).AddTicks(1713), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("c301a51f-923b-4ccf-b4eb-efab01d5d3b0"), "Geotechnical", new DateTime(2021, 9, 8, 21, 59, 33, 390, DateTimeKind.Local).AddTicks(3659), "EditMe!", "serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "AddedDate", "SlideURL", "Text1", "Text2" },
                values: new object[,]
                {
                    { new Guid("3d910dd8-3ee1-44a3-ac60-c4c1eb5ec975"), new DateTime(2021, 9, 8, 21, 59, 33, 388, DateTimeKind.Local).AddTicks(9486), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("e15fabde-3ed6-4ab9-9d51-9d8b80f8a463"), new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(1035), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("40e056c2-63ae-45d1-b694-026f4b1bed88"), new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(1094), "slide-01.jpg", "EditMe!", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "SpecialServices",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("d2d867ef-d9c8-4f9d-838a-3980371aee58"), "Robotic", new DateTime(2021, 9, 8, 21, 59, 33, 390, DateTimeKind.Local).AddTicks(5478), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("79691732-c986-414c-b9e2-11504035c396"), "Robotic", new DateTime(2021, 9, 8, 21, 59, 33, 390, DateTimeKind.Local).AddTicks(7485), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("d90983e8-f4c7-4487-9eb9-d9778c96e4ad"), "Robotic", new DateTime(2021, 9, 8, 21, 59, 33, 390, DateTimeKind.Local).AddTicks(7545), "EditMe!", "sp-serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "WebSettings",
                columns: new[] { "Id", "Adress", "EmailAdress", "FbAdress", "FotterLogoURL", "FotterText", "InstaAdress", "LinkedinAdress", "LogoURL", "Phone", "WhatsApp" },
                values: new object[] { new Guid("7cb3ca25-e28d-4c7c-8224-6744f4be78e9"), "EditMe!", "EditMe!", "EditMe!", "fotter-logo.png", "EditME!", "EditMe!", "EditMe!", "main-logo.png", "EditMe!", "EditMe!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("45a9e4af-30b2-461d-b924-efd62c551b45"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("1c621308-15d4-42d9-b31f-7ffe977f0d9a"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("1f31842c-83f2-43d3-946d-ac8cc3365125"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("6cf82ea7-c63e-4370-992a-91bba5d16308"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("0602fc04-365d-4bcf-8561-27f36146b753"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("d727d02e-e837-4e41-bfdf-b3af151a5153"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("61bcf16d-dee5-4e18-8e6f-67860148f091"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("9d9f757c-eaac-48a7-aa93-f63fd079fd01"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("bb4186c7-7870-4c4a-9dd3-f3b455f1fe45"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2e1b2938-3d95-4424-87b8-ebccc2dd2621"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("63a2835c-31e1-4b47-946b-387ce45b853e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c301a51f-923b-4ccf-b4eb-efab01d5d3b0"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("3d910dd8-3ee1-44a3-ac60-c4c1eb5ec975"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("40e056c2-63ae-45d1-b694-026f4b1bed88"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("e15fabde-3ed6-4ab9-9d51-9d8b80f8a463"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("79691732-c986-414c-b9e2-11504035c396"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("d2d867ef-d9c8-4f9d-838a-3980371aee58"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("d90983e8-f4c7-4487-9eb9-d9778c96e4ad"));

            migrationBuilder.DeleteData(
                table: "WebSettings",
                keyColumn: "Id",
                keyValue: new Guid("7cb3ca25-e28d-4c7c-8224-6744f4be78e9"));

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
    }
}
