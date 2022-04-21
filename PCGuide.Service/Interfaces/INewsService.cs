using PCGuide.Domain.Models;
using PCGuide.Domain.Response;
using PCGuide.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Service.Interfaces
{
    public interface INewsService
    {
        IBaseResponse<IEnumerable<News>> GetNews();

        Task<IBaseResponse<NewsViewModel>> GetNewsByIdAsync(Guid id);

        Task<IBaseResponse<News>> CreateNewsAsync(NewsViewModel model);

        Task<IBaseResponse<bool>> DeleteNewsAsync(Guid id);

        Task<IBaseResponse<IEnumerable<News>>> GetNewsByTagAsync(string tag);

        Task<IBaseResponse<News>> EditNewsAsync(Guid id, NewsViewModel model);
    }
}
