using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IAltIndustryService
    {
        Task<List<AltIndustry>> GetAll();
        Task<AltIndustry> GetWithID(int id);
        Task<bool> Add(AltIndustry entity);
        Task<bool> Update(AltIndustry entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
