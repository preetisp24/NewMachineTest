using System.ComponentModel.DataAnnotations;

namespace ProductManageAPI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Products> product { get; set;}
    }
}
