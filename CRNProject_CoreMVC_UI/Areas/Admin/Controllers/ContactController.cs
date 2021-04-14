using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult AddContact()
        {
            return View();
        }
        public IActionResult UpdateContact()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteContact(int cId)
        {
            return View();
        }
    }
}
