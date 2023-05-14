using Microsoft.AspNetCore.Mvc;
using Northwind_Odev_Mvc.Models;

namespace Northwind_Odev_Mvc.Controllers
{
    public class EmployeeController : Controller
    {
        //context
        NorthwndContext db = new NorthwndContext();

        // List
        public IActionResult Index()
        {
            return View(db.Employees.ToList());
        }

      

        //Create
        [HttpGet]
        public IActionResult CreateEmployee()
        {
            return View();

        }
        [HttpPost]

        public IActionResult CreateEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return View();
        }

        //Delete
        public IActionResult DeleteEmployee(int id)
        {
            var deleted = db.Employees.Find(id);
            if (deleted != null)
            {
                db.Employees.Remove(deleted);
                db.SaveChanges();
            }
            else
            {
                TempData["Error"] = "Böyle bir kategori bulunamadı!";
                return RedirectToAction("Index", "Employee");
            }
            return RedirectToAction("Index", "Employee");

        }
    }
}
