using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class SecurityPoliticyController : Controller
    {
        public IActionResult AddSecurityPoliticy()
        {
            return View();
        }
        public IActionResult UpdateSecurityPoliticy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteSecurityPoliticy(int spId)
        {
            return View();
        }
    }
}
