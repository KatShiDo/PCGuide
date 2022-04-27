using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using PCGuide.Domain.ViewModels;
using System;
using System.Linq;

namespace PCGuide.Service
{
    public static class Extensions
    {
        public static CPUViewModel ToViewModel(this CPU CPU)
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

        public static CPU ToModel(this CPUViewModel CPUViewModel)
        {
            return new CPU
            {
                Id = CPUViewModel.Id,
                ImageData = CPUViewModel.ImageData,
                DateCreate = CPUViewModel.DateCreate,
                Name = CPUViewModel.Name,
                Company = (Company)Convert.ToInt32(CPUViewModel.Company),
                Series = (Series)Convert.ToInt32(CPUViewModel.Series),
                Socket = (Socket)Convert.ToInt32(CPUViewModel.Socket),
                TechnicalProcess = (TechnicalProcess)Convert.ToInt32(CPUViewModel.TechnicalProcess),
                CoresCount = CPUViewModel.CoresCount,
                ThreadsCount = CPUViewModel.ThreadsCount,
                CacheCapacity = CPUViewModel.CacheCapacity,
                HaveIntegratedGraphics = CPUViewModel.HaveIntegratedGraphics,
                IntegratedGraphics = (IntegratedGraphics)Convert.ToInt32(CPUViewModel.IntegratedGraphics),
                ClockSpeed = CPUViewModel.ClockSpeed,
                BoostClockSpeed = CPUViewModel.BoostClockSpeed,
                TDP = CPUViewModel.TDP,
                RAMType = (MemoryType)Convert.ToInt32(CPUViewModel.RAMType),
                RAMThreads = CPUViewModel.RAMThreads
            };
        }

        public static CPUCoolerViewModel ToViewModel(this CPUCooler CPUCooler)
        {
            return new CPUCoolerViewModel
            {
                Id = CPUCooler.Id,
                ImageData = CPUCooler.ImageData,
                DateCreate = CPUCooler.DateCreate,
                Name = CPUCooler.Name,
                Company = CPUCooler.Company.ToString(),
                TDP = CPUCooler.TDP,
                Height = CPUCooler.Height
            };
        }

        public static CPUCooler ToModel(this CPUCoolerViewModel CPUCoolerViewModel)
        {
            return new CPUCooler
            {
                Id = CPUCoolerViewModel.Id,
                ImageData = CPUCoolerViewModel.ImageData,
                DateCreate = CPUCoolerViewModel.DateCreate,
                Name = CPUCoolerViewModel.Name,
                Company = (Company)Convert.ToInt32(CPUCoolerViewModel.Company),
                TDP = CPUCoolerViewModel.TDP,
                Height = CPUCoolerViewModel.Height
            };
        }

        public static FrameViewModel ToViewModel(this Frame frame)
        {
            return new FrameViewModel
            {
                Id = frame.Id,
                ImageData = frame.ImageData,
                DateCreate = frame.DateCreate,
                Name = frame.Name,
                Company = frame.Company.ToString(),
                Height = frame.Height,
                Width = frame.Width,
                Lenght = frame.Lenght,
                MotherboardType = frame.MotherboardType.ToString()
            };
        }

        public static Frame ToModel(this FrameViewModel frameViewModel)
        {
            return new Frame
            {
                Id = frameViewModel.Id,
                ImageData = frameViewModel.ImageData,
                DateCreate = frameViewModel.DateCreate,
                Name = frameViewModel.Name,
                Company = (Company)Convert.ToInt32(frameViewModel.Company),
                Height = frameViewModel.Height,
                Width = frameViewModel.Width,
                Lenght = frameViewModel.Lenght,
                MotherboardType = (MotherboardType)Convert.ToInt32(frameViewModel.MotherboardType)
            };
        }

        public static GPUViewModel ToViewModel(this GPU GPU)
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

        public static GPU ToModel(this GPUViewModel GPUViewModel)
        {
            return new GPU
            {
                Id = GPUViewModel.Id,
                ImageData = GPUViewModel.ImageData,
                DateCreate = GPUViewModel.DateCreate,
                Name = GPUViewModel.Name,
                Company = (Company)Convert.ToInt32(GPUViewModel.Company),
                MemoryCapacity = GPUViewModel.MemoryCapacity,
                MemoryType = (MemoryType)Convert.ToInt32(GPUViewModel.MemoryType),
                TechnicalProcess = (TechnicalProcess)Convert.ToInt32(GPUViewModel.TechnicalProcess),
                ClockSpeed = GPUViewModel.ClockSpeed,
                TDP = GPUViewModel.TDP,
                Length = GPUViewModel.Length
            };
        }

        public static HardDriveViewModel ToViewModel(this HardDrive hardDrive)
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

        public static HardDrive ToModel(this HardDriveViewModel hardDriveViewModel)
        {
            return new HardDrive
            {
                Id = hardDriveViewModel.Id,
                ImageData = hardDriveViewModel.ImageData,
                DateCreate = hardDriveViewModel.DateCreate,
                Name = hardDriveViewModel.Name,
                Company = (Company)Convert.ToInt32(hardDriveViewModel.Company),
                MemoryCapacity = hardDriveViewModel.MemoryCapacity,
                RPM = hardDriveViewModel.RPM
            };
        }

