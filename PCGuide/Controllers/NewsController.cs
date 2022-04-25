using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Response;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Controllers
{
    public class NewsController : Controller
    {
        private readonly IBaseService<News, NewsViewModel> _newsService;
        private readonly IBaseService<TextField, TextFieldViewModel> _textFieldService;

        public NewsController(IBaseService<News, NewsViewModel> newsService, IBaseService<TextField, TextFieldViewModel> textFieldService)
        {
            _newsService = newsService;
            _textFieldService = textFieldService;
        }

        [HttpGet]
        public IActionResult GetNews()
        {
            var responseNews = _newsService.GetAll();
            var responseTextField = _textFieldService.GetAll();
            if (responseNews.StatusCode == Domain.Enum.StatusCode.OK && responseTextField.StatusCode == Domain.Enum.StatusCode.OK)
            {
                ViewBag.Text = responseTextField.Data.FirstOrDefault(x => x.CodeWord == "PageNews").Text;
                return View(responseNews.Data);
            }

            return RedirectToAction("Error", $"{responseNews.Description},{responseTextField.Description}");
        }

        [HttpGet]
        public IActionResult GetNewsByTag(string tag)
        {
            var response = _newsService.GetAll();
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View("GetNews", response.Data.Where(x => x.Tags.Contains(tag)));
            }

            return RedirectToAction("Error", $"{response.Description}");
        }

        [HttpGet]
        public async Task<IActionResult> GetNewsById(Guid id)
        {
            var response = await _newsService.GetByIdAsync(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return RedirectToAction("Error", $"{response.Description}");
        }
    }
}
