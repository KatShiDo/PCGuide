using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Controllers.PCParts
{
    public class FrameController : Controller
    {
        private readonly IBaseService<Frame, FrameViewModel> _frameService;

        public FrameController(IBaseService<Frame, FrameViewModel> frameService)
        {
            _frameService = frameService;
        }

        public IActionResult Index()
        {
            var data = _frameService.GetAll().Data
                .Select(x => (FrameViewModel)x);
            return View(data);
        }

        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _frameService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View(response.Data);
        }
    }
}
