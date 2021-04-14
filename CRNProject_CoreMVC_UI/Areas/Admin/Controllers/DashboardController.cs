﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRNProject_CoreMVC_UI.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        #region Anasayfa
        public IActionResult Index()
        {
            return View();
        }
        #endregion
        #region Slider
        public IActionResult Slider()
        {
            return View();
        }
        #endregion
        #region Hakkında
        public IActionResult About()
        {
            return View();
        }
        #endregion
        #region Menu
        public IActionResult Menu()
        {
            return View();
        }
        #endregion
        #region Kategori
        public IActionResult Category()
        {
            return View();
        }
        #endregion
        #region Urun
        public IActionResult MainProduct()
        {
            return View();
        }
        public IActionResult AltProduct()
        {
            return View();
        }
        public IActionResult AltProductImage()
        {
            return View();
        }
        public IActionResult AltProductFile()
        {
            return View();
        }
        #endregion
        #region Endüstri
        public IActionResult MainIndustry()
        {
            return View();
        }
        public IActionResult AltIndustry()
        {
            return View();
        }
        public IActionResult AltIndustryImage()
        {
            return View();
        }
        public IActionResult AltIndustryFile()
        {
            return View();
        }
        #endregion
        #region İletişim
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult ContactMailDetails()
        {
            return View();
        }
        public IActionResult SocialMediaDetails()
        {
            return View();
        }
        #endregion
        #region Sözleşme
        public IActionResult CookiesPoliticy()
        {
            return View();
        }
        public IActionResult CompanyPoliticy()
        {
            return View();
        }
        public IActionResult SecurityPoliticy()
        {
            return View();
        }
        #endregion
        #region SabitBilgiler
        public IActionResult ConstantValue()
        {
            return View();
        }
        #endregion
    }
}
