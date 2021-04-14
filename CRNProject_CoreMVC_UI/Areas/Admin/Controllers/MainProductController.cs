using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class MainProductController : Controller
    {
        public IActionResult AddMainProduct()
        {
            return View();
        }
        public IActionResult UpdateMainProduct()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteMainProduct(int mpId)
        {
            return View();
        }
    }
}
