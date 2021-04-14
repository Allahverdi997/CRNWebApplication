using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IAltProductImageService
    {
        Task<List<AltProductImage>> GetAll();
        Task<AltProductImage> GetWithID(int id);
        Task<bool> Add(AltProductImage entity);
        Task<bool> Update(AltProductImage entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
