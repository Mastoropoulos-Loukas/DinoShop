using Microsoft.AspNetCore.Mvc;

namespace DinoShopWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
