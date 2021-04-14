using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface ILangTableService
    {
        Task<List<LangTable>> GetAll();
        Task<LangTable> GetWithID(int id);
        Task<bool> Add(LangTable entity);
        Task<bool> Update(LangTable entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
