using System.ComponentModel.DataAnnotations;

namespace BeckyShopping.ViewModels
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public int ProductId { get; set; }
        public string ProductCategory { get; set; }
        public string ProductSize { get; set; }
        public string ProductName { get; set; }
        public string ProductImageId { get; set; }
        public string SupplierId { get; set; }
    }
}