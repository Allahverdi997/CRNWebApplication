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
    public class SocialMediaManager : ISocialMediaService
    {
        public ISocialMediaDal socialMediaDal { get; set; }

        public SocialMediaManager(ISocialMediaDal _socialMediaDal)
        {
            socialMediaDal = _socialMediaDal;
        }
        public async Task<bool> Add(SocialMedia entity)
        {
            return await socialMediaDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            SocialMedia entity = await socialMediaDal.Get(x => x.Id == id);
            var result = await socialMediaDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<SocialMedia>> GetAll()
        {
            return await socialMediaDal.GetAll();
        }

        public async Task<SocialMedia> GetWithID(int id)
        {
            return await socialMediaDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await socialMediaDal.SaveChanges();
        }

        public async Task<bool> Update(SocialMedia entity)
        {
            return await socialMediaDal.Update(entity);
        }
    }
}
