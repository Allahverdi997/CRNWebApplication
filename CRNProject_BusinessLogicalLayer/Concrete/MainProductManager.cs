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
    public class MainProductManager : IMainProductService
    {
        public IMainProductDal mainProductDal { get; set; }

        public MainProductManager(IMainProductDal _mainProductDal)
        {
            mainProductDal = _mainProductDal;
        }
        public async Task<bool> Add(MainProduct entity)
        {
            return await mainProductDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            MainProduct entity = await mainProductDal.Get(x => x.Id == id);
            var result = await mainProductDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<MainProduct>> GetAll()
        {
            return await mainProductDal.GetAll();
        }

        public async Task<MainProduct> GetWithID(int id)
        {
            return await mainProductDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await mainProductDal.SaveChanges();
        }

        public async Task<bool> Update(MainProduct entity)
        {
            return await mainProductDal.Update(entity);
        }
    }
}
