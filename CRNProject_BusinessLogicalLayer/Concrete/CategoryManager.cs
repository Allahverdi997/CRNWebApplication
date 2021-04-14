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
    public class CategoryManager : ICategoryService
    {
        public ICategoryDal categoryDal { get; set; }

        public CategoryManager(ICategoryDal _categoryDal)
        {
            categoryDal = _categoryDal;
        }
        public async Task<bool> Add(Category entity)
        {
            return await categoryDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            Category entity = await categoryDal.Get(x => x.Id == id);
            var result = await categoryDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<Category>> GetAll()
        {
            return await categoryDal.GetAll();
        }

        public async Task<Category> GetWithID(int id)
        {
            return await categoryDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await categoryDal.SaveChanges();
        }

        public async Task<bool> Update(Category entity)
        {
            return await categoryDal.Update(entity);
        }
    }
}
