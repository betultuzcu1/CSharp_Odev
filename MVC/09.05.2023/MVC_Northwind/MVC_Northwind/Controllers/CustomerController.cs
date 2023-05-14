using Microsoft.AspNetCore.Mvc;

namespace MVC_Northwind.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
