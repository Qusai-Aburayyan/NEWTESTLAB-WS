using Core.Entites.Aboutus;
using Core.Entites.ApplicationUser;
using Core.Entites.Contactus;
using Core.Entites.Service;
using Core.Entites.Slide;
using Core.Entites.SpecialService;
using Core.Entites.WebSettings;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AppDataContext : IdentityDbContext<ApplicationUser>
    {
        public AppDataContext(DbContextOptions<AppDataContext> options)
            : base(options)
        {

        }
               

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Service>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<SpecialService>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<Contactus>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<Slide>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Aboutus>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Certification>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<QualityPolicy>().Property(x => x.Id).HasDefaultValueSql("NEWID()");


            modelBuilder.Entity<WebSettings>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<SocialMediaAddresses>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<PdfFile>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            modelBuilder.Seed();
        }
        public DbSet<Service> Services { get; set; }
        public DbSet<SpecialService> SpecialServices { get; set; }

        public DbSet<Contactus> Contactus { get; set; }

        public DbSet<Slide> Slides { get; set; }
        public DbSet<Aboutus> Aboutus { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<QualityPolicy> QualityPolicies { get; set; }


        public DbSet<WebSettings> WebSettings { get; set; }
        public DbSet<SocialMediaAddresses> SocialMediaAddresses { get; set; }
        public DbSet<PdfFile> PdfFiles { get; set; }

    }
}
