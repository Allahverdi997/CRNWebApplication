using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface ICookiesPoliticsService
    {
        Task<List<CookiesPolitics>> GetAll();
        Task<CookiesPolitics> GetWithID(int id);
        Task<bool> Add(CookiesPolitics entity);
        Task<bool> Update(CookiesPolitics entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
