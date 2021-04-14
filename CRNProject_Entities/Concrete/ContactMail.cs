using CRNProject_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Concrete
{
    public class ContactMail : BaseEntity2
    {
        #region Columns

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        #endregion
    }
}
