using Microsoft.AspNetCore.Mvc;
using MVC_Injection.Models;
using MVC_Injection.Repository;

namespace MVC_Injection.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        //CRUD

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
       

        public IActionResult Index()
        {
            return View(_productRepository.GetProducts());
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            var updated = _productRepository.GetProducts().Where(x => x.ID == id).FirstOrDefault();
            return View(updated);
        }

        //Update Post
        [HttpPost]
        public IActionResult Update(Product model) 
        {
            var updated = _productRepository.GetProducts().Where(x => x.ID == model.ID).FirstOrDefault();
            updated.ProductName=model.ProductName;
            updated.UnitPrice = model.UnitPrice;

            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            var deleted = _productRepository.GetProducts().Where(x => x.ID == id).FirstOrDefault();

            _productRepository.GetProducts().Remove(deleted);

            return RedirectToAction("Index");
        }
    }
}
