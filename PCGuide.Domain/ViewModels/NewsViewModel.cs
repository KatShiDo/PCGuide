using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Domain.ViewModels
{
    public class NewsViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Картинка")]
        [Required(ErrorMessage = "Загрузите картинку")]
        public IFormFile Image { get; set; }

        public byte[]? ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        [Display(Name = "Название новости")]
        [Required(ErrorMessage = "Заполните название новости")]
        [MinLength(5, ErrorMessage = "Минимальная длина - 5 символов")]
        public string Name { get; set; }

        [Display(Name = "Описание новости")]
        public string Description { get; set; }

        public List<string> Tags { get; set; }

        [Display(Name = "Теги")]
        public string TagsString { get; set; }
    }
}
