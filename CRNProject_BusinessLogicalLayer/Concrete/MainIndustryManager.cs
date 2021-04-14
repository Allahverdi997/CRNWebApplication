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
    public class MainIndustryManager : IMainIndustryService
    {
        public IMainIndustryDal mainIndustryDal { get; set; }

        public MainIndustryManager(IMainIndustryDal _mainIndustryDal)
        {
            mainIndustryDal = _mainIndustryDal;
        }
        public async Task<bool> Add(MainIndustry entity)
        {
            return await mainIndustryDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            MainIndustry entity = await mainIndustryDal.Get(x => x.Id == id);
            var result = await mainIndustryDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<MainIndustry>> GetAll()
        {
            return await mainIndustryDal.GetAll();
        }

        public async Task<MainIndustry> GetWithID(int id)
        {
            return await mainIndustryDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await mainIndustryDal.SaveChanges();
        }

        public async Task<bool> Update(MainIndustry entity)
        {
            return await mainIndustryDal.Update(entity);
        }
    }
}
