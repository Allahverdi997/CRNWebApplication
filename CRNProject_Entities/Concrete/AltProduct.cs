using CRNProject_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Concrete
{
    public class AltProduct : BaseEntity2
    {
        public AltProduct()
        {
            this.AltProductFiles = new HashSet<AltProductFile>();
            this.AltProductImage = new HashSet<AltProductImage>();
        }
        #region Columns

        public string Title { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Content3 { get; set; }
        public string Content4 { get; set; }
        #endregion
        #region Key

        public int LangId { get; set; }
        public LangTable LangTable { get; set; }
        public int MainProductId { get; set; }
        public MainProduct MainProduct { get; set; }
        #endregion
        #region VirtualList

        public virtual ICollection<AltProductFile> AltProductFiles { get; set; }
        public virtual ICollection<AltProductImage> AltProductImage { get; set; }
        #endregion

    }
}
