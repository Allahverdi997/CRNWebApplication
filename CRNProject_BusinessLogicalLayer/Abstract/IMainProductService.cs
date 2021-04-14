using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IMainProductService
    {
        Task<List<MainProduct>> GetAll();
        Task<MainProduct> GetWithID(int id);
        Task<bool> Add(MainProduct entity);
        Task<bool> Update(MainProduct entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
