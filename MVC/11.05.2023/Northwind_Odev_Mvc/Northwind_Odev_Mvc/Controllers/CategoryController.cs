using Microsoft.AspNetCore.Mvc;
using Northwind_Odev_Mvc.Models;

namespace Northwind_Odev_Mvc.Controllers
{
    public class CategoryController : Controller
    {
        //context
        NorthwndContext db = new NorthwndContext();

        //Category List
        public IActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        //GetProducts
        public IActionResult GetCategories(int? id)//5
        {

            
            if (id != null)
            {
                var products = db.Categories.Where(x => x.CategoryId == id).ToList();

                ViewBag.CategoryName = db.Categories.FirstOrDefault(x => x.CategoryId == id).CategoryName;
                return View(products);
            }
            else
            {
                return View(db.Products.ToList());
            }

        }

        //Create
        [HttpGet]//hiçbir şey yapmazsam ürünleri tekrar listele
        public IActionResult CreateCategory() 
        {
            return View();

        }
        [HttpPost]//kaydet butonuna basarsam yenikategori ekle

        public IActionResult CreateCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return View();
        }

        //Delete
        public IActionResult DeleteCategory(int id)
        {
            var deleted=db.Categories.Find(id);
            if(deleted != null)
            {
                db.Categories.Remove(deleted);
                db.SaveChanges();
            }
            else
            {
                TempData["Error"] = "Böyle bir kategori bulunamadı!";
                return RedirectToAction("Index", "Category");
            }
            return RedirectToAction("Index", "Category");


        }
        //Update
        public IActionResult UpdateCategory(Category category)
        {
            var updated = db.Categories.Find(category.CategoryId);
            if (updated != null)
            {
                // Kategori adını güncelleme işlemi
                updated.CategoryName = category.CategoryName;
                updated.Description = category.Description;
                db.SaveChanges();
            }
            else
            {
                TempData["Error"] = "Böyle bir kategori bulunamadı!";
                return RedirectToAction("Index", "Category");
            }
            return RedirectToAction("Index", "Category");
        }

    }
}
