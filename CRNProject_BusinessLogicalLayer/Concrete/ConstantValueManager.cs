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
    public class ConstantValueManager : IConstantValueService
    {
        public IConstantValueDal constantValueDal { get; set; }

        public ConstantValueManager(IConstantValueDal _constantValueDal)
        {
            constantValueDal = _constantValueDal;
        }
        public async Task<bool> Add(ConstantValue entity)
        {
            return await constantValueDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            ConstantValue entity = await constantValueDal.Get(x => x.Id == id);
            var result = await constantValueDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<ConstantValue>> GetAll()
        {
            return await constantValueDal.GetAll();
        }

        public async Task<ConstantValue> GetWithID(int id)
        {
            return await constantValueDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await constantValueDal.SaveChanges();
        }

        public async Task<bool> Update(ConstantValue entity)
        {
            return await constantValueDal.Update(entity);
        }
    }
}
