using CRNProject_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Concrete
{
    public class LangTable : BaseEntity2
    {
        public LangTable()
        {
            this.Sliders = new HashSet<Slider>();
            this.Abouts = new HashSet<About>();
            this.AltIndustries = new HashSet<AltIndustry>();
            this.AltProducts = new HashSet<AltProduct>();
            this.Categories = new HashSet<Category>();
            this.MainIndustries = new HashSet<MainIndustry>();
            this.MainProducts = new HashSet<MainProduct>();
            this.Menus = new HashSet<Menu>();
        }
        #region Columns
        public string LangName { get; set; }
        #endregion

        #region Virtual List
        public virtual ICollection<Slider> Sliders { get; set; }
        public virtual ICollection<About> Abouts { get; set; }
        public virtual ICollection<AltIndustry> AltIndustries { get; set; }
        public virtual ICollection<AltProduct> AltProducts { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<MainIndustry> MainIndustries { get; set; }
        public virtual ICollection<MainProduct> MainProducts { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
        #endregion
    }
}
