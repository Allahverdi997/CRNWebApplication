using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_BusinessLogicalLayer.Abstract;
using CRNProject_DataAccessLayer.Abstract;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Concrete
{
    public class MainPageInformationTitleManager : IMainPageInformationTitleService
    {
        public IMainPageInformationTitleDal mainPageInformationTitleDal { get; set; }

        public MainPageInformationTitleManager(IMainPageInformationTitleDal _mainPageInformationTitleDal)
        {
            mainPageInformationTitleDal = _mainPageInformationTitleDal;
        }
        public async Task<bool> Add(MainPageInformationTitle entity)
        {
            return await mainPageInformationTitleDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            MainPageInformationTitle entity = await mainPageInformationTitleDal.Get(x => x.Id == id);
            var result = await mainPageInformationTitleDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<MainPageInformationTitle>> GetAll()
        {
            return await mainPageInformationTitleDal.GetAll();
        }

        public async Task<MainPageInformationTitle> GetWithID(int id)
        {
            return await mainPageInformationTitleDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await mainPageInformationTitleDal.SaveChanges();
        }

        public async Task<bool> Update(MainPageInformationTitle entity)
        {
            return await mainPageInformationTitleDal.Update(entity);
        }
    }
}
