using Microsoft.AspNetCore.Mvc;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service;
using PCGuide.Service.Interfaces;
using System.Linq;

namespace PCGuide.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IBaseService<TextField, TextFieldViewModel> _textFieldController;

        public FeedbackController(IBaseService<TextField, TextFieldViewModel> textFieldController)
        {
            _textFieldController = textFieldController;
        }

        public IActionResult Index()
        {
            return View(_textFieldController.GetAll().Data.FirstOrDefault(x => x.CodeWord == "PageFeedback").ToViewModel());
        }
    }
}
