using System.ComponentModel.DataAnnotations;

namespace Agenda_Contatos.Models
{
    public class ChangePasswordModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite a senha atual do usuário")]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "Digite a nova senha do usuário")]
        public string NewPassoword {  get; set; }

        [Required(ErrorMessage = "Confirme a nova enha do usuário")]
        [Compare("NewPassoword", ErrorMessage = "Senha não confere com a nova senha")]
        public string ConfirmPassword { get; set;}
        
    }
}
