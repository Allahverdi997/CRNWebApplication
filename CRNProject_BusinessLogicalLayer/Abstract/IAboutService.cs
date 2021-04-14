using CRNProject_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IAboutService
    {
        Task<List<About>> GetAll();
        Task<About> GetWithID(int id);
        Task<bool> Add(About entity);
        Task<bool> Update(About entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
