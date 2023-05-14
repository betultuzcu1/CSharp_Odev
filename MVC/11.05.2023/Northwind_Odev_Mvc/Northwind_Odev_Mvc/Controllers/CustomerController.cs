using Microsoft.AspNetCore.Mvc;

namespace Northwind_Odev_Mvc.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
