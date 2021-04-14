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
    public class CookiesPoliticsManager : ICookiesPoliticsService
    {
        public ICookiesPoliticsDal cookiesPoliticsDal { get; set; }

        public CookiesPoliticsManager(ICookiesPoliticsDal _cookiesPoliticsDal)
        {
            cookiesPoliticsDal = _cookiesPoliticsDal;
        }
        public async Task<bool> Add(CookiesPolitics entity)
        {
            return await cookiesPoliticsDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            CookiesPolitics entity = await cookiesPoliticsDal.Get(x => x.Id == id);
            var result = await cookiesPoliticsDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<CookiesPolitics>> GetAll()
        {
            return await cookiesPoliticsDal.GetAll();
        }

        public async Task<CookiesPolitics> GetWithID(int id)
        {
            return await cookiesPoliticsDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await cookiesPoliticsDal.SaveChanges();
        }

        public async Task<bool> Update(CookiesPolitics entity)
        {
            return await cookiesPoliticsDal.Update(entity);
        }
    }
}
