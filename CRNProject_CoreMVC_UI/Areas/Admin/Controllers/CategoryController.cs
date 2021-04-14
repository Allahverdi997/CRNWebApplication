using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult AddCategory()
        {
            return View();
        }
        public IActionResult UpdateCategory()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteCategory(int cId)
        {
            return View();
        }
    }
}
