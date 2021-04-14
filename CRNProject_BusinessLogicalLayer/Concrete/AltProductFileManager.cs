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
    public class AltProductFileManager : IAltProductFileService
    {
        public IAltProductFileDal altProductFileDal { get; set; }

        public AltProductFileManager(IAltProductFileDal _altProductFileDal)
        {
            altProductFileDal = _altProductFileDal;
        }
        public async Task<bool> Add(AltProductFile entity)
        {
            return await altProductFileDal.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            AltProductFile entity = await altProductFileDal.Get(x => x.Id == id);
            var result = await altProductFileDal.Delete(entity);
            return result == true ? true : false;
        }

        public async Task<List<AltProductFile>> GetAll()
        {
            return await altProductFileDal.GetAll();
        }

        public async Task<AltProductFile> GetWithID(int id)
        {
            return await altProductFileDal.Get(x => x.Id == id);
        }

        public async Task<bool> SaveChanges()
        {
            return await altProductFileDal.SaveChanges();
        }

        public async Task<bool> Update(AltProductFile entity)
        {
            return await altProductFileDal.Update(entity);
        }
    }
}
