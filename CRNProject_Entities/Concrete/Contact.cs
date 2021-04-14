using CRNProject_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Concrete
{
    public class Contact : BaseEntity1
    {
        #region Columns

        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        #endregion
    }
}
