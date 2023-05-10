using Microsoft.AspNetCore.Mvc;

namespace MVC_Empty.Controllers
{
    public class CustomerController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
