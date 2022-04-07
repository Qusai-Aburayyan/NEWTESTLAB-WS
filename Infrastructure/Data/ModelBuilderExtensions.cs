using Core.Entites.Aboutus;
using Core.Entites.ApplicationUser;
using Core.Entites.Service;
using Core.Entites.Slide;
using Core.Entites.SpecialService;
using Core.Entites.WebSettings;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public static class ModelBuilderExtensions
    {   
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<WebSettings>().HasData(
                new WebSettings
                {
                    FotterText = "EditME!",
                    Adress = "EditMe!",
                    EmailAdress = "EditMe!",
                    FbAdress = "EditMe!",
                    Id = Guid.NewGuid(),
                    //these field should be deleted
                    InstaAdress = "EditMe!",
                    LinkedinAdress = "EditMe!",
                    Phone = "EditMe!",
                    WhatsApp = "EditMe!",
                    //
                    FotterLogoURL = "fotter-logo.png",
                    LogoURL = "main-logo.png"
                }
                );

            modelBuilder.Entity<SocialMediaAddresses>().HasData(
                new SocialMediaAddresses
                {
                    FbAdress = "https://www.facebook.com/NewtestGeo",
                    InstaAdress = "https://www.facebook.com/NewtestGeo",
                    LinkedinAdress = "https://www.facebook.com/NewtestGeo",
                    Id = Guid.NewGuid()
                });

            for (int i = 0; i < 2; i++)
            {
                modelBuilder.Entity<PdfFile>().HasData(
                new PdfFile
                {
                    AddedDate = DateTime.Now,
                    FileName = "EditMe!",
                    FilePath = "https://drive.google.com/file/d/1FOmBQtqQNLNFv79jevVf9-ollzOcZLqQ/view",
                    Id = Guid.NewGuid()
                });
            }

            for (int i = 0; i < 3; i++)
            {
                modelBuilder.Entity<Slide>().HasData(
                new Slide
                {
                    Text1 = "EditMe!",
                    Text2 = "EditMe!",
                    AddedDate = DateTime.Now,
                    Id = Guid.NewGuid(),
                    SlideURL = "slide-01.jpg"
                }
                );
            }

            modelBuilder.Entity<Aboutus>().HasData(
                new Aboutus
                {
                    Id = Guid.NewGuid(),
                    VisionMissionText = "Edit ME!",
                    Para1 = "Edit ME!",
                    Para2 = "Edit ME!",
                    QPParagraph = "Edit ME!",
                    ImageURL = "about-01.jpg"
                }
                );

            for (int i = 0; i < 3; i++)
            {
                modelBuilder.Entity<Certification>().HasData(
                new Certification
                {
                    AddedDate = DateTime.Now,
                    CertificationName = "EditMe!",
                    CertificationURL = "certification-01.jpg",
                    Id = Guid.NewGuid()
                });
            }

            for (int i = 0; i < 3; i++)
            {
                modelBuilder.Entity<QualityPolicy>().HasData(
                new QualityPolicy
                {
                    AddedDate = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Point = "EditMe!"
                });
            }

            for (int i = 0; i < 3; i++)
            {
                modelBuilder.Entity<Service>().HasData(
                new Service
                {
                    Title = "EditMe!",
                    ActionName = "Geotechnical",
                    AddedDate = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Content = "EditMe!",
                    ImageURL = "serv-01.jpg"
                });
            }

            for (int i = 0; i < 3; i++)
            {
                modelBuilder.Entity<SpecialService>().HasData(
                new SpecialService
                {
                    Title = "EditMe!",
                    ActionName = "Robotic",
                    AddedDate = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Content = "EditMe!",
                    ImageURL = "sp-serv-01.jpg"
                });
            }

        }
    }
}
