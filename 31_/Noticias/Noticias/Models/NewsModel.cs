using Noticias.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Noticias.Models
{
    public class NewsModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }

        public CategoryEnums Category { get; set; }
        public string Description { get; set; }
    }
}
