using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class AltIndustryImageController : Controller
    {
        public IActionResult AddAltIndustryImage()
        {
            return View();
        }
        public IActionResult UpdateAltIndustryImage()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteAltIndustryImage(int apiId)
        {
            return View();
        }
    }
}
