using Microsoft.AspNetCore.Mvc;
using MVC_Injection.Repository;
using MVC_Injection.Service;

namespace MVC_Injection.Controllers
{
    public class CategoryController : Controller
    {

        ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }




        public IActionResult Index()
        {
            _categoryRepository.GetCategories();
            return View();
        }
    }
}
