using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Identity.Controllers
{
    public class OrderController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
