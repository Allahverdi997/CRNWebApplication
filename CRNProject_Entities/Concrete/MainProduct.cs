using CRNProject_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Concrete
{
    public class MainProduct : BaseEntity1
    {
        public MainProduct()
        {
            this.AltIndustries = new HashSet<AltIndustry>();
            this.AltProducts = new HashSet<AltProduct>();
        }
        #region Columns

        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageVideoAlt { get; set; }
        public string ImageVideoURL { get; set; }
        public bool IsProductMainActive { get; set; }
        public bool IsApplicationMainActive { get; set; }
        #endregion
        #region Key

        public int LangId { get; set; }
        public LangTable LangTable { get; set; }

        public int CatId { get; set; }
        public Category Category { get; set; }
        #endregion
        #region VirtualList
        public virtual ICollection<AltIndustry> AltIndustries { get; set; }
        public virtual ICollection<AltProduct> AltProducts { get; set; }
        #endregion
    }
}
