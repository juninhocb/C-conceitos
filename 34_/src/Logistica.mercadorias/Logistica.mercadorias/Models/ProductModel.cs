using System.ComponentModel.DataAnnotations.Schema;

namespace Logistica.mercadorias.Models
{
    public class ProductModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(Id))]
        public int CategoryId { get; set; }
        public virtual CategoryModel? Category { get; set; }
    }
}
