using Microsoft.Data.SqlClient;

using WebAppDay8.Models;

namespace WebAppDay8.DAO
{
    public class ProductDAO : IProductDAO
    {

        //private static List<Product> products = new List<Product>();

        //static ProductDAO()
        //{
        //    products.Add(new Product { Id = 101, Name = "IPhone", Price = 4500.0f, Description = "17 Pro Max" });
        //}


        

        //public ProductDAO(){        }
        private readonly string conn; 
        public ProductDAO(IConfiguration configuration)
        {
            conn = configuration.GetConnectionString("MyLocalDBConn");
        }

        public void AddProduct(Product product)
        {
            //products.Add(product);

            //SqlConnection con = new (conn);

            //SqlCommand cmd = new("INSERT INTO Products VALUES (@id,@name,@price,@description)", con);


            //cmd.Parameters.AddWithValue("@id", product.Id);
            //cmd.Parameters.AddWithValue("@name", product.Name);
            //cmd.Parameters.AddWithValue("@price", product.Price);
            //cmd.Parameters.AddWithValue("@description", product.Description);

            //con.Open();

            //cmd.ExecuteNonQuery();


        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int productId)
        {
            List<Product> products = new List<Product>();
            foreach (var item in products)
            {
                if (item.Id == productId)
                {
                    return item;
                }
            }

            return null;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            //SqlConnection con=new (conn);

            //SqlCommand cmd = new("SELECT * FROM Products", con);


            //con.Open();

            //SqlDataReader dr=cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    products.Add(new Product
            //    {
            //        Id = Convert.ToInt32(dr["Id"]),
            //        Name = dr["Name"].ToString(),
            //        Price = Convert.ToSingle(dr["Price"]),
            //        Description = dr["Description"].ToString()
            //    });
            //}

            //con.Close();
            //return products;

            return products;
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
