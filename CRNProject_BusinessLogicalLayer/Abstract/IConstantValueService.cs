using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IConstantValueService
    {
        Task<List<ConstantValue>> GetAll();
        Task<ConstantValue> GetWithID(int id);
        Task<bool> Add(ConstantValue entity);
        Task<bool> Update(ConstantValue entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
