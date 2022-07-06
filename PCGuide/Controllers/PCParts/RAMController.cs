using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Controllers.PCParts
{
    public class RAMController : Controller
    {
        private readonly IBaseService<RAM, RAMViewModel> _RAMService;

        public RAMController(IBaseService<RAM, RAMViewModel> RAMService)
        {
            _RAMService = RAMService;
        }

        public IActionResult Index()
        {
            var data = _RAMService.GetAll().Data
                .Select(x => (RAMViewModel)x);
            return View(data);
        }

        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _RAMService.GetByIdAsync(id);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return View(response.Data);
        }
    }
}
