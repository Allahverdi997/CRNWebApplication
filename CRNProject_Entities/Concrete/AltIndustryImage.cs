using CRNProject_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Concrete
{
    public class AltIndustryImage : BaseEntity2
    {
        #region Columns

        public string AltIndustrImage { get; set; }
        public string ImageVideoAlt { get; set; }
        public string ImageVideoURL { get; set; }
        #endregion
    }
}
