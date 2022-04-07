using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "UserRole",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Aboutus",
                columns: new[] { "Id", "ImageURL", "Para1", "Para2", "QPParagraph", "VisionMissionText" },
                values: new object[] { new Guid("bd5556e8-a375-4932-be6e-3357a94739e9"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserRole" },
                values: new object[] { "a565eae5-57fe-48a4-9918-706b5d81159c", 0, "7462a992-572d-4133-a70d-7c634c945a2f", "info@newtestlab.com", false, false, null, null, null, "H4ZX7SHJ@Qu", null, false, "722ac13b-97bf-427b-bbf3-21a76ff450b4", false, null, null });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "AddedDate", "CertificationName", "CertificationURL" },
                values: new object[,]
                {
                    { new Guid("8a9f43bb-4710-49fd-8d5d-dec7bc6ac498"), new DateTime(2021, 9, 8, 22, 13, 30, 363, DateTimeKind.Local).AddTicks(4831), "EditMe!", "certification-01.jpg" },
                    { new Guid("e3b3741b-576e-4ebe-8e50-a6edeb481e2f"), new DateTime(2021, 9, 8, 22, 13, 30, 363, DateTimeKind.Local).AddTicks(7948), "EditMe!", "certification-01.jpg" },
                    { new Guid("d38b2d32-39bb-4e2b-b3c3-77900dafb318"), new DateTime(2021, 9, 8, 22, 13, 30, 363, DateTimeKind.Local).AddTicks(8042), "EditMe!", "certification-01.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PdfFiles",
                columns: new[] { "Id", "AddedDate", "FileName", "FilePath" },
                values: new object[,]
                {
                    { new Guid("4c4b5ea3-1582-4630-ac0b-360a73e05f9e"), new DateTime(2021, 9, 8, 22, 13, 30, 357, DateTimeKind.Local).AddTicks(1139), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" },
                    { new Guid("0cca69ec-f4f4-4740-9d8c-9579078a7846"), new DateTime(2021, 9, 8, 22, 13, 30, 362, DateTimeKind.Local).AddTicks(2284), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" }
                });

            migrationBuilder.InsertData(
                table: "QualityPolicies",
                columns: new[] { "Id", "AddedDate", "Point" },
                values: new object[,]
                {
                    { new Guid("a33e3ea6-a0a9-41a7-8789-342ea4c3287b"), new DateTime(2021, 9, 8, 22, 13, 30, 363, DateTimeKind.Local).AddTicks(9045), "EditMe!" },
                    { new Guid("f11286c2-d181-4dec-80f1-4897129b9185"), new DateTime(2021, 9, 8, 22, 13, 30, 364, DateTimeKind.Local).AddTicks(1332), "EditMe!" },
                    { new Guid("13e72533-71d4-4e07-9e6c-af48bb882930"), new DateTime(2021, 9, 8, 22, 13, 30, 364, DateTimeKind.Local).AddTicks(1431), "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("f6bc7e31-bda7-40d3-b731-86fb52b7c725"), "Geotechnical", new DateTime(2021, 9, 8, 22, 13, 30, 364, DateTimeKind.Local).AddTicks(8108), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("c6712fab-6fe1-4cd9-9504-141c80710eb8"), "Geotechnical", new DateTime(2021, 9, 8, 22, 13, 30, 364, DateTimeKind.Local).AddTicks(4406), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("90c887b9-ffe0-4ce9-8363-1416e54f53c5"), "Geotechnical", new DateTime(2021, 9, 8, 22, 13, 30, 364, DateTimeKind.Local).AddTicks(8207), "EditMe!", "serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "AddedDate", "SlideURL", "Text1", "Text2" },
                values: new object[,]
                {
                    { new Guid("b0633f67-1d90-490e-8ca9-b07c95d63204"), new DateTime(2021, 9, 8, 22, 13, 30, 362, DateTimeKind.Local).AddTicks(5312), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("082abd63-5527-477f-88a7-29b7aa653374"), new DateTime(2021, 9, 8, 22, 13, 30, 362, DateTimeKind.Local).AddTicks(7652), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("65f504c7-541a-4b2a-abd2-dc5f9e3e7e24"), new DateTime(2021, 9, 8, 22, 13, 30, 362, DateTimeKind.Local).AddTicks(7744), "slide-01.jpg", "EditMe!", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "SpecialServices",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("ebbd4123-6256-42a9-832a-d62decc5595e"), "Robotic", new DateTime(2021, 9, 8, 22, 13, 30, 365, DateTimeKind.Local).AddTicks(1283), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("431a7eae-ce0f-4f5e-9089-c020dba81d61"), "Robotic", new DateTime(2021, 9, 8, 22, 13, 30, 365, DateTimeKind.Local).AddTicks(4856), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("a29f5637-8511-41f7-83e2-9be1e877023d"), "Robotic", new DateTime(2021, 9, 8, 22, 13, 30, 365, DateTimeKind.Local).AddTicks(5201), "EditMe!", "sp-serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "WebSettings",
                columns: new[] { "Id", "Adress", "EmailAdress", "FbAdress", "FotterLogoURL", "FotterText", "InstaAdress", "LinkedinAdress", "LogoURL", "Phone", "WhatsApp" },
                values: new object[] { new Guid("3d66b1b8-3a3c-494f-9923-1c095b91bb8e"), "EditMe!", "EditMe!", "EditMe!", "fotter-logo.png", "EditME!", "EditMe!", "EditMe!", "main-logo.png", "EditMe!", "EditMe!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("bd5556e8-a375-4932-be6e-3357a94739e9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a565eae5-57fe-48a4-9918-706b5d81159c");

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("8a9f43bb-4710-49fd-8d5d-dec7bc6ac498"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("d38b2d32-39bb-4e2b-b3c3-77900dafb318"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("e3b3741b-576e-4ebe-8e50-a6edeb481e2f"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("0cca69ec-f4f4-4740-9d8c-9579078a7846"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("4c4b5ea3-1582-4630-ac0b-360a73e05f9e"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("13e72533-71d4-4e07-9e6c-af48bb882930"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("a33e3ea6-a0a9-41a7-8789-342ea4c3287b"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("f11286c2-d181-4dec-80f1-4897129b9185"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("90c887b9-ffe0-4ce9-8363-1416e54f53c5"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c6712fab-6fe1-4cd9-9504-141c80710eb8"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f6bc7e31-bda7-40d3-b731-86fb52b7c725"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("082abd63-5527-477f-88a7-29b7aa653374"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("65f504c7-541a-4b2a-abd2-dc5f9e3e7e24"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("b0633f67-1d90-490e-8ca9-b07c95d63204"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("431a7eae-ce0f-4f5e-9089-c020dba81d61"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("a29f5637-8511-41f7-83e2-9be1e877023d"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("ebbd4123-6256-42a9-832a-d62decc5595e"));

            migrationBuilder.DeleteData(
                table: "WebSettings",
                keyColumn: "Id",
                keyValue: new Guid("3d66b1b8-3a3c-494f-9923-1c095b91bb8e"));

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "AspNetUsers");

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
    }
}
