using CRNProject_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Concrete
{
    public class AltProductImage : BaseEntity2
    {
        #region Columns

        public string ImageVideoAlt { get; set; }
        public string ImageVideoURL { get; set; }
        #endregion
        #region Key

        public int AltProductId { get; set; }
        public AltProduct AltProduct { get; set; }
        #endregion
    }
}
