using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class AltIndustryFileController : Controller
    {
        public IActionResult AddAltIndustryFile()
        {
            return View();
        }
        public IActionResult UpdateAltIndustryFile()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteAltIndustryFile(int aifId)
        {
            return View();
        }
    }
}
