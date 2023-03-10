using Microsoft.AspNetCore.Mvc;
using OWASP.Misconfiguration.Web.Before.Models;
using System.Diagnostics;

namespace OWASP.Misconfiguration.Web.Before.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SimpleForm()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SimpleForm(string submit)
        {
            ViewBag.Data = submit;
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