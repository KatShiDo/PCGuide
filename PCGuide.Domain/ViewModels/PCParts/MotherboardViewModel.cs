using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class MotherboardViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Картинка")]
        //[Required(ErrorMessage = "Загрузите картинку")]
        public IFormFile Image { get; set; }

        public byte[] ImageData { get; set; }

        public DateTime DateCreate { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Введите название")]
        public string Name { get; set; }

        [Display(Name = "Производитель")]
        public string Company { get; set; }

        [Display(Name = "Сокет")]
        public string Socket { get; set; }

        [Display(Name = "Чипсет")]
        public string Chipset { get; set; }

        [Display(Name = "Тип оперативной памяти")]
        public string MemoryType { get; set; }

        [Display(Name = "Форм-фактор материнской платы")]
        public string MotherboardType { get; set; }
    }
}
