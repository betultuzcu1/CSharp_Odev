using Microsoft.AspNetCore.Mvc;

namespace Northwind_Odev_Mvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
