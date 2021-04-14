using CRNProject_BusinessLogicalLayer.Abstract;
using CRNProject_BusinessLogicalLayer.Concrete;
using CRNProject_BusinessLogicalLayer.UnitOfWork;
using CRNProject_DataAccessLayer.Abstract;
using CRNProject_DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddMvc(x => x.EnableEndpointRouting = false);

            services.AddDbContext<CNRContext>(options => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=CNRDB;Integrated Security=true;",
                b => b.MigrationsAssembly("CRNProject_DataAccessLayer")));

            services.AddScoped<IAboutDal, EFAboutDal>();
            services.AddScoped<IAltIndustryDal, EFAltIndustryDal>();
            services.AddScoped<IAltIndustryFileDal, EFAltIndustryFileDal>();
            services.AddScoped<IAltIndustryImageDal, EFAltIndustryImageDal>();
            services.AddScoped<IAltProductDal, EFAltProductDal>();
            services.AddScoped<IAltProductFileDal, EFAltProductFileDal>();
            services.AddScoped<IAltProductImageDal, EFAltProductImageDal>();
            services.AddScoped<ICategoryDal, EFCategoryDal>();
            services.AddScoped<ICompanyPoliticyDal, EFCompanyPoliticyDal>();
            services.AddScoped<IConstantValueDal, EFConstantValueDal>();
            services.AddScoped<IContactDal, EFContactDal>();
            services.AddScoped<IContactMailDal, EFContactMailDal>();
            services.AddScoped<ICookiesPoliticsDal, EFCookiesPoliticsDal>();
            services.AddScoped<ILangTableDal, EFLangTableDal>();
            services.AddScoped<IMainIndustryDal, EFMainIndustryDal>();
            services.AddScoped<IMainPageInformationTitleDal, EFMainPageInformationTitleDal>();
            services.AddScoped<IMainProductDal, EFMainProductDal>();
            services.AddScoped<IMenuDal, EFMenuDal>();
            services.AddScoped<ISecurityPoliciesDal, EFSecurityPoliciesDal>();
            services.AddScoped<ISliderDal, EFSliderDal>();
            services.AddScoped<ISocialMediaDal, EFSocialMediaDal>();

            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAltIndustryService, AltIndustryManager>();
            services.AddScoped<IAltIndustryFileService, AltIndustryFileManager>();
            services.AddScoped<IAltIndustryImageService, AltIndustryImageManager>();
            services.AddScoped<IAltProductService, AltProductManager>();
            services.AddScoped<IAltProductFileService, AltProductFileManager>();
            services.AddScoped<IAltProductImageService, AltProductImageManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICompanyPoliticyService, CompanyPoliticyManager>();
            services.AddScoped<IConstantValueService, ConstantValueManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactMailService, ContactMailManager>();
            services.AddScoped<ICookiesPoliticsService, CookiesPoliticsManager>();
            services.AddScoped<ILangTableService, LangTableManager>();
            services.AddScoped<IMainIndustryService, MainIndustryManager>();
            services.AddScoped<IMainPageInformationTitleService, MainPageInformationTitleManager>();
            services.AddScoped<IMainProductService, MainProductManager>();
            services.AddScoped<IMenuService, MenuManager>();
            services.AddScoped<ISecurityPoliciesService, SecurityPoliciesManager>();
            services.AddScoped<ISliderService, SliderManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();



            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseMvc();
            app.UseMvcWithDefaultRoute();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                   name: "MyAreaProducts",
                   areaName: "Admin",
                   pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
                   );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
