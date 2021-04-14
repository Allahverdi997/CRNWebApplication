using CRNProject_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Models
{
    public class AboutAddViewModel
    {
        public About About { get; set; }
        public List<LangTable> LangTables { get; set; }
        public LangTable LangTable { get; set; }
    }
}
