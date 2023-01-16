using Agenda_Contatos.Models;

namespace Agenda_Contatos.Repository
{
    public interface IUserRepository
    {

        UsuarioModel FindById(int id);
        List<UsuarioModel> FindAll();
        UsuarioModel Add(UsuarioModel user);
        UsuarioModel Update(UsuarioModel user);
        UsuarioModel Delete(int id);
        UsuarioModel Get(int id);
        bool DeleteUser(int id);

        UsuarioModel GetUserByLogin(string login);
        UsuarioModel FindUserByLoginAndEmail(string email, string login);

        UsuarioModel ChangePassword(ChangePasswordModel changePassword);

    }
}
