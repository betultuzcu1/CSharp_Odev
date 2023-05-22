using Microsoft.AspNetCore.Mvc;

namespace MVC_MyProject.Controllers
{
    public class categoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
