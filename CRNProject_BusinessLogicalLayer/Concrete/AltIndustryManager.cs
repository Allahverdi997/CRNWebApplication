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
    public class AltIndustryManager : IAltIndustryService
    {
        public IAltIndustryDal altIndustryDal { get; set; }

        public AltIndustryManager(IAltIndustryDal _altIndustryDal)
        {
            altIndustryDal = _altIndustryDal;
        }
        public async Task<bool> Add(AltIndustry entity)
        {
            return await altIndustryDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            AltIndustry entity = await altIndustryDal.Get(x => x.Id == id);
            var result = await altIndustryDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<AltIndustry>> GetAll()
        {
            return await altIndustryDal.GetAll();
        }

        public async Task<AltIndustry> GetWithID(int id)
        {
            return await altIndustryDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await altIndustryDal.SaveChanges();
        }

        public async Task<bool> Update(AltIndustry entity)
        {
            return await altIndustryDal.Update(entity);
        }
    }
}
