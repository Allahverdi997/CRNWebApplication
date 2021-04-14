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
    public class AltProductImageManager : IAltProductImageService
    {
        public IAltProductImageDal altProductImageDal { get; set; }

        public AltProductImageManager(IAltProductImageDal _altProductImageDal)
        {
            altProductImageDal = _altProductImageDal;
        }
        public async Task<bool> Add(AltProductImage entity)
        {
            return await altProductImageDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            AltProductImage entity = await altProductImageDal.Get(x => x.Id == id);
            var result = await altProductImageDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<AltProductImage>> GetAll()
        {
            return await altProductImageDal.GetAll();
        }

        public async Task<AltProductImage> GetWithID(int id)
        {
            return await altProductImageDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await altProductImageDal.SaveChanges();
        }

        public async Task<bool> Update(AltProductImage entity)
        {
            return await altProductImageDal.Update(entity);
        }
    }
}
