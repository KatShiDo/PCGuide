using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.ViewModels;
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
        private readonly INewsService _newsService;
        private readonly IWebHostEnvironment _hostEnvironment;

        public NewsController(INewsService newsService, IWebHostEnvironment hostEnvironment)
        {
            _newsService = newsService;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_newsService.GetNews().Data);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == default)
            {
                return View();
            }
            
            var response = await _newsService.GetNewsByIdAsync(id);

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
                using (var binaryReader = new BinaryReader(model.Image.OpenReadStream()))
                {
                    model.ImageData = binaryReader.ReadBytes((int)model.Image.Length);
                }

                model.Tags = model.TagsString.Split(" ").ToList();
                model.DateCreate = DateTime.Now;

                if (model.Id == default)
                {
                    await _newsService.CreateNewsAsync(model);
                }
                else
                {
                    await _newsService.EditNewsAsync(model.Id, model);
                }

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _newsService.DeleteNewsAsync(id);
            return RedirectToAction("Index");
        }
    }
}
