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
    public class CompanyPoliticyManager : ICompanyPoliticyService
    {
        public ICompanyPoliticyDal companyPoliticyDal { get; set; }

        public CompanyPoliticyManager(ICompanyPoliticyDal _companyPoliticyDal)
        {
            companyPoliticyDal = _companyPoliticyDal;
        }
        public async Task<bool> Add(CompanyPoliticy entity)
        {
            return await companyPoliticyDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            CompanyPoliticy entity = await companyPoliticyDal.Get(x => x.Id == id);
            var result = await companyPoliticyDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<CompanyPoliticy>> GetAll()
        {
            return await companyPoliticyDal.GetAll();
        }

        public async Task<CompanyPoliticy> GetWithID(int id)
        {
            return await companyPoliticyDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await companyPoliticyDal.SaveChanges();
        }

        public async Task<bool> Update(CompanyPoliticy entity)
        {
            return await companyPoliticyDal.Update(entity);
        }
    }
}
