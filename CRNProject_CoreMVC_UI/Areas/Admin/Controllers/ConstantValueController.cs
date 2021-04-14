using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class ConstantValueController : Controller
    {
        public IActionResult AddConstantValue()
        {
            return View();
        }
        public IActionResult UpdateConstantValue()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteConstantValue(int miId)
        {
            return View();
        }
    }
}
