using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Controllers.PCParts
{
    public class PowerUnitController : Controller
    {
        private readonly IBaseService<PowerUnit, PowerUnitViewModel> _powerUnitService;

        public PowerUnitController(IBaseService<PowerUnit, PowerUnitViewModel> powerUnitService)
        {
            _powerUnitService = powerUnitService;
        }

        public IActionResult Index()
        {
            var data = _powerUnitService.GetAll().Data
                .Select(x => (PowerUnitViewModel)x);
            return View(data);
        }

        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _powerUnitService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View(response.Data);
        }
    }
}
