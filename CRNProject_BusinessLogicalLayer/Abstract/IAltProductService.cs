using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IAltProductService
    {
        Task<List<AltProduct>> GetAll();
        Task<AltProduct> GetWithID(int id);
        Task<bool> Add(AltProduct entity);
        Task<bool> Update(AltProduct entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
