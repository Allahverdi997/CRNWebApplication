using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult AddAbout()
        {
            return View();
        }
        public IActionResult UpdateAbout()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteAbout(int aId)
        {
            return View();
        }
    }
}
