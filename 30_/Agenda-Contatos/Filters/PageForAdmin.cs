using Agenda_Contatos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace Agenda_Contatos.Filters
{
    public class PageForAdmin : ActionFilterAttribute
    {
        
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string userSession = context.HttpContext.Session.GetString("userSession");

            if (string.IsNullOrEmpty(userSession))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary { {"controller", "Login"}, {"action", "Index"}});

            } else
            {
                UsuarioModel user = JsonConvert.DeserializeObject<UsuarioModel>(userSession);

                if (user == null)
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Login" }, { "action", "Index" } });
                }

                if (user.Profile != Enums.ProfileEnum.Administrator)
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Forbidden" }, { "action", "Index" } });
                }
            }

            base.OnActionExecuting(context);
        }

    }
}
