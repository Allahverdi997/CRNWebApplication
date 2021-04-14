using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface IContactMailService
    {
        Task<List<ContactMail>> GetAll();
        Task<ContactMail> GetWithID(int id);
        Task<bool> Add(ContactMail entity);
        Task<bool> Update(ContactMail entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
