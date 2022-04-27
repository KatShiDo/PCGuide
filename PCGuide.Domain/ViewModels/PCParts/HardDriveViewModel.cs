﻿using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class HardDriveViewModel
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

        [Display(Name = "Размер памяти")]
        [Required(ErrorMessage = "Введите размер памяти")]
        public ushort MemoryCapacity { get; set; }

        [Display(Name = "Обороты в минуту")]
        [Required(ErrorMessage = "Введите обороты в минуту")]
        public ushort RPM { get; set; }
    }
}
