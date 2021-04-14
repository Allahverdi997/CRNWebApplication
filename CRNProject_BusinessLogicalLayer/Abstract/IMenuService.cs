using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IMenuService
    {
        Task<List<Menu>> GetAll();
        Task<Menu> GetWithID(int id);
        Task<bool> Add(Menu entity);
        Task<bool> Update(Menu entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
