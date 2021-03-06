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
    [Migration("20210908185934_ExtendIdentityUser")]
    partial class ExtendIdentityUser
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
                            Id = new Guid("45a9e4af-30b2-461d-b924-efd62c551b45"),
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
                            Id = new Guid("1c621308-15d4-42d9-b31f-7ffe977f0d9a"),
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(5824),
                            CertificationName = "EditMe!",
                            CertificationURL = "certification-01.jpg"
                        },
                        new
                        {
                            Id = new Guid("1f31842c-83f2-43d3-946d-ac8cc3365125"),
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(7816),
                            CertificationName = "EditMe!",
                            CertificationURL = "certification-01.jpg"
                        },
                        new
                        {
                            Id = new Guid("6cf82ea7-c63e-4370-992a-91bba5d16308"),
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(7869),
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
                            Id = new Guid("bb4186c7-7870-4c4a-9dd3-f3b455f1fe45"),
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(8519),
                            Point = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("9d9f757c-eaac-48a7-aa93-f63fd079fd01"),
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(9912),
                            Point = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("61bcf16d-dee5-4e18-8e6f-67860148f091"),
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(9964),
                            Point = "EditMe!"
                        });
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
                            Id = new Guid("63a2835c-31e1-4b47-946b-387ce45b853e"),
                            ActionName = "Geotechnical",
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 390, DateTimeKind.Local).AddTicks(1713),
                            Content = "EditMe!",
                            ImageURL = "serv-01.jpg",
                            Title = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("c301a51f-923b-4ccf-b4eb-efab01d5d3b0"),
                            ActionName = "Geotechnical",
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 390, DateTimeKind.Local).AddTicks(3659),
                            Content = "EditMe!",
                            ImageURL = "serv-01.jpg",
                            Title = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("2e1b2938-3d95-4424-87b8-ebccc2dd2621"),
                            ActionName = "Geotechnical",
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 390, DateTimeKind.Local).AddTicks(3714),
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
                            Id = new Guid("3d910dd8-3ee1-44a3-ac60-c4c1eb5ec975"),
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 388, DateTimeKind.Local).AddTicks(9486),
                            SlideURL = "slide-01.jpg",
                            Text1 = "EditMe!",
                            Text2 = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("e15fabde-3ed6-4ab9-9d51-9d8b80f8a463"),
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(1035),
                            SlideURL = "slide-01.jpg",
                            Text1 = "EditMe!",
                            Text2 = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("40e056c2-63ae-45d1-b694-026f4b1bed88"),
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 389, DateTimeKind.Local).AddTicks(1094),
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
                            Id = new Guid("d2d867ef-d9c8-4f9d-838a-3980371aee58"),
                            ActionName = "Robotic",
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 390, DateTimeKind.Local).AddTicks(5478),
                            Content = "EditMe!",
                            ImageURL = "sp-serv-01.jpg",
                            Title = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("79691732-c986-414c-b9e2-11504035c396"),
                            ActionName = "Robotic",
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 390, DateTimeKind.Local).AddTicks(7485),
                            Content = "EditMe!",
                            ImageURL = "sp-serv-01.jpg",
                            Title = "EditMe!"
                        },
                        new
                        {
                            Id = new Guid("d90983e8-f4c7-4487-9eb9-d9778c96e4ad"),
                            ActionName = "Robotic",
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 390, DateTimeKind.Local).AddTicks(7545),
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
                            Id = new Guid("0602fc04-365d-4bcf-8561-27f36146b753"),
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 385, DateTimeKind.Local).AddTicks(3767),
                            FileName = "EditMe!",
                            FilePath = "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view"
                        },
                        new
                        {
                            Id = new Guid("d727d02e-e837-4e41-bfdf-b3af151a5153"),
                            AddedDate = new DateTime(2021, 9, 8, 21, 59, 33, 388, DateTimeKind.Local).AddTicks(7428),
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
                            Id = new Guid("7cb3ca25-e28d-4c7c-8224-6744f4be78e9"),
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
