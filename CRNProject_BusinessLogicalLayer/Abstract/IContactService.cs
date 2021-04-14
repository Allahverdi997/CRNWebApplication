using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IContactService
    {
        Task<List<Contact>> GetAll();
        Task<Contact> GetWithID(int id);
        Task<bool> Add(Contact entity);
        Task<bool> Update(Contact entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
