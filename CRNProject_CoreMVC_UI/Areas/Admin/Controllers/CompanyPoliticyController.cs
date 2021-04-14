using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class CompanyPoliticyController : Controller
    {
        public IActionResult AddCompanyPoliticy()
        {
            return View();
        }
        public IActionResult UpdateCompanyPoliticy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteCompanyPoliticy(int miId)
        {
            return View();
        }
    }
}
