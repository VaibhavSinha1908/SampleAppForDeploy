using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SampleApplicationForOctopusDeployment.Models;
using System.Diagnostics;

namespace SampleApplicationForOctopusDeployment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration config;

        public HomeController(IConfiguration config)
        {
            this.config = config;
        }
        public IActionResult Index()
        {
            ViewBag.Environment = config.GetValue<string>("AppConfiguration:Environment");
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
