using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManageAPI.Models
{
    public class Products
    {

        public int Id { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public string SKU { get; set; }
        public string ImagePath { get; set; }

        public decimal SellingPrice { get; set; }
        public int AvailableQty { get; set; }

        public enum Type { Physical, Virtual }
        public Type type { get; set; }
        
    
        public decimal Weight { get; set; }
        public int Length { get; set; }

        public int Width { get; set; }
        public int Height { get; set; } 

        public decimal ShippingCost { get; set; }

        public Category category { get; set; }
    }
}
