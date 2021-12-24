using CMD.Entities;
using CMD.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CMD.WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CMDWebApiContext ctx;

        public HomeController(ILogger<HomeController> logger, CMDWebApiContext ctx)
        {
            _logger = logger;
            this.ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            var docInfo = ctx.Doctors.FirstOrDefault();
            return View(docInfo);
        }
        public IActionResult Patients()
        {
            return View();
        }
        public IActionResult Settings()
        {
            return View();
        }
        public IActionResult Viewdetails()
        {
            var docs = ctx.Doctors.ToList();
            ViewBag.Doctors = from d in docs
                               select new SelectListItem { Text = d.Name, Value = d.DoctorId.ToString() };
            return View();
        }
        public IActionResult Editsettings()
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
