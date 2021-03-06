using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service;
using PCGuide.Service.Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        private readonly IBaseService<News, NewsViewModel> _newsService;

        public NewsController(IBaseService<News, NewsViewModel> newsService)
        {
            _newsService = newsService;
        }

        public IActionResult Index()
        {
            var response = _newsService.GetAll();

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data.Select(x => (NewsViewModel)x));
            }

            return View("Error", $"{response.Description}");
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == default)
            {
                return View();
            }
            
            var response = await _newsService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View("Error", $"{response.Description}");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NewsViewModel model)
        {
            ModelState.Remove("DateCreate");

            if (ModelState.IsValid)
            {
                if (model.Image != null)
                {
                    using (var binaryReader = new BinaryReader(model.Image.OpenReadStream()))
                    {
                        model.ImageData = binaryReader.ReadBytes((int)model.Image.Length);
                    }
                }

                model.DateCreate = DateTime.Now;

                if (model.Id == default)
                {
                    await _newsService.CreateAsync(model);
                }
                else
                {
                    await _newsService.EditAsync(model);
                }

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _newsService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
