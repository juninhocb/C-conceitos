using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Agenda_Contatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public string Password { get; set; }    
    }
}
