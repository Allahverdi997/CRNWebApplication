using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class SliderController : Controller
    {
        public IActionResult AddSlider()
        {
            return View();
        }
        public IActionResult UpdateSlider()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteSlider(int sId)
        {
            return View();
        }
    }
}
