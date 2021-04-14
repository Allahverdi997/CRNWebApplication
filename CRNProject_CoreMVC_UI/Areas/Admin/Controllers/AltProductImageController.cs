using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class AltProductImageController : Controller
    {
        public IActionResult AddAltProductImage()
        {
            return View();
        }
        public IActionResult UpdateAltProductImage()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteAltProductImage(int apiId)
        {
            return View();
        }
    }
}
