using System.ComponentModel.DataAnnotations;

namespace Agenda_Contatos.Models
{
    public class ResetEmailModel
    {

        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o email")]
        public string Email { get; set; }

    }
}
