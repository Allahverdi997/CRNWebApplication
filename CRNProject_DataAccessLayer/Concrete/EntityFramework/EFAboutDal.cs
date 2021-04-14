using CRNProject_CoreLayer.DataAccess.Concrete;
using CRNProject_DataAccessLayer.Abstract;
using CRNProject_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_DataAccessLayer.Concrete.EntityFramework
{
    public class EFAboutDal : EntityRepository<CNRContext, About>, IAboutDal
    {
        public EFAboutDal(CNRContext context) : base(context)
        {

        }
    }
}
