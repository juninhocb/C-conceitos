using Microsoft.AspNetCore.Mvc;

namespace Mvc2.Controllers
{
    public class GaleriaController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
