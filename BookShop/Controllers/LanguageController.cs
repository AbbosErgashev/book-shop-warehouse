using BookShop.Business.IServices;
using BookShop.Business.Models.LanguageModel;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.MVC.Controllers
{
    public class LanguageController : Controller
    {
        private readonly ILanguageService _service;
        public LanguageController(ILanguageService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var getAll = await _service.GetAllLanguage();
            return View(getAll);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateLanguageModel model)
        {
            await _service.CreateLanguage(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteLanguage(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var entity = await _service.GetByIdLanguage(id);
            return View(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateLanguageModel model)
        {
            await _service.UpdateLanguage(model);
            return RedirectToAction("Index");
        }
    }
}
