using Agenda_Contatos.Models;

namespace Agenda_Contatos.Helper
{
    public interface ISession
    {
        void CreateUserSession(UsuarioModel user);
        void RemoveUserSession();
        UsuarioModel SearchUserSession();

    }
}
