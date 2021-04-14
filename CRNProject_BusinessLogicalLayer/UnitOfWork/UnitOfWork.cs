using CRNProject_BusinessLogicalLayer.Abstract;
using CRNProject_BusinessLogicalLayer.Concrete;
using CRNProject_DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_BusinessLogicalLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private CNRContext context;
        public UnitOfWork(CNRContext _context)
        {
            context = _context;
        }
        public IAboutService AboutService { get; set; }
        public IAboutService aboutService
        {
            get { return AboutService ?? new AboutManager(new EFAboutDal(context)); }
        }

        public IAltIndustryFileService AltIndustryFileService { get; set; }
        public IAltIndustryFileService altIndustryFileService
        {
            get { return AltIndustryFileService ?? new AltIndustryFileManager(new EFAltIndustryFileDal(context)); }
        }

        public IAltIndustryImageService AltIndustryImageService { get; set; }
        public IAltIndustryImageService altIndustryImageService
        {
            get { return AltIndustryImageService ?? new AltIndustryImageManager(new EFAltIndustryImageDal(context)); }
        }

        public IAltIndustryService AltIndustryService { get; set; }
        public IAltIndustryService altIndustryService
        {
            get { return AltIndustryService ?? new AltIndustryManager(new EFAltIndustryDal(context)); }
        }

        public IAltProductFileService AltProductFileService { get; set; }
        public IAltProductFileService altProductFileService
        {
            get { return AltProductFileService ?? new AltProductFileManager(new EFAltProductFileDal(context)); }
        }

        public IAltProductImageService AltProductImageService { get; set; }
        public IAltProductImageService altProductImageService
        {
            get { return AltProductImageService ?? new AltProductImageManager(new EFAltProductImageDal(context)); }
        }

        public IAltProductService AltProductService { get; set; }
        public IAltProductService altProductService
        {
            get { return AltProductService ?? new AltProductManager(new EFAltProductDal(context)); }
        }

        public ICategoryService CategoryService { get; set; }
        public ICategoryService categoryService
        {
            get { return CategoryService ?? new CategoryManager(new EFCategoryDal(context)); }
        }

        public ICompanyPoliticyService CompanyPoliticyService { get; set; }
        public ICompanyPoliticyService companyPoliticyService
        {
            get { return CompanyPoliticyService ?? new CompanyPoliticyManager(new EFCompanyPoliticyDal(context)); }
        }

        public IConstantValueService ConstantValueService { get; set; }
        public IConstantValueService constantValueService
        {
            get { return ConstantValueService ?? new ConstantValueManager(new EFConstantValueDal(context)); }
        }

        public IContactMailService ContactMailService { get; set; }
        public IContactMailService contactMailService
        {
            get { return ContactMailService ?? new ContactMailManager(new EFContactMailDal(context)); }
        }

        public IContactService ContactService { get; set; }
        public IContactService contactService
        {
            get { return ContactService ?? new ContactManager(new EFContactDal(context)); }
        }

        public ICookiesPoliticsService CookiesPoliticsService { get; set; }

        public ICookiesPoliticsService cookiesPoliticsService
        {
            get { return CookiesPoliticsService ?? new CookiesPoliticsManager(new EFCookiesPoliticsDal(context)); }
        }

        public ILangTableService LangTableService { get; set; }
        public ILangTableService langTableService
        {
            get { return LangTableService ?? new LangTableManager(new EFLangTableDal(context)); }
        }

        public IMainIndustryService MainIndustryService { get; set; }
        public IMainIndustryService mainIndustryService
        {
            get { return MainIndustryService ?? new MainIndustryManager(new EFMainIndustryDal(context)); }
        }

        public IMainPageInformationTitleService MainPageInformationTitleService { get; set; }
        public IMainPageInformationTitleService mainPageInformationTitleService
        {
            get { return MainPageInformationTitleService ?? new MainPageInformationTitleManager(new EFMainPageInformationTitleDal(context)); }
        }

        public IMainProductService MainProductService { get; set; }
        public IMainProductService mainProductService
        {
            get { return MainProductService ?? new MainProductManager(new EFMainProductDal(context)); }
        }

        public IMenuService MenuService { get; set; }
        public IMenuService menuService
        {
            get { return MenuService ?? new MenuManager(new EFMenuDal(context)); }
        }

        public ISecurityPoliciesService SecurityPoliciesService { get; set; }
        public ISecurityPoliciesService securityPoliciesService
        {
            get { return SecurityPoliciesService ?? new SecurityPoliciesManager(new EFSecurityPoliciesDal(context)); }
        }

        public ISliderService SliderService { get; set; }
        public ISliderService sliderService
        {
            get { return SliderService ?? new SliderManager(new EFSliderDal(context)); }
        }

        public ISocialMediaService SocialMediaService { get; set; }
        public ISocialMediaService socialMediaService
        {
            get { return SocialMediaService ?? new SocialMediaManager(new EFSocialMediaDal(context)); }
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
