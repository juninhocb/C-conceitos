using Agenda_Contatos.Data;
using Agenda_Contatos.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda_Contatos.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _userRepository;
        public UserRepository(DataContext dataContext)
        {
            this._userRepository = dataContext;
        }
        public UsuarioModel Add(UsuarioModel user)
        {
            user.registerDate= DateTime.Now;
            user.SetPasswordHash();
            _userRepository.Add(user);  //insere 
            _userRepository.SaveChanges(); //commit
            return user;
        }

        public UsuarioModel ChangePassword(ChangePasswordModel changePassword)
        {
            UsuarioModel userDB = FindById(changePassword.Id);
            if (userDB == null) throw new Exception("Usuário não encontrado");
            if (!userDB.ValidPassword(changePassword.CurrentPassword)) throw new Exception("Senha atual não confere");
            if (userDB.ValidPassword(changePassword.NewPassoword)) throw new Exception("Nova senha deve ser diferente da senha atual");
            userDB.SetNewPassword(changePassword.NewPassoword);
            userDB.updateDate= DateTime.Now;
            _userRepository.Users.Update(userDB);
            _userRepository.SaveChanges();
            return userDB;
        }

        public UsuarioModel Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            UsuarioModel userDB = FindById(id);

            if (userDB == null) throw new System.Exception("Ocorreu um problema ao deletar o usuário!");

            _userRepository.Users.Remove(userDB);
            _userRepository.SaveChanges();

            return true;

        }

        public List<UsuarioModel> FindAll()
        {
            return _userRepository.Users
                .Include(u => u.Contacts)
                .ToList();
        }

        public UsuarioModel FindById(int id)
        {
            return _userRepository.Users.FirstOrDefault(x => x.id == id);
        }

        public UsuarioModel FindUserByLoginAndEmail(string email, string login)
        {
            return _userRepository.Users.FirstOrDefault(x => x.Email.ToUpper() == email && x.Login == login);
        }

        public UsuarioModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel GetUserByLogin(string login)
        {

            return _userRepository.Users.FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper());
        }

        public UsuarioModel Update(UsuarioModel user)
        {
            UsuarioModel userDB= FindById(user.id);

            if (userDB == null) throw new System.Exception("Ocorreu um problema ao atualizar os dados!");

            userDB.Name = user.Name;
            userDB.Email = user.Email;
            userDB.Login= user.Login;
            userDB.Profile= user.Profile;
            userDB.updateDate = DateTime.Now;

            _userRepository.Users.Update(userDB);
            _userRepository.SaveChanges();
            return userDB;
        }
    }
}
