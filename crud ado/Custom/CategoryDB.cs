using crud_ado.Models;
using Microsoft.Data.SqlClient;

namespace crud_ado.Custom
{
    public class CategoryDB
    {
        IConfiguration _config;
        string Connectionstring = null;

        public CategoryDB(IConfiguration config)
        {
            _config = config;
            Connectionstring = _config["ConnectionStrings:CrudB20"];
        }

        public List<CategoryModel> cat()
        {
           List<CategoryModel> categories= new List<CategoryModel>();

            SqlConnection con = new SqlConnection(Connectionstring);
            string query = "select * from category ";
            SqlCommand cmd = new SqlCommand(query,con);

            con.Open();
            SqlDataReader reader=cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    CategoryModel c = new CategoryModel();
                    c.categoryId = (int) reader["categoryId"];
                    c.Name= (string) reader["Name"];
                    c.Description= (string) reader["Description"];

                    categories.Add(c);
                }

                
            }
            con.Close();
            return categories;
        }
    }
}
