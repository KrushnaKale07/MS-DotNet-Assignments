using WebAppDay8.Models;

namespace WebAppDay8.DAO
{
    public interface IProductDAO
    {
        public List<Product> GetProducts();
        public Product GetProductById(int productId);
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int productId);
    }
}
