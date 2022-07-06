using Microsoft.AspNetCore.Http;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace PCGuide.Domain.ViewModels
{
    public class CPUViewModel : PCPartViewModel
    {
        [Display(Name = "Поколение")]
        public string Series { get; set; }

        [Display(Name = "Сокет")]
        public string Socket { get; set; }

        [Display(Name = "Техпроцесс")]
        public string TechnicalProcess { get; set; }

        [Display(Name = "Количество ядер")]
        [Required(ErrorMessage = "Введите количество ядер")]
        public ushort CoresCount { get; set; }

        [Display(Name = "Количество потоков")]
        [Required(ErrorMessage = "Введите количество потоков")]
        public ushort ThreadsCount { get; set; }

        [Display(Name = "Кэш")]
        [Required(ErrorMessage = "Введите кэш")]
        public ushort CacheCapacity { get; set; }

        [Display(Name = "Наличие интегрированного видеоядра")]
        public bool HaveIntegratedGraphics { get; set; }

        [Display(Name = "Модель интегрированной графики")]
        public string IntegratedGraphics { get; set; }

        [Display(Name = "Частота ядра")]
        [Required(ErrorMessage = "Введите частоту")]
        public float ClockSpeed { get; set; }

        [Display(Name = "Частота в бусте")]
        public float BoostClockSpeed { get; set; }

        [Display(Name = "TDP")]
        [Required(ErrorMessage = "Введите TDP")]
        public ushort TDP { get; set; }

        [Display(Name = "Оперативная память")]
        public string RAMType { get; set; }

        [Display(Name = "Количество потоков оперативной памяти")]
        [Required(ErrorMessage = "Введите количество потоков оперативной памяти")]
        public ushort RAMThreads { get; set; }

        public static explicit operator CPUViewModel(CPU CPU)
        {
            return new CPUViewModel
            {
                Id = CPU.Id,
                ImageData = CPU.ImageData,
                DateCreate = CPU.DateCreate,
                Name = CPU.Name,
                Company = CPU.Company.ToString(),
                Series = CPU.Series.ToString(),
                Socket = CPU.Socket.ToString(),
                TechnicalProcess = CPU.TechnicalProcess.ToString(),
                CoresCount = CPU.CoresCount,
                ThreadsCount = CPU.ThreadsCount,
                CacheCapacity = CPU.CacheCapacity,
                HaveIntegratedGraphics = CPU.HaveIntegratedGraphics,
                IntegratedGraphics = CPU.IntegratedGraphics.ToString(),
                ClockSpeed = CPU.ClockSpeed,
                BoostClockSpeed = CPU.BoostClockSpeed,
                TDP = CPU.TDP,
                RAMType = CPU.RAMType.ToString(),
                RAMThreads = CPU.RAMThreads
            };
        }

        public static explicit operator CPU(CPUViewModel CPUViewModel)
        {
            var CPU = new CPU
            {
                Id = CPUViewModel.Id,
                ImageData = CPUViewModel.ImageData,
                DateCreate = CPUViewModel.DateCreate,
                Name = CPUViewModel.Name
            };

            System.Enum.TryParse(CPUViewModel.Company, out Company company);
            CPU.Company = company;

            System.Enum.TryParse(CPUViewModel.Series, out Series series);
            CPU.Series = series;

            System.Enum.TryParse(CPUViewModel.Socket, out Socket socket);
            CPU.Socket = socket;

            System.Enum.TryParse(CPUViewModel.TechnicalProcess, out TechnicalProcess technicalProcess);
            CPU.TechnicalProcess = technicalProcess;

            CPU.CoresCount = CPUViewModel.CoresCount;
            CPU.ThreadsCount = CPUViewModel.ThreadsCount;
            CPU.CacheCapacity = CPUViewModel.CacheCapacity;
            CPU.HaveIntegratedGraphics = CPUViewModel.HaveIntegratedGraphics;

            if (CPUViewModel.HaveIntegratedGraphics)
            {
                System.Enum.TryParse(CPUViewModel.IntegratedGraphics, out IntegratedGraphics integratedGraphics);
                CPU.IntegratedGraphics = integratedGraphics;
            }

            CPU.ClockSpeed = CPUViewModel.ClockSpeed;
            CPU.BoostClockSpeed = CPUViewModel.BoostClockSpeed;
            CPU.TDP = CPUViewModel.TDP;

            System.Enum.TryParse(CPUViewModel.RAMType, out MemoryType memoryType);
            CPU.RAMType = memoryType;

            CPU.RAMThreads = CPUViewModel.RAMThreads;

            return CPU;
        }

        public void CopyToModel(ref CPU model)
        {
            if (ImageData != null)
            {
                model.ImageData = ImageData;
            }
            
            model.DateCreate = DateCreate;
            model.Name = Name;

            System.Enum.TryParse(Company, out Company company);
            model.Company = company;

            System.Enum.TryParse(Series, out Series series);
            model.Series = series;

            System.Enum.TryParse(Socket, out Socket socket);
            model.Socket = socket;

            System.Enum.TryParse(TechnicalProcess, out TechnicalProcess technicalProcess);
            model.TechnicalProcess = technicalProcess;

            model.CoresCount = CoresCount;
            model.ThreadsCount = ThreadsCount;
            model.CacheCapacity = CacheCapacity;
            model.HaveIntegratedGraphics = HaveIntegratedGraphics;

            if (HaveIntegratedGraphics)
            {
                System.Enum.TryParse(IntegratedGraphics, out IntegratedGraphics integratedGraphics);
                model.IntegratedGraphics = integratedGraphics;
            }

            model.ClockSpeed = ClockSpeed;
            model.BoostClockSpeed = BoostClockSpeed;
            model.TDP = TDP;

            System.Enum.TryParse(RAMType, out MemoryType memoryType);
            model.RAMType = memoryType;

            model.RAMThreads = RAMThreads;
        }
    }
}
