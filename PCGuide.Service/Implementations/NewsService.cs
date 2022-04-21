using Microsoft.EntityFrameworkCore;
using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Enum;
using PCGuide.Domain.Models;
using PCGuide.Domain.Response;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Service.Implementations
{
    public class NewsService : INewsService
    {
        private readonly IBaseRepository<News> _newsRepository;

        public NewsService(IBaseRepository<News> newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public IBaseResponse<IEnumerable<News>> GetNews()
        {
            var baseResponse = new BaseResponse<IEnumerable<News>>();

            try
            {
                var news = _newsRepository.GetAll();

                if (!news.Any())
                {
                    baseResponse.Description = "Found 0 elements";
                    baseResponse.StatusCode = StatusCode.OK;

                    return baseResponse;
                }

                baseResponse.Data = news;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<News>>()
                {
                    Description = $"[GetNews] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<NewsViewModel>> GetNewsByIdAsync(Guid id)
        {
            var baseResponse = new BaseResponse<NewsViewModel>();

            try
            {
                var news = await _newsRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (news == null)
                {
                    baseResponse.Description = "News not found";
                    baseResponse.StatusCode = StatusCode.NotFound;

                    return baseResponse;
                }

                var data = new NewsViewModel()
                {
                    DateCreate = news.DateCreate,
                    Name = news.Name,
                    Description = news.Description,
                    Tags = news.Tags.Split(" ").ToList(),
                    TagsString = news.Tags,
                    ImageData = news.Image
                };

                baseResponse.Data = data;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<NewsViewModel>()
                {
                    Description = $"[GetNewsByIdAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<News>>> GetNewsByTagAsync(string tag)
        {
            var baseResponse = new BaseResponse<IEnumerable<News>>();

            try
            {
                var news = await _newsRepository.GetAll().Where(x => x.Tags.Contains(tag)).ToListAsync();

                if (news == null)
                {
                    baseResponse.Description = "News not found";
                    baseResponse.StatusCode = StatusCode.NotFound;

                    return baseResponse;
                }

                baseResponse.Data = news;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<News>>()
                {
                    Description = $"[GetNewsByTagAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<bool>> DeleteNewsAsync(Guid id)
        {
            var baseResponse = new BaseResponse<bool>();

            try
            {
                var news = await _newsRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (news == null)
                {
                    baseResponse.Description = "News not found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    baseResponse.Data = false;

                    return baseResponse;
                }

                await _newsRepository.DeleteAsync(news);
                baseResponse.StatusCode = StatusCode.OK;
                baseResponse.Data = true;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[DeleteNewsAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<News>> CreateNewsAsync(NewsViewModel model)
        {
            var baseResponse = new BaseResponse<News>();

            try
            {
                var news = new News()
                {
                    Id = model.Id,
                    DateCreate = DateTime.Now,
                    Image = model.ImageData,
                    Name = model.Name,
                    Description = model.Description,
                    Tags = model.TagsString
                };

                await _newsRepository.CreateAsync(news);
                baseResponse.StatusCode = StatusCode.OK;
                baseResponse.Data = news;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<News>()
                {
                    Description = $"[CreateNewsAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<News>> EditNewsAsync(Guid id, NewsViewModel model)
        {
            var baseResponse = new BaseResponse<News>();

            try
            {
                var news = await _newsRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (news == null)
                {
                    baseResponse.Description = "News not found";
                    baseResponse.StatusCode = StatusCode.NotFound;

                    return baseResponse;
                }

                news.Description = model.Description;
                news.Name = model.Name;
                news.Tags = model.TagsString;
                news.DateCreate = model.DateCreate;
                news.Image = model.ImageData;

                await _newsRepository.UpdateAsync(news);

                baseResponse.Data = news;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<News>()
                {
                    Description = $"[EditNewsAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
