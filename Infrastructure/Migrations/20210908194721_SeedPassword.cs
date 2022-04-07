using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SeedPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Aboutus",
                columns: new[] { "Id", "ImageURL", "Para1", "Para2", "QPParagraph", "VisionMissionText" },
                values: new object[] { new Guid("7fce8b36-b152-4a0f-9270-9b1268a45ec2"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserRole" },
                values: new object[] { "03fadf1a-3b98-4640-8bf3-dc1ebc7e15a9", 0, "82eb8885-d481-4369-8cc2-8ab2e6815bfa", "info@newtestlab.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEN7ZZocTgqRnq4F3v7ZXdW1OaOzYcbEr7Fxq7ZqQxSXvsDBL5KLcYQASEEhWrOHZzw==", null, false, "6ab423b4-ee7c-4462-829c-7a53c9cb5e18", false, "info@newtestlab.com", null });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "AddedDate", "CertificationName", "CertificationURL" },
                values: new object[,]
                {
                    { new Guid("0a0171aa-1bee-4562-9814-d046260a8ceb"), new DateTime(2021, 9, 8, 22, 47, 20, 402, DateTimeKind.Local).AddTicks(3695), "EditMe!", "certification-01.jpg" },
                    { new Guid("085d9e30-e937-4a2a-9936-0a55cfdc8fa4"), new DateTime(2021, 9, 8, 22, 47, 20, 402, DateTimeKind.Local).AddTicks(5590), "EditMe!", "certification-01.jpg" },
                    { new Guid("0d08014b-45f7-42e3-81f3-4b688ce1b183"), new DateTime(2021, 9, 8, 22, 47, 20, 402, DateTimeKind.Local).AddTicks(5640), "EditMe!", "certification-01.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PdfFiles",
                columns: new[] { "Id", "AddedDate", "FileName", "FilePath" },
                values: new object[,]
                {
                    { new Guid("a88020cf-f5cb-48c1-a8a2-aff9f2f3072e"), new DateTime(2021, 9, 8, 22, 47, 20, 398, DateTimeKind.Local).AddTicks(4753), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" },
                    { new Guid("c99de482-789b-4a38-b814-6dd47014af56"), new DateTime(2021, 9, 8, 22, 47, 20, 401, DateTimeKind.Local).AddTicks(5944), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" }
                });

            migrationBuilder.InsertData(
                table: "QualityPolicies",
                columns: new[] { "Id", "AddedDate", "Point" },
                values: new object[,]
                {
                    { new Guid("c65b7c2d-bed1-4693-a056-b8199e1d81b9"), new DateTime(2021, 9, 8, 22, 47, 20, 402, DateTimeKind.Local).AddTicks(6260), "EditMe!" },
                    { new Guid("3480bb8c-7912-44ed-b5c6-aedc1074e19b"), new DateTime(2021, 9, 8, 22, 47, 20, 402, DateTimeKind.Local).AddTicks(7587), "EditMe!" },
                    { new Guid("42721c37-ba66-4e03-bec8-e8dbbdf085b3"), new DateTime(2021, 9, 8, 22, 47, 20, 402, DateTimeKind.Local).AddTicks(7638), "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("cb8f365d-9b88-420e-9f86-008205327e06"), "Geotechnical", new DateTime(2021, 9, 8, 22, 47, 20, 403, DateTimeKind.Local).AddTicks(1244), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("7f08d2ef-4ed2-46ec-a953-565c4178504f"), "Geotechnical", new DateTime(2021, 9, 8, 22, 47, 20, 402, DateTimeKind.Local).AddTicks(9415), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("dedd6bc6-4a74-4df5-9fd1-8568c7f1d771"), "Geotechnical", new DateTime(2021, 9, 8, 22, 47, 20, 403, DateTimeKind.Local).AddTicks(1295), "EditMe!", "serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "AddedDate", "SlideURL", "Text1", "Text2" },
                values: new object[,]
                {
                    { new Guid("5ff22017-64ae-438a-8812-5278d887959b"), new DateTime(2021, 9, 8, 22, 47, 20, 401, DateTimeKind.Local).AddTicks(7895), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("333eea61-fc5e-41a4-a744-425566d03363"), new DateTime(2021, 9, 8, 22, 47, 20, 401, DateTimeKind.Local).AddTicks(9314), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("861650a2-b851-4c37-b419-e268f75a4da0"), new DateTime(2021, 9, 8, 22, 47, 20, 401, DateTimeKind.Local).AddTicks(9369), "slide-01.jpg", "EditMe!", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "SpecialServices",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("b0d5ddd2-e2c4-4dc3-aa3e-9c5af60d1fd3"), "Robotic", new DateTime(2021, 9, 8, 22, 47, 20, 403, DateTimeKind.Local).AddTicks(3015), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("635c78e9-fa2d-42c6-85dc-b36d803f66c0"), "Robotic", new DateTime(2021, 9, 8, 22, 47, 20, 403, DateTimeKind.Local).AddTicks(4852), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("5a343d1b-8098-4ff5-9c71-0e20d4c0fe31"), "Robotic", new DateTime(2021, 9, 8, 22, 47, 20, 403, DateTimeKind.Local).AddTicks(4904), "EditMe!", "sp-serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "WebSettings",
                columns: new[] { "Id", "Adress", "EmailAdress", "FbAdress", "FotterLogoURL", "FotterText", "InstaAdress", "LinkedinAdress", "LogoURL", "Phone", "WhatsApp" },
                values: new object[] { new Guid("01bbf63b-617f-49b3-bae6-780f879b8262"), "EditMe!", "EditMe!", "EditMe!", "fotter-logo.png", "EditME!", "EditMe!", "EditMe!", "main-logo.png", "EditMe!", "EditMe!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("7fce8b36-b152-4a0f-9270-9b1268a45ec2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03fadf1a-3b98-4640-8bf3-dc1ebc7e15a9");

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("085d9e30-e937-4a2a-9936-0a55cfdc8fa4"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("0a0171aa-1bee-4562-9814-d046260a8ceb"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("0d08014b-45f7-42e3-81f3-4b688ce1b183"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("a88020cf-f5cb-48c1-a8a2-aff9f2f3072e"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("c99de482-789b-4a38-b814-6dd47014af56"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("3480bb8c-7912-44ed-b5c6-aedc1074e19b"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("42721c37-ba66-4e03-bec8-e8dbbdf085b3"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("c65b7c2d-bed1-4693-a056-b8199e1d81b9"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7f08d2ef-4ed2-46ec-a953-565c4178504f"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("cb8f365d-9b88-420e-9f86-008205327e06"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("dedd6bc6-4a74-4df5-9fd1-8568c7f1d771"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("333eea61-fc5e-41a4-a744-425566d03363"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("5ff22017-64ae-438a-8812-5278d887959b"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("861650a2-b851-4c37-b419-e268f75a4da0"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("5a343d1b-8098-4ff5-9c71-0e20d4c0fe31"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("635c78e9-fa2d-42c6-85dc-b36d803f66c0"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("b0d5ddd2-e2c4-4dc3-aa3e-9c5af60d1fd3"));

            migrationBuilder.DeleteData(
                table: "WebSettings",
                keyColumn: "Id",
                keyValue: new Guid("01bbf63b-617f-49b3-bae6-780f879b8262"));

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
    }
}
