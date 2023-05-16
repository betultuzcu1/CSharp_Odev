using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Identity.Models.ViewModel;

namespace MVC_Identity.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser();
                user.Email = registerVM.Email;
                user.UserName = registerVM.Username;

                //eğer aynı email adresi ile kayıt olunmasını istemiyorsak;



                var result = await _userManager.CreateAsync(user, registerVM.Password);
                if (result.Succeeded)
                {
                    TempData["Success"] = $"{registerVM.Username} isimli kullanıcı oluşturuldu";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    //todo: hata mesajları ui'da gösterilecek.
                    return View(registerVM);
                }

            }
            else
            {
                return View(registerVM);
            }
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {

                var login = await _userManager.FindByEmailAsync(loginVM.Email);

                if (login != null)
                {


                    var result = await _signInManager.PasswordSignInAsync(login, loginVM.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return View(loginVM);
                    }


                }
                else
                {
                    return View(loginVM);
                }

                return View();
            }
            else
            {
                return View(loginVM);

            }
        }
    }
}
