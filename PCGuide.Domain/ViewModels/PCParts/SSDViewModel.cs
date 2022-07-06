using Microsoft.AspNetCore.Http;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class SSDViewModel : PCPartViewModel
    {
        [Display(Name = "Размер памяти")]
        [Required(ErrorMessage = "Введите размер памяти")]
        public ushort MemoryCapacity { get; set; }

        [Display(Name = "Скорость записи")]
        [Required(ErrorMessage = "Введите скорость записи")]
        public uint WriteSpeed { get; set; }

        [Display(Name = "Скорость чтения")]
        [Required(ErrorMessage = "Введите скорость чтения")]
        public uint ReadSpeed { get; set; }

        public static explicit operator SSDViewModel(SSD SSD)
        {
            return new SSDViewModel
            {
                Id = SSD.Id,
                ImageData = SSD.ImageData,
                DateCreate = SSD.DateCreate,
                Name = SSD.Name,
                Company = SSD.Company.ToString(),
                MemoryCapacity = SSD.MemoryCapacity,
                WriteSpeed = SSD.WriteSpeed,
                ReadSpeed = SSD.ReadSpeed
            };
        }

        public static explicit operator SSD(SSDViewModel SSDViewModel)
        {
            var SSD = new SSD
            {
                Id = SSDViewModel.Id,
                ImageData = SSDViewModel.ImageData,
                DateCreate = SSDViewModel.DateCreate,
                Name = SSDViewModel.Name,
                MemoryCapacity = SSDViewModel.MemoryCapacity,
                WriteSpeed = SSDViewModel.WriteSpeed,
                ReadSpeed = SSDViewModel.ReadSpeed
            };

            System.Enum.TryParse(SSDViewModel.Company, out Company company);
            SSD.Company = company;

            return SSD;
        }

        public void CopyToModel(ref SSD model)
        {
            if (ImageData != null)
            {
                model.ImageData = ImageData;
            }

            model.DateCreate = DateCreate;
            model.Name = Name;
            model.MemoryCapacity = MemoryCapacity;
            model.WriteSpeed = WriteSpeed;
            model.ReadSpeed = ReadSpeed;

            System.Enum.TryParse(Company, out Company company);
            model.Company = company;
        }
    }
}
