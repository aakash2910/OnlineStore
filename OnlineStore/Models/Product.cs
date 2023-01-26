using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Product Name is required")]
        [MaxLength(50, ErrorMessage = "Maximum 50 Characters allowed")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product description is required")]
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public long Price { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public int QuantityInStock { get; set; }
    }
}
