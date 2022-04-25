using Microsoft.Extensions.DependencyInjection;
using PCGuide.DAL.Interfaces;
using PCGuide.DAL.Repositories;
using PCGuide.Domain.Entities;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Implementations;
using PCGuide.Service.Interfaces;

namespace PCGuide
{
    public static class StartupInit
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddTransient<IBaseRepository<News>, NewsRepository>();
            services.AddTransient<IBaseRepository<TextField>, TextFieldRepository>();
            services.AddTransient<IBaseRepository<CPU>, CPURepository>();
            services.AddTransient<IBaseRepository<Frame>, FrameRepository>();
            services.AddTransient<IBaseRepository<GPU>, GPURepository>();
            services.AddTransient<IBaseRepository<HardDrive>, HardDriveRepository>();
            services.AddTransient<IBaseRepository<Motherboard>, MotherboardRepository>();
            services.AddTransient<IBaseRepository<PowerUnit>, PowerUnitRepository>();
            services.AddTransient<IBaseRepository<CPUCooler>, CPUCoolerRepository>();
            services.AddTransient<IBaseRepository<RAM>, RAMRepository>();
            services.AddTransient<IBaseRepository<SSD>, SSDRepository>();
        }

        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddTransient<IBaseService<News, NewsViewModel>, NewsService>();
            services.AddTransient<IBaseService<TextField, TextFieldViewModel>, TextFieldService>();
            services.AddTransient<IBaseService<CPU, CPUViewModel>, CPUService>();
            services.AddTransient<IBaseService<CPUCooler, CPUCoolerViewModel>, CPUCoolerService>();
            services.AddTransient<IBaseService<Frame, FrameViewModel>, FrameService>();
            services.AddTransient<IBaseService<GPU, GPUViewModel>, GPUService>();
            services.AddTransient<IBaseService<HardDrive, HardDriveViewModel>, HardDriveService>();
            services.AddTransient<IBaseService<Motherboard, MotherboardViewModel>, MotherboardService>();
            services.AddTransient<IBaseService<PowerUnit, PowerUnitViewModel>, PowerUnitService>();
            services.AddTransient<IBaseService<RAM, RAMViewModel>, RAMService>();
            services.AddTransient<IBaseService<SSD, SSDViewModel>, SSDService>();
        }
    }
}
