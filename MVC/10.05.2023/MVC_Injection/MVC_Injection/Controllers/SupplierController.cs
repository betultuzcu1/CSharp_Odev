using Microsoft.AspNetCore.Mvc;
using MVC_Injection.Models;
using MVC_Injection.Repository;
using System.Reflection;

namespace MVC_Injection.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierRepository _supplierRepository;

        //CRUD

        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        public IActionResult Index()
        {
            return View(_supplierRepository.GetSuppliers());
        }
        //Create 
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
       
        public IActionResult Create(Supplier supplier)
        {
            _supplierRepository.GetSuppliers().Add(supplier);


            return RedirectToAction("Index", new { id = supplier.ID });
        }


        public IActionResult Update(int id)
        {
            var updated = _supplierRepository.GetSuppliers().Where(x => x.ID == id).FirstOrDefault();
            return View(updated);
        }

        //Update Post
        [HttpPost]
        public IActionResult Update(Supplier model)
        {
            var updated = _supplierRepository.GetSuppliers().Where(x => x.ID == model.ID).FirstOrDefault();
            updated.CompanyName = model.CompanyName;
            updated.ContactName = model.ContactName;

            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            var deleted = _supplierRepository.GetSuppliers().Where(x => x.ID == id).FirstOrDefault();

            _supplierRepository.GetSuppliers().Remove(deleted);


            return RedirectToAction("Index");
        }
    }
}
