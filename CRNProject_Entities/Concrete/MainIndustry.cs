using CRNProject_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Concrete
{
    public class MainIndustry : BaseEntity1
    {
        #region Columns
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageVideoAlt { get; set; }
        public string ImageVideoURL { get; set; }
        #endregion
        #region Key

        public int LangId { get; set; }
        public LangTable LangTable { get; set; }
        public int CatId { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
