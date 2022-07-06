using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FrameController : Controller
    {
        private readonly IBaseService<Frame, FrameViewModel> _frameService;

        public FrameController(IBaseService<Frame, FrameViewModel> frameService)
        {
            _frameService = frameService;
        }

        public IActionResult Index()
        {
            return View(_frameService.GetAll().Data.Select(x => (FrameViewModel)x));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == default)
            {
                return View();
            }

            var response = await _frameService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View("Error", $"{response.Description}");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(FrameViewModel model)
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
                    await _frameService.CreateAsync(model);
                }
                else
                {
                    await _frameService.EditAsync(model);
                }

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _frameService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
