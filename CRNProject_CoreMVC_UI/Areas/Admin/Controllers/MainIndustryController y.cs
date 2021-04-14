using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class MainIndustryController : Controller
    {
        public IActionResult AddMainIndustry()
        {
            return View();
        }
        public IActionResult UpdateMainIndustry()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteMainIndustry(int miId)
        {
            return View();
        }
    }
}
