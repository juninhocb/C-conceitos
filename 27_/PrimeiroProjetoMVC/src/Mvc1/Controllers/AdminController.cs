using Microsoft.AspNetCore.Mvc;

namespace Mvc1.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Indicadores()
        {
            return View();
        }
    }
}
