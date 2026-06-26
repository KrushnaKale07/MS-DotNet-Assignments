using WebAppDay8.Models;

namespace WebAppDay8.Services
{
    public interface IProductService
    {
        public List<Product> GetAll();
        public Product GetById(int id);
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(int id);

    }
}