        public static MotherboardViewModel ToViewModel(this Motherboard motherboard)
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

        public static Motherboard ToModel(this MotherboardViewModel motherboardViewModel)
        {
            return new Motherboard
            {
                Id = motherboardViewModel.Id,
                ImageData = motherboardViewModel.ImageData,
                DateCreate = motherboardViewModel.DateCreate,
                Name = motherboardViewModel.Name,
                Company = (Company)Convert.ToInt32(motherboardViewModel.Company),
                Socket = (Socket)Convert.ToInt32(motherboardViewModel.Socket),
                Chipset = (Chipset)Convert.ToInt32(motherboardViewModel.Chipset),
                MemoryType = (MemoryType)Convert.ToInt32(motherboardViewModel.MemoryType),
                MotherboardType = (MotherboardType)Convert.ToInt32(motherboardViewModel.MotherboardType)
            };
        }

        public static PowerUnitViewModel ToViewModel(this PowerUnit powerUnit)
        {
            return new PowerUnitViewModel
            {
                Id = powerUnit.Id,
                ImageData = powerUnit.ImageData,
                DateCreate = powerUnit.DateCreate,
                Name = powerUnit.Name,
                Company = powerUnit.Company.ToString(),
                Power = powerUnit.Power
            };
        }

        public static PowerUnit ToModel(this PowerUnitViewModel powerUnitViewModel)
        {
            return new PowerUnit
            {
                Id = powerUnitViewModel.Id,
                ImageData = powerUnitViewModel.ImageData,
                DateCreate = powerUnitViewModel.DateCreate,
                Name = powerUnitViewModel.Name,
                Company = (Company)Convert.ToInt32(powerUnitViewModel.Company),
                Power = powerUnitViewModel.Power
            };
        }

        public static RAMViewModel ToViewModel(this RAM RAM)
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

        public static RAM ToModel(this RAMViewModel RAMViewModel)
        {
            return new RAM
            {
                Id = RAMViewModel.Id,
                ImageData = RAMViewModel.ImageData,
                DateCreate = RAMViewModel.DateCreate,
                Name = RAMViewModel.Name,
                Company = (Company)Convert.ToInt32(RAMViewModel.Company),
                MemoryType = (MemoryType)Convert.ToInt32(RAMViewModel.MemoryType),
                ClockSpeed = RAMViewModel.ClockSpeed,
                Delay = RAMViewModel.Delay,
                MemoryCapacity = RAMViewModel.MemoryCapacity
            };
        }

        public static SSDViewModel ToViewModel(this SSD SSD)
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

        public static SSD ToModel(this SSDViewModel SSDViewModel)
        {
            return new SSD
            {
                Id = SSDViewModel.Id,
                ImageData = SSDViewModel.ImageData,
                DateCreate = SSDViewModel.DateCreate,
                Name = SSDViewModel.Name,
                Company = (Company)Convert.ToInt32(SSDViewModel.Company),
                MemoryCapacity = SSDViewModel.MemoryCapacity,
                WriteSpeed = SSDViewModel.WriteSpeed,
                ReadSpeed = SSDViewModel.ReadSpeed
            };
        }

        public static NewsViewModel ToViewModel(this News news)
        {
            return new NewsViewModel
            {
                Id = news.Id,
                ImageData = news.ImageData,
                DateCreate = news.DateCreate,
                Title = news.Title,
                Description = news.Description,
                Tags = news.TagsString.Split(" ").ToList(),
                TagsString = news.TagsString
            };
        }

        public static News ToModel(this NewsViewModel newsViewModel)
        {
            return new News
            {
                Id = newsViewModel.Id,
                ImageData = newsViewModel.ImageData,
                DateCreate = newsViewModel.DateCreate,
                Title = newsViewModel.Title,
                Description = newsViewModel.Description,
                TagsString = newsViewModel.TagsString
            };
        }

        public static TextFieldViewModel ToViewModel(this TextField textField)
        {
            return new TextFieldViewModel
            {
                Id = textField.Id,
                CodeWord = textField.CodeWord,
                Title = textField.Title,
                Text = textField.Text,
                MetaTitle = textField.MetaTitle,
                MetaDescription = textField.MetaDescription,
                MetaKeywords = textField.MetaKeywords
            };
        }

        public static TextField ToModel(this TextFieldViewModel textFieldViewModel)
        {
            return new TextField
            {
                Id = textFieldViewModel.Id,
                CodeWord = textFieldViewModel.CodeWord,
                Title = textFieldViewModel.Title,
                Text = textFieldViewModel.Text,
                MetaTitle = textFieldViewModel.MetaTitle,
                MetaDescription = textFieldViewModel.MetaDescription,
                MetaKeywords = textFieldViewModel.MetaKeywords
            };
        }
    }
}
