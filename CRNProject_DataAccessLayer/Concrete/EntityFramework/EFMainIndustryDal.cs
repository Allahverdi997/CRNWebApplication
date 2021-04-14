using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_CoreLayer.DataAccess.Concrete;
using CRNProject_DataAccessLayer.Abstract;
using CRNProject_Entities.Concrete;

namespace CRNProject_DataAccessLayer.Concrete.EntityFramework
{
    public class EFMainIndustryDal : EntityRepository<CNRContext, MainIndustry>, IMainIndustryDal
    {
        public EFMainIndustryDal(CNRContext context) : base(context)
        {

        }
    }
}
