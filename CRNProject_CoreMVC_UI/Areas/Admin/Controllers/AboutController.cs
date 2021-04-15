using CRNProject_BusinessLogicalLayer.UnitOfWork;
using CRNProject_CoreMVC_UI.Models;
using CRNProject_Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
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
        private IWebHostEnvironment environment;
        public AboutController(IUnitOfWork _unitOfWork, IWebHostEnvironment _environment)
        {
            unitOfWork = _unitOfWork;
            environment = _environment;
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
        public async Task<IActionResult> AddAbout(About about, IFormFile formFile)
        {
            if (formFile != null)
            {
                string folder = Path.Combine(environment.WebRootPath, "Images", "AboutPictures");
                string extension = Path.GetExtension(formFile.FileName);
                string imageName = Guid.NewGuid() + extension;
                string path = Path.Combine(folder, imageName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }

                about.ImageVideoURL = imageName;
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
            else
            {
                ModelState.AddModelError("ImageVideoURL", "Xahis olunur resim secesiniz.");
                return View();
            }


        }

        [HttpGet]
        public async Task<IActionResult> UpdateAbout(int id)
        {
            About about = await unitOfWork.aboutService.GetWithID(id);
            LangTable lang = await unitOfWork.langTableService.GetWithID(about.LangId);

            var model = new AboutAddViewModel()
            {
                About = about,
                LangTables = await unitOfWork.langTableService.GetAll(),
                LangTable = lang
            };
            ViewBag.Language = lang.Id;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(About about, IFormFile formFile)
        {
            About _about = await unitOfWork.aboutService.GetWithID(about.Id);

            var model = new AboutAddViewModel()
            {
                About = about,
                LangTables = await unitOfWork.langTableService.GetAll()
            };
            if (formFile != null)
            {
                string folder = Path.Combine(environment.WebRootPath, "Images", "AboutPictures");
                string extension = Path.GetExtension(formFile.FileName);
                string imageName = Guid.NewGuid() + extension;
                string path = Path.Combine(folder, imageName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }

                _about.ImageVideoURL = imageName;
            }
            else
            {
                _about.ImageVideoURL = about.ImageVideoURL;
            }

            _about.Content = about.Content;
            _about.ImageVideoAlt = about.ImageVideoAlt;
            _about.IsActive = about.IsActive;
            _about.LangId = about.LangId;
            _about.LastDateTime = DateTime.Now;
            _about.Title = about.Title;

            bool result = await unitOfWork.aboutService.Update(_about);

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
