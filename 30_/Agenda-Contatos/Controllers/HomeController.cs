using Agenda_Contatos.Filters;
using Agenda_Contatos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Agenda_Contatos.Controllers
{
    [PageForLoggedUser]
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Name= "Carlos Jr";
            home.Email = "juninhocb@hotmail.com";
            return View(home);
        }

        public IActionResult Privacy()
        {
            ViewData["ViewTest"] = "testando view data";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}