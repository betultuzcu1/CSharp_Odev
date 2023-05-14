using Microsoft.AspNetCore.Mvc;

namespace MVC_Northwind.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
