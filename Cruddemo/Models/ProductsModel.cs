using System.ComponentModel.DataAnnotations;

namespace Cruddemo.Models
{
    public class ProductsModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public int Price { get; set; }

    }
}
