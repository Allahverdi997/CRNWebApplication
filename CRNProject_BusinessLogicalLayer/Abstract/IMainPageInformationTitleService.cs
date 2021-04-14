using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IMainPageInformationTitleService
    {
        Task<List<MainPageInformationTitle>> GetAll();
        Task<MainPageInformationTitle> GetWithID(int id);
        Task<bool> Add(MainPageInformationTitle entity);
        Task<bool> Update(MainPageInformationTitle entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
