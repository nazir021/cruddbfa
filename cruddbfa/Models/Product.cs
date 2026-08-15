using System.ComponentModel.DataAnnotations;

namespace cruddbfa.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        // Matches 'product_name' in SQL
        public string ProductName { get; set; } = string.Empty;

        public string? Category { get; set; }

        public decimal Price { get; set; }

        // Matches 'stock_quantity' in SQL
        public int StockQuantity { get; set; }

    }
}
