using Microsoft.AspNetCore.Mvc;
using Northwind_Odev_Mvc.Models;

namespace Northwind_Odev_Mvc.Controllers
{
    public class CustomerController : Controller
    {
        //context
        NorthwndContext db = new NorthwndContext();

        //Category List
        public IActionResult Index()
        {
            return View(db.Customers.ToList());
        }


        //Create
        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();

        }
        [HttpPost]

        public IActionResult CreateCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return View();
        }

        //Delete
        public IActionResult DeleteCustomer(int id)
        {
            var deleted = db.Customers.Find(id);
            if (deleted != null)
            {
                db.Customers.Remove(deleted);
                db.SaveChanges();
            }
            else
            {
                TempData["Error"] = "Böyle bir kategori bulunamadı!";
                return RedirectToAction("Index", "Customer");
            }
            return RedirectToAction("Index", "Customer");


        }
        //Update
        public IActionResult UpdateCustomer(Customer customer)
        {
            var updated = db.Customers.Find(customer.CustomerId);
            if (updated != null)
            {
                updated.CompanyName = customer.CompanyName;
                updated.ContactName = customer.ContactName;
                db.SaveChanges();
            }
            else
            {
                TempData["Error"] = "Böyle bir kategori bulunamadı!";
                return RedirectToAction("Index", "Customer");
            }
            return RedirectToAction("Index", "Customer");
        }
    }
}
