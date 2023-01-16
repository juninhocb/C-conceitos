using Agenda_Contatos.Enums;
using Agenda_Contatos.Helper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda_Contatos.Models
{
    public class UsuarioModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o email do usuário")]
        [EmailAddress(ErrorMessage = "O E-mail informado não corresponde a um endereço de E-mail válido")]
        public string Email { get; set; }
        public ProfileEnum Profile { get; set; }

        [Required(ErrorMessage = "Digite a senha do usuário")]
        public string Password { get; set; }
        public DateTime registerDate { get; set; }
        public DateTime? updateDate { get; set; } // interrogação diz que o campo pode ser nulo

        public virtual List<ContactModel> Contacts { get; set; }

        public bool ValidPassword(string password)
        {
            return Password.Equals(password.GerarHash());
        }

        public void SetPasswordHash()
        {
            Password = Password.GerarHash();
        }

        public string GenPassword()
        {
            string newPassword = Guid.NewGuid().ToString().Substring(0,8);
            Password = newPassword.GerarHash();
            return newPassword;
        }

        public void SetNewPassword(string newPassword)
        {
            Password = newPassword.GerarHash();
        }


    }
}
