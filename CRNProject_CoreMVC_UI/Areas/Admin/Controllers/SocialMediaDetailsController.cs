using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class SocialMediaDetailsController : Controller
    {
        public IActionResult AddSocialMediaDetails()
        {
            return View();
        }
        public IActionResult UpdateSocialMediaDetails()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteSocialMediaDetails(int miId)
        {
            return View();
        }
    }
}
