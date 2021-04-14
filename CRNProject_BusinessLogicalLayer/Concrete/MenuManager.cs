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
    public class MenuManager : IMenuService
    {
        public IMenuDal menuDal { get; set; }

        public MenuManager(IMenuDal _menuDal)
        {
            menuDal = _menuDal;
        }
        public async Task<bool> Add(Menu entity)
        {
            return await menuDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            Menu entity = await menuDal.Get(x => x.Id == id);
            var result = await menuDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<Menu>> GetAll()
        {
            return await menuDal.GetAll();
        }

        public async Task<Menu> GetWithID(int id)
        {
            return await menuDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await menuDal.SaveChanges();
        }

        public async Task<bool> Update(Menu entity)
        {
            return await menuDal.Update(entity);
        }
    }
}
