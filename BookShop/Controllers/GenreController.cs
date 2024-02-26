using BookShop.Business.IServices;
using BookShop.Business.Models.GenreModel;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.MVC.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService _service;

        public GenreController(IGenreService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllGenres(); 
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateGenreModel model)
        {
            await _service.CreateGenre(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteGenre(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var genre = await _service.GetByIdGenre(id);
            return View(genre);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateGenreModel model)
        {
            await _service.UpdateGenre(model);
            return RedirectToAction("Index");
        }
    }
}
