using Microsoft.AspNetCore.Mvc;

namespace MVC_Empty.Controllers
{
    public class EmployeeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
