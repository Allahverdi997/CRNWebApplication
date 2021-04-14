using CRNProject_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Concrete
{
    public class Category : BaseEntity1
    {
        public Category()
        {
            this.MainIndustries = new HashSet<MainIndustry>();
            this.MainProducts = new HashSet<MainProduct>();
        }
        #region Columns

        public int ProitId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ShortContent { get; set; }
        public string ImageVideoAlt { get; set; }
        public string ImageVideoURL { get; set; }
        #endregion
        #region Key

        public int LangId { get; set; }
        public LangTable LangTable { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        #endregion
        #region VirtualList

        public virtual ICollection<MainIndustry> MainIndustries { get; set; }
        public virtual ICollection<MainProduct> MainProducts { get; set; }
        #endregion
    }
}
