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
    public class AltIndustryImageManager : IAltIndustryImageService
    {
        public IAltIndustryImageDal altIndustryImageDal { get; set; }

        public AltIndustryImageManager(IAltIndustryImageDal _altIndustryImageDal)
        {
            altIndustryImageDal = _altIndustryImageDal;
        }
        public async Task<bool> Add(AltIndustryImage entity)
        {
            return await altIndustryImageDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            AltIndustryImage entity = await altIndustryImageDal.Get(x => x.Id == id);
            var result = await altIndustryImageDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<AltIndustryImage>> GetAll()
        {
            return await altIndustryImageDal.GetAll();
        }

        public async Task<AltIndustryImage> GetWithID(int id)
        {
            return await altIndustryImageDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await altIndustryImageDal.SaveChanges();
        }

        public async Task<bool> Update(AltIndustryImage entity)
        {
            return await altIndustryImageDal.Update(entity);
        }
    }
}
