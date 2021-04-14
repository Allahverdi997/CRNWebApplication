using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class AltProductController : Controller
    {
        public IActionResult AddAltProduct()
        {
            return View();
        }
        public IActionResult UpdateAltProduct()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteAltProduct(int apId)
        {
            return View();
        }
    }
}
