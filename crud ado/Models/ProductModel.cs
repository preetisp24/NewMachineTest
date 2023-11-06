namespace crud_ado.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int unitPrice { get; set; }

        public int categoryId { get; set; }
    }
}
