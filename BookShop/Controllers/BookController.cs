using Microsoft.AspNetCore.Mvc;

namespace BookShop.MVC.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
