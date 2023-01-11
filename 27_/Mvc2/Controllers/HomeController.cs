using Microsoft.AspNetCore.Mvc;
using Mvc2.Models;
using System.Diagnostics;

namespace Mvc2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult EnterPage()
        {
            return RedirectToAction("index");
        }

        [Route("home/index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("home/contato")]
        public IActionResult Galeria()
        {
            return View("contato");
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