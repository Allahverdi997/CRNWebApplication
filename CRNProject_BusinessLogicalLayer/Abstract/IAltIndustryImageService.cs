using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IAltIndustryImageService
    {
        Task<List<AltIndustryImage>> GetAll();
        Task<AltIndustryImage> GetWithID(int id);
        Task<bool> Add(AltIndustryImage entity);
        Task<bool> Update(AltIndustryImage entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
