using Microsoft.AspNetCore.Mvc;

namespace MVC_Empty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
