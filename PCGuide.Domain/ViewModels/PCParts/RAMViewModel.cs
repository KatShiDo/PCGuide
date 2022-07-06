using Microsoft.AspNetCore.Http;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class RAMViewModel : PCPartViewModel
    {
        [Display(Name = "Тип оперативной памяти")]
        public string MemoryType { get; set; }

        [Display(Name = "Частота")]
        [Required(ErrorMessage = "Введите частоту")]
        public uint ClockSpeed { get; set; }

        [Display(Name = "Задержка")]
        [Required(ErrorMessage = "Введите задержку")]
        public ushort Delay { get; set; }

        [Display(Name = "Размер памяти")]
        [Required(ErrorMessage = "Введите размер памяти")]
        public ushort MemoryCapacity { get; set; }

        public static explicit operator RAMViewModel(RAM RAM)
        {
            return new RAMViewModel
            {
                Id = RAM.Id,
                ImageData = RAM.ImageData,
                DateCreate = RAM.DateCreate,
                Name = RAM.Name,
                Company = RAM.Company.ToString(),
                MemoryType = RAM.MemoryType.ToString(),
                ClockSpeed = RAM.ClockSpeed,
                Delay = RAM.Delay,
                MemoryCapacity = RAM.MemoryCapacity
            };
        }

        public static explicit operator RAM(RAMViewModel RAMViewModel)
        {
            var RAM = new RAM
            {
                Id = RAMViewModel.Id,
                ImageData = RAMViewModel.ImageData,
                DateCreate = RAMViewModel.DateCreate,
                Name = RAMViewModel.Name,
                ClockSpeed = RAMViewModel.ClockSpeed,
                Delay = RAMViewModel.Delay,
                MemoryCapacity = RAMViewModel.MemoryCapacity
            };

            System.Enum.TryParse(RAMViewModel.Company, out Company company);
            RAM.Company = company;

            System.Enum.TryParse(RAMViewModel.MemoryType, out MemoryType memoryType);
            RAM.MemoryType = memoryType;

            return RAM;
        }

        public void CopyToModel(ref RAM model)
        {
            if (ImageData != null)
            {
                model.ImageData = ImageData;
            }

            model.DateCreate = DateCreate;
            model.Name = Name;
            model.ClockSpeed = ClockSpeed;
            model.Delay = Delay;
            model.MemoryCapacity = MemoryCapacity;

            System.Enum.TryParse(Company, out Company company);
            model.Company = company;
        }
    }
}
