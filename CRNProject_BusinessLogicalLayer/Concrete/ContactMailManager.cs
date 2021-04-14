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
    public class ContactMailManager : IContactMailService
    {
        public IContactMailDal contactMailDal { get; set; }

        public ContactMailManager(IContactMailDal _contactMailDal)
        {
            contactMailDal = _contactMailDal;
        }
        public async Task<bool> Add(ContactMail entity)
        {
            return await contactMailDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            ContactMail entity = await contactMailDal.Get(x => x.Id == id);
            var result = await contactMailDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<ContactMail>> GetAll()
        {
            return await contactMailDal.GetAll();
        }

        public async Task<ContactMail> GetWithID(int id)
        {
            return await contactMailDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await contactMailDal.SaveChanges();
        }

        public async Task<bool> Update(ContactMail entity)
        {
            return await contactMailDal.Update(entity);
        }
    }
}
