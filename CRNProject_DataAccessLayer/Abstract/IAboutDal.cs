using CRNProject_CoreLayer.DataAccess.Abstract;
using CRNProject_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_DataAccessLayer.Abstract
{
    public interface IAboutDal : IEntityRepository<About>
    {
    }
}
