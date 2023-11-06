using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CruddemoMVC.Models
{
    public class ProductModel
    {

        [Required]
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [StringLength(50)]
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [Range(0, int.MaxValue)]
        [JsonPropertyName("price")]
        public int Price { get; set; }
    }
}
