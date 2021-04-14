using CRNProject_BusinessLogicalLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_BusinessLogicalLayer.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IAboutService aboutService { get; }
        public IAltIndustryFileService altIndustryFileService { get; }
        public IAltIndustryImageService altIndustryImageService { get; }
        public IAltIndustryService altIndustryService { get; }
        public IAltProductFileService altProductFileService { get; }
        public IAltProductImageService altProductImageService { get; }
        public IAltProductService altProductService { get; }
        public ICategoryService categoryService { get; }
        public ICompanyPoliticyService companyPoliticyService { get; }
        public IConstantValueService constantValueService { get; }
        public IContactMailService contactMailService { get; }
        public IContactService contactService { get; }
        public ICookiesPoliticsService cookiesPoliticsService { get; }
        public ILangTableService langTableService { get; }
        public IMainIndustryService mainIndustryService { get; }
        public IMainPageInformationTitleService mainPageInformationTitleService { get; }
        public IMainProductService mainProductService { get; }
        public IMenuService menuService { get; }
        public ISecurityPoliciesService securityPoliciesService { get; }

        public ISliderService sliderService { get; }
        public ISocialMediaService socialMediaService { get; }
    }
}
