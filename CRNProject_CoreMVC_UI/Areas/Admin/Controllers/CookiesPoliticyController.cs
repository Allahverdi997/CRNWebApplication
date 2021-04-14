using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class CookiesPoliticyController : Controller
    {
        public IActionResult AddCookiesPoliticy()
        {
            return View();
        }
        public IActionResult UpdateCookiesPoliticy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteCookiesPoliticy(int cpId)
        {
            return View();
        }
    }
}
