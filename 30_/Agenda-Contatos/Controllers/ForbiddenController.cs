using Agenda_Contatos.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Agenda_Contatos.Controllers
{
    [PageForLoggedUser]
    public class ForbiddenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
