using System.Diagnostics;
using InsidentReport.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsidentReport.Controllers
{
    public class HomeController : Controller
    {
        SupportLevel supportLevel = new SupportLevel();
        private readonly ILogger<HomeController> _logger;
        private int[] dailyProduction = { 120, 150, 80, 200, 170 };
       

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<SupportLevel> supportLevels = new List<SupportLevel>
            {
                new SupportLevel
                {
                    level = "Support Level 1",
                    person = new List<string> { "Mr. Manatsawin S.", "Mr. Sawadeekub S." }
                },
                new SupportLevel
                {
                    level = "Support Level 2",
                    person = new List<string> { "Programmer Group", "Information Group" }
                }
            };


            ViewBag.SupportLevels = supportLevels;
           

            return View();
        }

        public IActionResult Privacy()
        {
            string[] service = ["MS Office", "PC/Mobile Device/Notebook/Printer", "Install Software", "User and Permission", "Internal System", "External System"];
            ViewBag.Service = service;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
