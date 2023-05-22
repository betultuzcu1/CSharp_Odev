using Microsoft.AspNetCore.Mvc;

namespace MVC_MyProject.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
