using Microsoft.Extensions.DependencyInjection;
using PCGuide.DAL.Interfaces;
using PCGuide.DAL.Repositories;
using PCGuide.Domain.Models;
using PCGuide.Service.Implementations;
using PCGuide.Service.Interfaces;

namespace PCGuide
{
    public static class StartupInit
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddTransient<IBaseRepository<News>, NewsRepository>();
        }

        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddTransient<INewsService, NewsService>();
        }
    }
}
