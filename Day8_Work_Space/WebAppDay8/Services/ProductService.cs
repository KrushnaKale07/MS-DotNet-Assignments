using WebAppDay8.DAO;
using WebAppDay8.Models;

namespace WebAppDay8.Services
{
    public class ProductService : IProductService
    {

        private readonly ProductDAO _productDAO;

        public ProductService()
        {
            _productDAO = new ProductDAO();
        }

        public void Add(Product product)
        {
            // products.Add(product);

            _productDAO.AddProduct(product);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _productDAO.GetProducts();
        }

        public Product GetById(int id)
        {
            return _productDAO.GetProductById(id);
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
