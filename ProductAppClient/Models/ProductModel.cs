using System.ComponentModel.DataAnnotations;

namespace ProductAppClient.Models
{
   
        public enum Type { Physical, Virtual }
    public class ProductModel
    {

        public int Id { get; set; }

            [Required]
            public int CategoryId { get; set; }
            [Required]
            [StringLength(100)]
            public string Name { get; set; }
            public string Description { get; set; }
            [Required]
            public string SKU { get; set; }
            [Required]
            public string ImagePath { get; set; }
            [Required]
            public decimal SellingPrice { get; set; }
            [Required]
            public int AvailableQty { get; set; }
            public Type type { get; set; }
            public decimal Weight { get; set; }
            public int Length { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
           [Required]
            public decimal ShippingCost { get; set; }

            public CategoryModel categoryModel { get; set; }
        
    }
}
