using Microsoft.AspNetCore.Mvc;

namespace MVC_Northwind.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
