using Agenda_Contatos.Models;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace Agenda_Contatos.Helper
{
    public class Session : ISession
    {
        private readonly IHttpContextAccessor _httpContext;

        public Session(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public void CreateUserSession(UsuarioModel user)
        {
            string json = JsonConvert.SerializeObject(user);
            _httpContext.HttpContext.Session.SetString("userSession", json);
        }

        public void RemoveUserSession()
        {
            _httpContext.HttpContext.Session.Remove("userSession");
        }

        public UsuarioModel SearchUserSession()
        {
            string userSession = _httpContext.HttpContext.Session.GetString("userSession");
            if (string.IsNullOrEmpty(userSession)) return null;
            return JsonConvert.DeserializeObject<UsuarioModel>(userSession);

        }
    }
}
