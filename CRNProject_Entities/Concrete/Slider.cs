using CRNProject_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Concrete
{
    public class Slider : BaseEntity2
    {
        #region Columns

        public string ImageVideoAlt { get; set; }
        public string ImageVideoURL { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string PageURL { get; set; }
        #endregion
        #region Key


        public int LangId { get; set; }
        public LangTable LangTable { get; set; }
        #endregion
    }
}
