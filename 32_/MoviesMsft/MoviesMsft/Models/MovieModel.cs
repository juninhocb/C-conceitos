using System.ComponentModel.DataAnnotations;

namespace MoviesMsft.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string? title { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime ReleaseDate{ get; set; }
        
        public string? Genre { get; set; }

        public decimal Price { get; set; }
    }
}
