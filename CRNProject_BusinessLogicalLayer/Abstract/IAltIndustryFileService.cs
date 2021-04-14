using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IAltIndustryFileService
    {
        Task<List<AltIndustryFile>> GetAll();
        Task<AltIndustryFile> GetWithID(int id);
        Task<bool> Add(AltIndustryFile entity);
        Task<bool> Update(AltIndustryFile entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
