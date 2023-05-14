using Microsoft.AspNetCore.Mvc;

namespace Northwind_Odev_Mvc.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
