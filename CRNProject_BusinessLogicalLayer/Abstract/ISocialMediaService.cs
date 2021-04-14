using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface ISocialMediaService
    {
        Task<List<SocialMedia>> GetAll();
        Task<SocialMedia> GetWithID(int id);
        Task<bool> Add(SocialMedia entity);
        Task<bool> Update(SocialMedia entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
