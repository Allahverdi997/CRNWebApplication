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
    public class LangTableManager : ILangTableService
    {
        public ILangTableDal langTableDal { get; set; }

        public LangTableManager(ILangTableDal _langTableDal)
        {
            langTableDal = _langTableDal;
        }
        public async Task<bool> Add(LangTable entity)
        {
            return await langTableDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            LangTable entity = await langTableDal.Get(x => x.Id == id);
            var result = await langTableDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<LangTable>> GetAll()
        {
            return await langTableDal.GetAll();
        }

        public async Task<LangTable> GetWithID(int id)
        {
            return await langTableDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await langTableDal.SaveChanges();
        }

        public async Task<bool> Update(LangTable entity)
        {
            return await langTableDal.Update(entity);
        }
    }
}
