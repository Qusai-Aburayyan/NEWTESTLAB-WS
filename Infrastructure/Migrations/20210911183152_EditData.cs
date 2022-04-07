using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class EditData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("e8e7d891-4976-485b-bbdc-36b7b15174b5"), "about-01.jpg", "Edit ME!", "Edit ME!", "Edit ME!", "Edit ME!" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "AddedDate", "CertificationName", "CertificationURL" },
                values: new object[,]
                {
                    { new Guid("879ee92b-2b53-4c44-a5bd-aec982a1f2da"), new DateTime(2021, 9, 11, 21, 31, 51, 992, DateTimeKind.Local).AddTicks(5670), "EditMe!", "certification-01.jpg" },
                    { new Guid("a353890a-7bf5-4798-b011-760a56b775a6"), new DateTime(2021, 9, 11, 21, 31, 51, 992, DateTimeKind.Local).AddTicks(7692), "EditMe!", "certification-01.jpg" },
                    { new Guid("2f6b7595-fe04-4e58-88da-f6b44413f2a6"), new DateTime(2021, 9, 11, 21, 31, 51, 992, DateTimeKind.Local).AddTicks(7747), "EditMe!", "certification-01.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PdfFiles",
                columns: new[] { "Id", "AddedDate", "FileName", "FilePath" },
                values: new object[,]
                {
                    { new Guid("0d10f146-0d83-4877-a6bc-0c42221b55ed"), new DateTime(2021, 9, 11, 21, 31, 51, 991, DateTimeKind.Local).AddTicks(7409), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" },
                    { new Guid("d8895f93-615c-4821-95f2-8bf6ed4da528"), new DateTime(2021, 9, 11, 21, 31, 51, 988, DateTimeKind.Local).AddTicks(3371), "EditMe!", "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view" }
                });

            migrationBuilder.InsertData(
                table: "QualityPolicies",
                columns: new[] { "Id", "AddedDate", "Point" },
                values: new object[,]
                {
                    { new Guid("5ddf3010-e72c-4d6d-a3b8-5e6ec35b6033"), new DateTime(2021, 9, 11, 21, 31, 51, 992, DateTimeKind.Local).AddTicks(8383), "EditMe!" },
                    { new Guid("4222df5d-496b-44c0-a744-b18b95dd0d1b"), new DateTime(2021, 9, 11, 21, 31, 51, 992, DateTimeKind.Local).AddTicks(9756), "EditMe!" },
                    { new Guid("dad99a33-17e0-4444-b4d7-ae0e0bb9c1ec"), new DateTime(2021, 9, 11, 21, 31, 51, 992, DateTimeKind.Local).AddTicks(9812), "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("4f587e13-50ab-4f16-98a4-94ee0c5612bb"), "Geotechnical", new DateTime(2021, 9, 11, 21, 31, 51, 993, DateTimeKind.Local).AddTicks(3607), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("7f2386eb-7c62-49a0-b983-4300ab3b3f00"), "Geotechnical", new DateTime(2021, 9, 11, 21, 31, 51, 993, DateTimeKind.Local).AddTicks(3543), "EditMe!", "serv-01.jpg", "EditMe!" },
                    { new Guid("280cc275-4c1a-426e-aef7-58656e862a7b"), "Geotechnical", new DateTime(2021, 9, 11, 21, 31, 51, 993, DateTimeKind.Local).AddTicks(1512), "EditMe!", "serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "AddedDate", "SlideURL", "Text1", "Text2" },
                values: new object[,]
                {
                    { new Guid("3971364c-b414-45bc-a074-3cb5b68293ec"), new DateTime(2021, 9, 11, 21, 31, 51, 991, DateTimeKind.Local).AddTicks(9502), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("a7bc7a68-e012-4437-9c17-4caacb2bf1c6"), new DateTime(2021, 9, 11, 21, 31, 51, 992, DateTimeKind.Local).AddTicks(1003), "slide-01.jpg", "EditMe!", "EditMe!" },
                    { new Guid("0a67997f-b49f-4d4b-9e9d-5a1765765526"), new DateTime(2021, 9, 11, 21, 31, 51, 992, DateTimeKind.Local).AddTicks(1064), "slide-01.jpg", "EditMe!", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "SocialMediaAddresses",
                columns: new[] { "Id", "FbAdress", "InstaAdress", "LinkedinAdress" },
                values: new object[] { new Guid("aae3505d-1107-49a1-aec3-54db9f0268c3"), "https://www.facebook.com/NewtestGeo", "https://www.facebook.com/NewtestGeo", "https://www.facebook.com/NewtestGeo" });

            migrationBuilder.InsertData(
                table: "SpecialServices",
                columns: new[] { "Id", "ActionName", "AddedDate", "Content", "ImageURL", "Title" },
                values: new object[,]
                {
                    { new Guid("b63fa9de-51b6-4f3f-b4f4-662d8ad162b2"), "Robotic", new DateTime(2021, 9, 11, 21, 31, 51, 993, DateTimeKind.Local).AddTicks(5307), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("de2a9fca-a4bf-42b5-b80d-fc1b6794230e"), "Robotic", new DateTime(2021, 9, 11, 21, 31, 51, 993, DateTimeKind.Local).AddTicks(7141), "EditMe!", "sp-serv-01.jpg", "EditMe!" },
                    { new Guid("76cf9ddb-377f-4494-9c96-f6a1b26ee1c2"), "Robotic", new DateTime(2021, 9, 11, 21, 31, 51, 993, DateTimeKind.Local).AddTicks(7200), "EditMe!", "sp-serv-01.jpg", "EditMe!" }
                });

            migrationBuilder.InsertData(
                table: "WebSettings",
                columns: new[] { "Id", "Adress", "EmailAdress", "FbAdress", "FotterLogoURL", "FotterText", "InstaAdress", "LinkedinAdress", "LogoURL", "Phone", "WhatsApp" },
                values: new object[] { new Guid("68b57642-34cd-4c7e-9379-2d34c56315a2"), "EditMe!", "EditMe!", "EditMe!", "fotter-logo.png", "EditME!", "EditMe!", "EditMe!", "main-logo.png", "EditMe!", "EditMe!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aboutus",
                keyColumn: "Id",
                keyValue: new Guid("e8e7d891-4976-485b-bbdc-36b7b15174b5"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("2f6b7595-fe04-4e58-88da-f6b44413f2a6"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("879ee92b-2b53-4c44-a5bd-aec982a1f2da"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("a353890a-7bf5-4798-b011-760a56b775a6"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("0d10f146-0d83-4877-a6bc-0c42221b55ed"));

            migrationBuilder.DeleteData(
                table: "PdfFiles",
                keyColumn: "Id",
                keyValue: new Guid("d8895f93-615c-4821-95f2-8bf6ed4da528"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("4222df5d-496b-44c0-a744-b18b95dd0d1b"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("5ddf3010-e72c-4d6d-a3b8-5e6ec35b6033"));

            migrationBuilder.DeleteData(
                table: "QualityPolicies",
                keyColumn: "Id",
                keyValue: new Guid("dad99a33-17e0-4444-b4d7-ae0e0bb9c1ec"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("280cc275-4c1a-426e-aef7-58656e862a7b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("4f587e13-50ab-4f16-98a4-94ee0c5612bb"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7f2386eb-7c62-49a0-b983-4300ab3b3f00"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("0a67997f-b49f-4d4b-9e9d-5a1765765526"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("3971364c-b414-45bc-a074-3cb5b68293ec"));

            migrationBuilder.DeleteData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: new Guid("a7bc7a68-e012-4437-9c17-4caacb2bf1c6"));

            migrationBuilder.DeleteData(
                table: "SocialMediaAddresses",
                keyColumn: "Id",
                keyValue: new Guid("aae3505d-1107-49a1-aec3-54db9f0268c3"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("76cf9ddb-377f-4494-9c96-f6a1b26ee1c2"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("b63fa9de-51b6-4f3f-b4f4-662d8ad162b2"));

            migrationBuilder.DeleteData(
                table: "SpecialServices",
                keyColumn: "Id",
                keyValue: new Guid("de2a9fca-a4bf-42b5-b80d-fc1b6794230e"));

            migrationBuilder.DeleteData(
                table: "WebSettings",
                keyColumn: "Id",
                keyValue: new Guid("68b57642-34cd-4c7e-9379-2d34c56315a2"));

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
    }
}
