using Microsoft.AspNetCore.Http;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class MotherboardViewModel : PCPartViewModel
    {
        [Display(Name = "Сокет")]
        public string Socket { get; set; }

        [Display(Name = "Чипсет")]
        public string Chipset { get; set; }

        [Display(Name = "Тип оперативной памяти")]
        public string MemoryType { get; set; }

        [Display(Name = "Форм-фактор материнской платы")]
        public string MotherboardType { get; set; }

        public static explicit operator MotherboardViewModel(Motherboard motherboard)
        {
            return new MotherboardViewModel
            {
                Id = motherboard.Id,
                ImageData = motherboard.ImageData,
                DateCreate = motherboard.DateCreate,
                Name = motherboard.Name,
                Company = motherboard.Company.ToString(),
                Socket = motherboard.Socket.ToString(),
                Chipset = motherboard.Chipset.ToString(),
                MemoryType = motherboard.MemoryType.ToString(),
                MotherboardType = motherboard.MotherboardType.ToString()
            };
        }

        public static explicit operator Motherboard(MotherboardViewModel motherboardViewModel)
        {
            var motherboard = new Motherboard
            {
                Id = motherboardViewModel.Id,
                ImageData = motherboardViewModel.ImageData,
                DateCreate = motherboardViewModel.DateCreate,
                Name = motherboardViewModel.Name
            };

            System.Enum.TryParse(motherboardViewModel.Company, out Company company);
            motherboard.Company = company;

            System.Enum.TryParse(motherboardViewModel.Socket, out Socket socket);
            motherboard.Socket = socket;

            System.Enum.TryParse(motherboardViewModel.Chipset, out Chipset chipset);
            motherboard.Chipset = chipset;

            System.Enum.TryParse(motherboardViewModel.MemoryType, out MemoryType memoryType);
            motherboard.MemoryType = memoryType;

            System.Enum.TryParse(motherboardViewModel.MotherboardType, out MotherboardType motherboardType);
            motherboard.MotherboardType = motherboardType;

            return motherboard;
        }

        public void CopyToModel(ref Motherboard model)
        {
            if (ImageData != null)
            {
                model.ImageData = ImageData;
            }

            model.DateCreate = DateCreate;
            model.Name = Name;

            System.Enum.TryParse(Company, out Company company);
            model.Company = company;

            System.Enum.TryParse(Socket, out Socket socket);
            model.Socket = socket;

            System.Enum.TryParse(Chipset, out Chipset chipset);
            model.Chipset = chipset;

            System.Enum.TryParse(MemoryType, out MemoryType memoryType);
            model.MemoryType = memoryType;

            System.Enum.TryParse(MotherboardType, out MotherboardType motherboardType);
            model.MotherboardType = motherboardType;
        }
    }
}
