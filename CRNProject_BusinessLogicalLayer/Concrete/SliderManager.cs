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
    public class SliderManager : ISliderService
    {
        public ISliderDal sliderDal { get; set; }

        public SliderManager(ISliderDal _sliderDal)
        {
            sliderDal = _sliderDal;
        }
        public async Task<bool> Add(Slider entity)
        {
            return await sliderDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            Slider entity = await sliderDal.Get(x => x.Id == id);
            var result = await sliderDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<Slider>> GetAll()
        {
            return await sliderDal.GetAll();
        }

        public async Task<Slider> GetWithID(int id)
        {
            return await sliderDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await sliderDal.SaveChanges();
        }

        public async Task<bool> Update(Slider entity)
        {
            return await sliderDal.Update(entity);
        }
    }
}
