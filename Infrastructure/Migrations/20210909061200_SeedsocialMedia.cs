using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SeedsocialMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("2dec1879-5147-4ed3-bb75-39260a3b2d7c"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "AddedDate", "CertificationName", "CertificationURL" },
                values: new object[,]
                {
                    { new Guid("370c7af7-1a48-4833-a023-6d60deb38957"), new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(6106), "EditMe!", "certification-01.jpg" },
                    { new Guid("4e037fbe-59b0-46de-900b-a0f10b29ecd2"), new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(8294), "EditMe!", "certification-01.jpg" },
                    { new Guid("d648e132-f859-4252-81ad-61b91c44eb84"), new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(8346), "EditMe!", "certification-01.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PdfFiles",
                columns: new[] { "Id", "AddedDate", "FileName", "FilePath" },
                values: new object[,]
                {
                    { new Guid("335e6afa-fe0f-4890-888b-a082b1982dea"), new DateTime(2021, 9, 9, 9, 11, 59, 451, DateTimeKind.Local).AddTicks(8139), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" },
                    { new Guid("7e69aa84-6c40-4141-a2a5-11e77346bb28"), new DateTime(2021, 9, 9, 9, 11, 59, 448, DateTimeKind.Local).AddTicks(4488), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" }
                });

            migrationBuilder.InsertData(
                table: "QualityPolicies",
                columns: new[] { "Id", "AddedDate", "Point" },
                values: new object[,]
                {
                    { new Guid("abbd62c4-2004-4081-be96-8e81db44e8b1"), new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(8987), "EditMe!" },
                    { new Guid("15c589a7-cf6c-42ba-8fe2-d2d6530afd9f"), new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(340), "EditMe!" },
                    { new Guid("64e72231-5db8-4910-8ed9-c280bcba3f30"), new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(392), "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("013fc235-e3e2-4d98-bce8-0148540955ee"), "Geotechnical", new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(4107), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("4863ed03-c056-4ba7-a1e9-3d325d9d6146"), "Geotechnical", new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(4054), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("a0e3d142-97f7-489b-9136-1eeae32ed79c"), "Geotechnical", new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(2193), "EditMe!", "serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "AddedDate", "SlideURL", "Text1", "Text2" },
                values: new object[,]
                {
                    { new Guid("bb1216f9-79b3-4301-985e-8291dc2f9194"), new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(111), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("5ea7943c-758b-4e2f-aeea-f3dd8d4277e8"), new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(1560), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("51aa0914-d4e8-4341-bb8c-5716eec5f849"), new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(1616), "slide-01.jpg", "EditMe!", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "SocialMediaAddresses",
                columns: new[] { "Id", "FbAdress", "InstaAdress", "LinkedinAdress" },
                values: new object[] { new Guid("0a765b1d-dc5b-4ea8-91de-f5cf6e49b598"), "EditMe", "EditMe", "EditMe" });

            migrationBuilder.InsertData(
                table: "SpecialServices",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("f1041ad7-6afd-402d-ba0e-6c9737263e06"), "Robotic", new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(6044), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("d4b3607f-a884-4609-8985-d2a1a1409718"), "Robotic", new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(8048), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("75d4067f-4b51-4ea0-952b-67a1d4184e1b"), "Robotic", new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(8104), "EditMe!", "sp-serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "WebSettings",
                columns: new[] { "Id", "Adress", "EmailAdress", "FbAdress", "FotterLogoURL", "FotterText", "InstaAdress", "LinkedinAdress", "LogoURL", "Phone", "WhatsApp" },
                values: new object[] { new Guid("48afc669-75cb-41ca-a6f6-21ecfadca516"), "EditMe!", "EditMe!", "EditMe!", "fotter-logo.png", "EditME!", "EditMe!", "EditMe!", "main-logo.png", "EditMe!", "EditMe!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("2dec1879-5147-4ed3-bb75-39260a3b2d7c"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("370c7af7-1a48-4833-a023-6d60deb38957"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("4e037fbe-59b0-46de-900b-a0f10b29ecd2"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("d648e132-f859-4252-81ad-61b91c44eb84"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("335e6afa-fe0f-4890-888b-a082b1982dea"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("7e69aa84-6c40-4141-a2a5-11e77346bb28"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("15c589a7-cf6c-42ba-8fe2-d2d6530afd9f"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("64e72231-5db8-4910-8ed9-c280bcba3f30"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("abbd62c4-2004-4081-be96-8e81db44e8b1"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("013fc235-e3e2-4d98-bce8-0148540955ee"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("4863ed03-c056-4ba7-a1e9-3d325d9d6146"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a0e3d142-97f7-489b-9136-1eeae32ed79c"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("51aa0914-d4e8-4341-bb8c-5716eec5f849"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("5ea7943c-758b-4e2f-aeea-f3dd8d4277e8"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("bb1216f9-79b3-4301-985e-8291dc2f9194"));

            migrationBuilder.DeleteData(
                table: "SocialMediaAddresses",
                keyColumn: "Id",
                keyValue: new Guid("0a765b1d-dc5b-4ea8-91de-f5cf6e49b598"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("75d4067f-4b51-4ea0-952b-67a1d4184e1b"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("d4b3607f-a884-4609-8985-d2a1a1409718"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("f1041ad7-6afd-402d-ba0e-6c9737263e06"));

            migrationBuilder.DeleteData(
                table: "WebSettings",
                keyColumn: "Id",
                keyValue: new Guid("48afc669-75cb-41ca-a6f6-21ecfadca516"));

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
    }
}
