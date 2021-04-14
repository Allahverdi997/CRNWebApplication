using CRNProject_BusinessLogicalLayer.UnitOfWork;
using CRNProject_CoreMVC_UI.Models;
using CRNProject_Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public HomeController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            LangTable lang = await unitOfWork.langTableService.GetWithID(1);

            lang.LangName = "Ru";
            lang.LastDateTime = DateTime.Now;
            var result = await unitOfWork.langTableService.GetAll();
            var result2 = await unitOfWork.langTableService.SaveChanges();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
