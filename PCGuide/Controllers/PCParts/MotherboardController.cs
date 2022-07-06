using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Controllers.PCParts
{
    public class MotherboardController : Controller
    {
        private readonly IBaseService<Motherboard, MotherboardViewModel> _motherboardService;

        public MotherboardController(IBaseService<Motherboard, MotherboardViewModel> motherboardService)
        {
            _motherboardService = motherboardService;
        }

        public IActionResult Index()
        {
            var data = _motherboardService.GetAll().Data
                .Select(x => (MotherboardViewModel)x);
            return View(data);
        }

        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _motherboardService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View(response.Data);
        }
    }
}
