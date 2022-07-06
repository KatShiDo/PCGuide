using Microsoft.AspNetCore.Http;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class GPUViewModel : PCPartViewModel
    {
        [Display(Name = "Размер видеопамяти")]
        [Required(ErrorMessage = "Введите размер видеопамяти")]
        public ushort MemoryCapacity { get; set; }

        [Display(Name = "Тип видеопамяти")]
        public string MemoryType { get; set; }

        [Display(Name = "Техпроцесс")]
        public string TechnicalProcess { get; set; }

        [Display(Name = "Частота ядра")]
        [Required(ErrorMessage = "Введите частоту")]
        public float ClockSpeed { get; set; }

        [Display(Name = "TDP")]
        [Required(ErrorMessage = "Введите TDP")]
        public ushort TDP { get; set; }

        [Display(Name = "Длина")]
        [Required(ErrorMessage = "Введите длину")]
        public ushort Length { get; set; }

        public static explicit operator GPUViewModel(GPU GPU)
        {
            return new GPUViewModel
            {
                Id = GPU.Id,
                ImageData = GPU.ImageData,
                DateCreate = GPU.DateCreate,
                Name = GPU.Name,
                Company = GPU.Company.ToString(),
                MemoryCapacity = GPU.MemoryCapacity,
                MemoryType = GPU.MemoryType.ToString(),
                TechnicalProcess = GPU.TechnicalProcess.ToString(),
                ClockSpeed = GPU.ClockSpeed,
                TDP = GPU.TDP,
                Length = GPU.Length
            };
        }

        public static explicit operator GPU(GPUViewModel GPUViewModel)
        {
            var GPU = new GPU
            {
                Id = GPUViewModel.Id,
                ImageData = GPUViewModel.ImageData,
                DateCreate = GPUViewModel.DateCreate,
                Name = GPUViewModel.Name,
                MemoryCapacity = GPUViewModel.MemoryCapacity,
                ClockSpeed = GPUViewModel.ClockSpeed,
                TDP = GPUViewModel.TDP,
                Length = GPUViewModel.Length
            };

            System.Enum.TryParse(GPUViewModel.Company, out Company company);
            GPU.Company = company;

            System.Enum.TryParse(GPUViewModel.MemoryType, out MemoryType memoryType);
            GPU.MemoryType = memoryType;

            System.Enum.TryParse(GPUViewModel.TechnicalProcess, out TechnicalProcess technicalProcess);
            GPU.TechnicalProcess = technicalProcess;

            return GPU;
        }

        public void CopyToModel(ref GPU model)
        {
            if (ImageData != null)
            {
                model.ImageData = ImageData;
            }

            model.DateCreate = DateCreate;
            model.Name = Name;
            model.MemoryCapacity = MemoryCapacity;
            model.ClockSpeed = ClockSpeed;

            System.Enum.TryParse(Company, out Company company);
            model.Company = company;

            System.Enum.TryParse(TechnicalProcess, out TechnicalProcess technicalProcess);
            model.TechnicalProcess = technicalProcess;

            model.TDP = TDP;
            model.Length = Length;
        }
    }
}
