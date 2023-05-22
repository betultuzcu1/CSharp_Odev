using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_MyProject.Models;
using MyECommerce.Entity.Entity;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;
using MVC_MyProject.Models.CartModel;
using MVC_MyProject.Utilities;
using Microsoft.EntityFrameworkCore;
using MyECommerce.DAL.Context;

namespace MVC_MyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly MyECommerceContext _context;

        public HomeController(ILogger<HomeController> logger, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, MyECommerceContext context)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult AddToCart(int id)//1000
        {


            Product product = _context.Products.Find(id);
            if (product != null)
            {

                //Session
                Cart cartSession;

                //Serialize => Json
                if (SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "sepet") == null)
                {
                    cartSession = new Cart();
                }
                else
                {
                    cartSession = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "sepet");
                }



                CartItem cartItem = new CartItem();
                cartItem.Id = product.Id;
                cartItem.ProductName = product.ProductName;
                cartItem.UnitPrice = product.UnitPrice;

                cartSession.AddItem(cartItem);
                SessionHelper.SetJsonProduct(HttpContext.Session, "sepet", cartSession);

            }




            return RedirectToAction("Index");
        }

        public IActionResult MyCart()
        {
            if (SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "sepet") != null)
            {

                var sepet = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "sepet");
                return View(sepet);
            }
            else
            {
                return RedirectToAction("Product");
            }
        }
    }
}