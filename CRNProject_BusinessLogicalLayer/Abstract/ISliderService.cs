using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_Entities.Concrete;

namespace CRNProject_BusinessLogicalLayer.Abstract
{
    public interface ISliderService
    {
        Task<List<Slider>> GetAll();
        Task<Slider> GetWithID(int id);
        Task<bool> Add(Slider entity);
        Task<bool> Update(Slider entity);
        Task<bool> Delete(int id);
        Task<bool> SaveChanges();
    }
}
