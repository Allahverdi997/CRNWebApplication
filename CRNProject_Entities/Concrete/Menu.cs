using CRNProject_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Concrete
{
    public class Menu : BaseEntity1
    {
        public Menu()
        {
            this.Categories = new HashSet<Category>();
        }
        #region Columns

        public string Title { get; set; }
        public string Note { get; set; }
        public string PageURL { get; set; }
        #endregion
        #region Key

        public int LangId { get; set; }
        public LangTable LangTable { get; set; }
        #endregion
        #region VirtualList

        public virtual ICollection<Category> Categories { get; set; }
        #endregion
    }
}
