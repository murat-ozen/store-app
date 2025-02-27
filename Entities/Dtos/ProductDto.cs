using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; set; }
        
        [Required(ErrorMessage = "Product Name is required.")]
        public String? ProductName { get; set; } = String.Empty;
        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; set; }
        public String? Summary { get; init; } = String.Empty;
        public String? ImageUrl { get; set; }
        public int? CategoryId { get; set;}
    }
}