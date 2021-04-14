using CRNProject_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Concrete
{
    public class AltIndustryFile : BaseEntity2
    {
        #region Columns

        public string File { get; set; }
        public string FileAlt { get; set; }
        #endregion
        #region Key

        public int AltIndustryId { get; set; }
        public AltIndustry AltIndustry { get; set; }
        #endregion
    }
}
