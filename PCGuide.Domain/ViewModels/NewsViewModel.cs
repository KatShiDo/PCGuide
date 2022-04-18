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

        public IFormFile Image { get; set; }

        public byte[]? ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        [Display(Name = "Название новости")]
        [Required(ErrorMessage = "Заполните название новости")]
        [MinLength(5, ErrorMessage = "Минимальная длина должна быть больше пяти символов")]
        public string Name { get; set; }

        [Display(Name = "Описание новости")]
        public string Description { get; set; }

        [Display(Name = "Тэги")]
        public List<string> Tags { get; set; }
    }
}
