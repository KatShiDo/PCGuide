using Microsoft.AspNetCore.Http;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class HardDriveViewModel : PCPartViewModel
    {
        [Display(Name = "Размер памяти")]
        [Required(ErrorMessage = "Введите размер памяти")]
        public ushort MemoryCapacity { get; set; }

        [Display(Name = "Обороты в минуту")]
        [Required(ErrorMessage = "Введите обороты в минуту")]
        public ushort RPM { get; set; }

        public static explicit operator HardDriveViewModel(HardDrive hardDrive)
        {
            return new HardDriveViewModel
            {
                Id = hardDrive.Id,
                ImageData = hardDrive.ImageData,
                DateCreate = hardDrive.DateCreate,
                Name = hardDrive.Name,
                Company = hardDrive.Company.ToString(),
                MemoryCapacity = hardDrive.MemoryCapacity,
                RPM = hardDrive.RPM
            };
        }

        public static explicit operator HardDrive(HardDriveViewModel hardDriveViewModel)
        {
            var hardDrive = new HardDrive
            {
                Id = hardDriveViewModel.Id,
                ImageData = hardDriveViewModel.ImageData,
                DateCreate = hardDriveViewModel.DateCreate,
                Name = hardDriveViewModel.Name,
                MemoryCapacity = hardDriveViewModel.MemoryCapacity,
                RPM = hardDriveViewModel.RPM
            };

            System.Enum.TryParse(hardDriveViewModel.Company, out Company company);
            hardDrive.Company = company;

            return hardDrive;
        }

        public void CopyToModel(ref HardDrive model)
        {
            if (ImageData != null)
            {
                model.ImageData = ImageData;
            }

            model.DateCreate = DateCreate;
            model.Name = Name;
            model.MemoryCapacity = MemoryCapacity;
            model.RPM = RPM;

            System.Enum.TryParse(Company, out Company company);
            model.Company = company;
        }
    }
}
