using CRNProject_BusinessLogicalLayer.UnitOfWork;
using CRNProject_CoreMVC_UI.Models;
using CRNProject_Entities.Concrete;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public AboutController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> AddAbout()
        {
            var model = new AboutAddViewModel()
            {
                About = new About(),
                LangTables = await unitOfWork.langTableService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddAbout(About about)
        {
            bool result = await unitOfWork.aboutService.Add(about);

            if (result)
            {
                return RedirectToAction("AboutIndex", "Dashboard");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult UpdateAbout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(About about)
        {
            var model = new AboutAddViewModel()
            {
                About = about,
                LangTables = await unitOfWork.langTableService.GetAll()
            };
            bool result = await unitOfWork.aboutService.Add(about);

            if (result)
            {
                return RedirectToAction("AboutIndex", "Dashboard");
            }
            else
            {
                return View();
            }

        }
        [HttpGet]
        public async Task<IActionResult> DeleteAbout(int id)
        {
            bool result = await unitOfWork.aboutService.Delete(id);


            return RedirectToAction("AboutIndex", "Dashboard");
        }
    }
}
