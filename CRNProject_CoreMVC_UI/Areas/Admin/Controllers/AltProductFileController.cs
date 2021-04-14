using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class AltProductFileController : Controller
    {
        public IActionResult AddAltProductFile()
        {
            return View();
        }
        public IActionResult UpdateAltProductFile()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteAltProductFile(int apfId)
        {
            return View();
        }
    }
}
