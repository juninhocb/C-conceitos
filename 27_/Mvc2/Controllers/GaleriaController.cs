using Microsoft.AspNetCore.Mvc;

namespace Mvc2.Controllers
{
    public class GaleriaController : Controller
    {


        [Route("galeria/index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
