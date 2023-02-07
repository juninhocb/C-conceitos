using Logistica.mercadorias.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logistica.mercadorias.Models
{
    public class ClientModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedOn{ get; set; }

        [ForeignKey(nameof(Id))]
        public int? ProductId { get; set; }
        public virtual List<ProductModel>? Products { get; set; }
        public RoleEnum Role { get; set; }  
    }
}
