using CRNProject_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Concrete
{
    public class SocialMedia : BaseEntity2
    {
        #region Columns
        public string Title { get; set; }
        public string URL { get; set; }
        public string Icon { get; set; }
        #endregion
    }
}
