using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNProject_CoreLayer.DataAccess.Abstract;
using CRNProject_Entities.Concrete;

namespace CRNProject_DataAccessLayer.Abstract
{
    public interface IContactMailDal : IEntityRepository<ContactMail>
    {
    }
}
