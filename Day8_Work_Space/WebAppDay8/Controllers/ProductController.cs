using Microsoft.AspNetCore.Mvc;
using WebAppDay8.Models;

namespace WebAppDay8.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>();
        static ProductController() => products.Add(new Product { Id = 101, Name = "Iphone", Price = 10000.02f, Description = "Buy now" });
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult? Create(Product product)
        {
            if (ModelState.IsValid) {
                products.Add(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
