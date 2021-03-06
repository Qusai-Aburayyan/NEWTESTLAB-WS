// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20210909061200_SeedsocialMedia")]
    partial class SeedsocialMedia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entites.Aboutus.Aboutus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Para1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Para2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QPParagraph")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VisionMissionText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aboutus");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2dec1879-5147-4ed3-bb75-39260a3b2d7c"),
                            ImageURL = "about-01.jpg",
                            Para1 = "Edit ME!",
                            Para2 = "Edit ME!",
                            QPParagraph = "Edit ME!",
                            VisionMissionText = "Edit ME!"
                        });
                });

            modelBuilder.Entity("Core.Entites.Aboutus.Certification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CertificationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificationURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Certifications");

                    b.HasData(
                        new
                        {
                            Id = new Guid("370c7af7-1a48-4833-a023-6d60deb38957"),
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(6106),
                            CertificationName = "EditMe!",
                            CertificationURL = "certification-01.jpg"
                        },
                        new
                        {
                            Id = new Guid("4e037fbe-59b0-46de-900b-a0f10b29ecd2"),
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(8294),
                            CertificationName = "EditMe!",
                            CertificationURL = "certification-01.jpg"
                        },
                        new
                        {
                            Id = new Guid("d648e132-f859-4252-81ad-61b91c44eb84"),
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(8346),
                            CertificationName = "EditMe!",
                            CertificationURL = "certification-01.jpg"
                        });
                });

            modelBuilder.Entity("Core.Entites.Aboutus.QualityPolicy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Point")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QualityPolicies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("abbd62c4-2004-4081-be96-8e81db44e8b1"),
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(8987),
                            Point = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("15c589a7-cf6c-42ba-8fe2-d2d6530afd9f"),
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(340),
                            Point = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("64e72231-5db8-4910-8ed9-c280bcba3f30"),
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(392),
                            Point = "EditMe!"
                        });
                });

            modelBuilder.Entity("Core.Entites.ApplicationUser.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("UserRole")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Core.Entites.Contactus.Contactus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contactus");
                });

            modelBuilder.Entity("Core.Entites.Service.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("ActionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a0e3d142-97f7-489b-9136-1eeae32ed79c"),
                            ActionName = "Geotechnical",
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(2193),
                            Content = "EditMe!",
                            ImageURL = "serv-01.jpg",
                            Title = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("4863ed03-c056-4ba7-a1e9-3d325d9d6146"),
                            ActionName = "Geotechnical",
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(4054),
                            Content = "EditMe!",
                            ImageURL = "serv-01.jpg",
                            Title = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("013fc235-e3e2-4d98-bce8-0148540955ee"),
                            ActionName = "Geotechnical",
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(4107),
                            Content = "EditMe!",
                            ImageURL = "serv-01.jpg",
                            Title = "EditMe!"
                        });
                });

            modelBuilder.Entity("Core.Entites.Slide.Slide", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SlideURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Slides");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bb1216f9-79b3-4301-985e-8291dc2f9194"),
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(111),
                            SlideURL = "slide-01.jpg",
                            Text1 = "EditMe!",
                            Text2 = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("5ea7943c-758b-4e2f-aeea-f3dd8d4277e8"),
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(1560),
                            SlideURL = "slide-01.jpg",
                            Text1 = "EditMe!",
                            Text2 = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("51aa0914-d4e8-4341-bb8c-5716eec5f849"),
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 452, DateTimeKind.Local).AddTicks(1616),
                            SlideURL = "slide-01.jpg",
                            Text1 = "EditMe!",
                            Text2 = "EditMe!"
                        });
                });

            modelBuilder.Entity("Core.Entites.SpecialService.SpecialService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("ActionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SpecialServices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f1041ad7-6afd-402d-ba0e-6c9737263e06"),
                            ActionName = "Robotic",
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(6044),
                            Content = "EditMe!",
                            ImageURL = "sp-serv-01.jpg",
                            Title = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("d4b3607f-a884-4609-8985-d2a1a1409718"),
                            ActionName = "Robotic",
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(8048),
                            Content = "EditMe!",
                            ImageURL = "sp-serv-01.jpg",
                            Title = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("75d4067f-4b51-4ea0-952b-67a1d4184e1b"),
                            ActionName = "Robotic",
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 453, DateTimeKind.Local).AddTicks(8104),
                            Content = "EditMe!",
                            ImageURL = "sp-serv-01.jpg",
                            Title = "EditMe!"
                        });
                });

            modelBuilder.Entity("Core.Entites.WebSettings.PdfFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PdfFiles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7e69aa84-6c40-4141-a2a5-11e77346bb28"),
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 448, DateTimeKind.Local).AddTicks(4488),
                            FileName = "EditMe!",
                            FilePath = "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view"
                        },
                        new
                        {
                            Id = new Guid("335e6afa-fe0f-4890-888b-a082b1982dea"),
                            AddedDate = new DateTime(2021, 9, 9, 9, 11, 59, 451, DateTimeKind.Local).AddTicks(8139),
                            FileName = "EditMe!",
                            FilePath = "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view"
                        });
                });

            modelBuilder.Entity("Core.Entites.WebSettings.SocialMediaAddresses", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("FbAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstaAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedinAdress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SocialMediaAddresses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0a765b1d-dc5b-4ea8-91de-f5cf6e49b598"),
                            FbAdress = "EditMe",
                            InstaAdress = "EditMe",
                            LinkedinAdress = "EditMe"
                        });
                });

            modelBuilder.Entity("Core.Entites.WebSettings.WebSettings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FbAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotterLogoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotterText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstaAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedinAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhatsApp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WebSettings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("48afc669-75cb-41ca-a6f6-21ecfadca516"),
                            Adress = "EditMe!",
                            EmailAdress = "EditMe!",
                            FbAdress = "EditMe!",
                            FotterLogoURL = "fotter-logo.png",
                            FotterText = "EditME!",
                            InstaAdress = "EditMe!",
                            LinkedinAdress = "EditMe!",
                            LogoURL = "main-logo.png",
                            Phone = "EditMe!",
                            WhatsApp = "EditMe!"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Core.Entites.ApplicationUser.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Core.Entites.ApplicationUser.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entites.ApplicationUser.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Core.Entites.ApplicationUser.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
