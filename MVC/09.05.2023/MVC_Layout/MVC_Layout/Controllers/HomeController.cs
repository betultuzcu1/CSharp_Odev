using Microsoft.AspNetCore.Mvc;
using MVC_Layout.Models;

namespace MVC_Layout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact(Contact contact)
        {
            ContactItem.ContactList.Add(contact);
            return View();
        }


        //İletisim Action


    }
}
