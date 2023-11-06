using crudado1.Models;
using System.Data.SqlClient;

namespace crudado1.modelDb
{
    public class CategoryDb
    {
        IConfiguration _config;
        string Connectionstring = null;

        public CategoryDb(IConfiguration config)
        {
            _config = config;
            Connectionstring = _config["ConnectionStrings:CrudB20"];
        }

        public List<CategoryModel> cat()
        {
            List<CategoryModel> categories = new List<CategoryModel>();

            SqlConnection con = new SqlConnection(Connectionstring);
            string query = "select * from category ";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CategoryModel c = new CategoryModel();
                    c.categoryId = (int)reader["categoryId"];
                    c.Name = (string)reader["Name"];
                    c.Description = (string)reader["Description"];

                    categories.Add(c);
                }


            }
            con.Close();
            return categories;
        }

        public List<ProductModel> prod(int? id)
        {
            List<ProductModel> products = new List<ProductModel>();

            SqlConnection con = new SqlConnection(Connectionstring);
            //string query = $"select * from Product where categoryId = {id}";
            string query = $"select * from Product where categoryId = {id}";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ProductModel p = new ProductModel();
                    p.id = (int) reader["ProductId"];
                    p.name = (string) reader["Name"];
                    p.Unitprice = (int) reader["UnitPrice"];
                    p.CategoryId = (int) reader["categoryId"];

                    products.Add(p);
                }


            }
            con.Close();
            return products;
        }
    }
}
