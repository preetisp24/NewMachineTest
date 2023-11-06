using System.ComponentModel.DataAnnotations;

namespace ProductAppClient.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // public ICollection<ProductModel> productModel { get; set; }
    }
}
