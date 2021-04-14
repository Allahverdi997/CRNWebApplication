using CRNProject_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Models
{
    public class AboutIndexViewModel
    {
        public List<About> Abouts { get; set; }
        public List<LangTable> LangTables { get; set; }
    }
}
