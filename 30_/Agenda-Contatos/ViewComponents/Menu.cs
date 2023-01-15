using Agenda_Contatos.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Agenda_Contatos.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string userSession = HttpContext.Session.GetString("userSession");

            if(string.IsNullOrEmpty(userSession))
            {
                return null;
            }

            UsuarioModel user = JsonConvert.DeserializeObject<UsuarioModel>(userSession);

            return View(user);
        }
    }
}
