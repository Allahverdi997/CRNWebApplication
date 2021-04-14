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
    public class AltIndustryFileManager : IAltIndustryFileService
    {
        public IAltIndustryFileDal altIndustryFileDal { get; set; }

        public AltIndustryFileManager(IAltIndustryFileDal _altIndustryFileDal)
        {
            altIndustryFileDal = _altIndustryFileDal;
        }
        public async Task<bool> Add(AltIndustryFile entity)
        {
            return await altIndustryFileDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            AltIndustryFile entity = await altIndustryFileDal.Get(x => x.Id == id);
            var result = await altIndustryFileDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<AltIndustryFile>> GetAll()
        {
            return await altIndustryFileDal.GetAll();
        }

        public async Task<AltIndustryFile> GetWithID(int id)
        {
            return await altIndustryFileDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await altIndustryFileDal.SaveChanges();
        }

        public async Task<bool> Update(AltIndustryFile entity)
        {
            return await altIndustryFileDal.Update(entity);
        }
    }
}
