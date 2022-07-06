using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Controllers.PCParts
{
    public class SSDController : Controller
    {
        private readonly IBaseService<SSD, SSDViewModel> _SSDService;

        public SSDController(IBaseService<SSD, SSDViewModel> SSDService)
        {
            _SSDService = SSDService;
        }

        public IActionResult Index()
        {
            var data = _SSDService.GetAll().Data
                .Select(x => (SSDViewModel)x);
            return View(data);
        }

        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _SSDService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View(response.Data);
        }
    }
}
