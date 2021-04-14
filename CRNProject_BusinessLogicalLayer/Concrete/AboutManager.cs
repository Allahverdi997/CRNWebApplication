using CRNProject_BusinessLogicalLayer.Abstract;
using CRNProject_DataAccessLayer.Abstract;
using CRNProject_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_BusinessLogicalLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        public IAboutDal aboutDal { get; set; }

        public AboutManager(IAboutDal _aboutDal)
        {
            aboutDal = _aboutDal;
        }
        public async Task<bool> Add(About entity)
        {
            return await aboutDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            About about = await aboutDal.Get(x => x.Id == id);
            var result = await aboutDal.Delete(about);
            return result == true ? true : false;
        }

        public async Task<List<About>> GetAll()
        {
            return await aboutDal.GetAll();
        }

        public async Task<About> GetWithID(int id)
        {
            return await aboutDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await aboutDal.SaveChanges();
        }

        public async Task<bool> Update(About entity)
        {
            return await aboutDal.Update(entity);
        }
    }
}
