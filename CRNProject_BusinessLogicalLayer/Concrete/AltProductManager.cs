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
    public class AltProductManager : IAltProductService
    {
        public IAltProductDal altProductDal { get; set; }

        public AltProductManager(IAltProductDal _altProductDal)
        {
            altProductDal = _altProductDal;
        }
        public async Task<bool> Add(AltProduct entity)
        {
            return await altProductDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            AltProduct entity = await altProductDal.Get(x => x.Id == id);
            var result = await altProductDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<AltProduct>> GetAll()
        {
            return await altProductDal.GetAll();
        }

        public async Task<AltProduct> GetWithID(int id)
        {
            return await altProductDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await altProductDal.SaveChanges();
        }

        public async Task<bool> Update(AltProduct entity)
        {
            return await altProductDal.Update(entity);
        }
    }
}
