using CRNProject_Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_DataAccessLayer.Concrete.EntityFramework
{
    public class CNRContext : DbContext
    {
        public CNRContext(DbContextOptions<CNRContext> options) : base(options)
        {

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<AltIndustry> AltIndustries { get; set; }
        public DbSet<AltIndustryFile> MyProperty { get; set; }
        public DbSet<AltIndustryImage> AltIndustryImages { get; set; }
        public DbSet<AltProduct> AltProducts { get; set; }
        public DbSet<AltProductFile> AltProductFiles { get; set; }
        public DbSet<AltProductImage> AltProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CompanyPoliticy> CompanyPoliticies { get; set; }
        public DbSet<ConstantValue> ConstantValues { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactMail> ContactMails { get; set; }
        public DbSet<CookiesPolitics> CookiesPolitics { get; set; }
        public DbSet<LangTable> LangTables { get; set; }
        public DbSet<MainIndustry> MainIndustries { get; set; }
        public DbSet<MainPageInformationTitle> MainPageInformationTitles { get; set; }
        public DbSet<MainProduct> MainProducts { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<SecurityPolicies> SecurityPolicies { get; set; }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SocialMedia>().HasKey(x => x.Id);
            modelBuilder.Entity<About>().HasKey(x => x.Id);
            modelBuilder.Entity<AltIndustry>().HasKey(x => x.Id);
            modelBuilder.Entity<AltIndustryFile>().HasKey(x => x.Id);
            modelBuilder.Entity<AltIndustryImage>().HasKey(x => x.Id);
            modelBuilder.Entity<AltProduct>().HasKey(x => x.Id);
            modelBuilder.Entity<AltProductFile>().HasKey(x => x.Id);
            modelBuilder.Entity<AltProductImage>().HasKey(x => x.Id);
            modelBuilder.Entity<Category>().HasKey(x => x.Id);
            modelBuilder.Entity<CompanyPoliticy>().HasKey(x => x.Id);

            modelBuilder.Entity<ConstantValue>().HasKey(x => x.Id);
            modelBuilder.Entity<Contact>().HasKey(x => x.Id);
            modelBuilder.Entity<ContactMail>().HasKey(x => x.Id);
            modelBuilder.Entity<CookiesPolitics>().HasKey(x => x.Id);
            modelBuilder.Entity<LangTable>().HasKey(x => x.Id);
            modelBuilder.Entity<MainIndustry>().HasKey(x => x.Id);
            modelBuilder.Entity<MainPageInformationTitle>().HasKey(x => x.Id);
            modelBuilder.Entity<MainProduct>().HasKey(x => x.Id);
            modelBuilder.Entity<Menu>().HasKey(x => x.Id);
            modelBuilder.Entity<SecurityPolicies>().HasKey(x => x.Id);
            modelBuilder.Entity<Slider>().HasKey(x => x.Id);
        }
    }
}
