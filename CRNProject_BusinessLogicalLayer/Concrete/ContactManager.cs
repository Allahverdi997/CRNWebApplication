using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_BusinessLogicalLayer.Abstract;
using CRNProject_DataAccessLayer.Abstract;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Concrete
{
    public class ContactManager : IContactService
    {
        public IContactDal contactDal { get; set; }

        public ContactManager(IContactDal _contactDal)
        {
            contactDal = _contactDal;
        }
        public async Task<bool> Add(Contact entity)
        {
            return await contactDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            Contact entity = await contactDal.Get(x => x.Id == id);
            var result = await contactDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<Contact>> GetAll()
        {
            return await contactDal.GetAll();
        }

        public async Task<Contact> GetWithID(int id)
        {
            return await contactDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await contactDal.SaveChanges();
        }

        public async Task<bool> Update(Contact entity)
        {
            return await contactDal.Update(entity);
        }
    }
}
