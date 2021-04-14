using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class ContactMailDetails : Controller
    {
        public IActionResult AddContactMailDetails()
        {
            return View();
        }
        public IActionResult UpdateContactMailDetails()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteContactMailDetails(int cmdId)
        {
            return View();
        }
    }
}
