using Microsoft.AspNetCore.Mvc;
using WebAppDay8.Models;
using WebAppDay8.Services;

namespace WebAppDay8.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        public IActionResult Index()
        {
            return View(_productService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            return View(_productService.GetById(id));
        }

        //[HttpGet]
        //public IActionResult Details(int id)
        //{
        //    foreach (var item in products)
        //    {
        //        if(item.Id==id)
        //        {
        //            ViewBag.Message = "Malkeet Singh";
        //            ViewBag.TotalProducts = 20;
        //            ViewBag.Pro = products;
        //            return View(item);
        //        }
        //    }

        //    return NotFound();
        //}
    }
}
