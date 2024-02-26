using BookShop.Business.IServices;
using BookShop.Business.Models.AuthorModel;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.MVC.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _service;

        public AuthorController(IAuthorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Indexx()
        {
            var getAll = await _service.GetAllAuthors();
            return View(getAll);
        }

        [HttpGet]
        public IActionResult Createe()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorModel create)
        {
            await _service.CreateAuthor(create);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Deletee(int id)
        {
            await _service.DeleteAuthor(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Editt(int id)
        {
            var entity = await _service.GetAuthor(id);
            return View(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Edittt([FromBody] UpdateAuthorModel update)
        {
            await _service.UpdateAuthor(update);
            return RedirectToAction("Index");
        }
    }
}
