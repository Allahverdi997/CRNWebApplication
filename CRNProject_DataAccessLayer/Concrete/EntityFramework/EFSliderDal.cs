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
    public class EFSliderDal : EntityRepository<CNRContext, Slider>, ISliderDal
    {
        public EFSliderDal(CNRContext context) : base(context)
        {

        }
    }
}
