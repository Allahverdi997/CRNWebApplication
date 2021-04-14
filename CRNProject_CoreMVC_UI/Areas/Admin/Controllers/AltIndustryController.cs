using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class AltIndustryController : Controller
    {
        public IActionResult AddAltIndustry()
        {
            return View();
        }
        public IActionResult UpdateAltIndustry()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteAltIndustry(int aiId)
        {
            return View();
        }
    }
}
