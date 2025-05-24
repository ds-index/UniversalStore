using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversalStore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Required Product Name")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Product Name need between 4 to 50 chars!")]

        public string? Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Required Product Description")]
        [StringLength(150, MinimumLength = 6, ErrorMessage = "Product Name need between 6 to 150 chars!")]

        public string? Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "Required Product Price")]
        public decimal? Price { get; set; } = decimal.Zero;
    }
}
