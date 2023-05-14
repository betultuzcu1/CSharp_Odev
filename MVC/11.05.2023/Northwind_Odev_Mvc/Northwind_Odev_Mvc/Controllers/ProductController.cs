using Microsoft.AspNetCore.Mvc;
using Northwind_Odev_Mvc.Models;

namespace Northwind_Odev_Mvc.Controllers
{
    public class ProductController : Controller
    {
        NorthwndContext db = new NorthwndContext();

        // List
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        //Create
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();

        }
        [HttpPost]

        public IActionResult CreateProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return View();
        }

        //Delete
        public IActionResult DeleteProduct(int id)
        {
            var deleted = db.Products.Find(id);
            if (deleted != null)
            {
                db.Products.Remove(deleted);
                db.SaveChanges();
            }
            else
            {
                TempData["Error"] = "Böyle bir kategori bulunamadı!";
                return RedirectToAction("Index", "Product");
            }
            return RedirectToAction("Index", "Product");


        }
        //Update
        public IActionResult UpdateProduct(Product product)
        {
            var updated = db.Products.Find(product.ProductId);
            if (updated != null)
            {

                updated.ProductName = product.ProductName;
                updated.UnitPrice = product.UnitPrice;
                updated.UnitsInStock= product.UnitsInStock;
                db.SaveChanges();
            }
            else
            {
                TempData["Error"] = "Böyle bir kategori bulunamadı!";
                return RedirectToAction("Index", "Product");
            }
            return RedirectToAction("Index", "Product");
        }
    }
}
