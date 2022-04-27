using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class FrameViewModel
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

        [Display(Name = "Высота")]
        [Required(ErrorMessage = "Введите высоту")]
        public ushort Height { get; set; }

        [Display(Name = "Ширина")]
        [Required(ErrorMessage = "Введите ширину")]
        public ushort Width { get; set; }

        [Display(Name = "Длина")]
        [Required(ErrorMessage = "Введите длину")]
        public ushort Lenght { get; set; }

        [Display(Name = "Форм-фактор материнской платы")]
        public string MotherboardType { get; set; }
    }
}
