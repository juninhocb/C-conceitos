using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda_Contatos.Models
{
    public class ContactModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do contato")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Digite o E-mail do contato")]
        [EmailAddress(ErrorMessage = "O E-mail informado não corresponde a um endereço de E-mail válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o Telefone do contato")]
        [Phone(ErrorMessage = "O número de telefone informado é inválido")]
        public string Phone { get; set; }


    }
}
