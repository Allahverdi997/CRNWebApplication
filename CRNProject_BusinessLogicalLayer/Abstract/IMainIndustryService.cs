using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IMainIndustryService
    {
        Task<List<MainIndustry>> GetAll();
        Task<MainIndustry> GetWithID(int id);
        Task<bool> Add(MainIndustry entity);
        Task<bool> Update(MainIndustry entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
