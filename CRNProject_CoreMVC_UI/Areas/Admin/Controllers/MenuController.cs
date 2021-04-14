using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult AddMenu()
        {
            return View();
        }
        public IActionResult UpdateMenu()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteMenu(int mId)
        {
            return View();
        }
    }
}
