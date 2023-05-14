using Microsoft.AspNetCore.Mvc;

namespace MVC_Northwind.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
