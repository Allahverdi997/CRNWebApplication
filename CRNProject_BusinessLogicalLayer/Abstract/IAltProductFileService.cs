using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IAltProductFileService
    {
        Task<List<AltProductFile>> GetAll();
        Task<AltProductFile> GetWithID(int id);
        Task<bool> Add(AltProductFile entity);
        Task<bool> Update(AltProductFile entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
