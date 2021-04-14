using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface ICompanyPoliticyService
    {
        Task<List<CompanyPoliticy>> GetAll();
        Task<CompanyPoliticy> GetWithID(int id);
        Task<bool> Add(CompanyPoliticy entity);
        Task<bool> Update(CompanyPoliticy entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
