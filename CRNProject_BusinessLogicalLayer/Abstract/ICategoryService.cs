using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAll();
        Task<Category> GetWithID(int id);
        Task<bool> Add(Category entity);
        Task<bool> Update(Category entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
