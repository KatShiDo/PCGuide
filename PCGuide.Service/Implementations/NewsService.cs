using Microsoft.EntityFrameworkCore;
using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Enum;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Response;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Service.Implementations
{
    public class NewsService : IBaseService<News, NewsViewModel>
    {
        private readonly IBaseRepository<News> _newsRepository;

        public NewsService(IBaseRepository<News> newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public IBaseResponse<IEnumerable<News>> GetAll()
        {
            try
            {
                var news = _newsRepository.GetAll();

                if (!news.Any())
                {
                    return new BaseResponse<IEnumerable<News>>
                    {
                        Description = "Found 0 elements",
                        StatusCode = StatusCode.OK,
                        Data = news
                    };
                }

                return new BaseResponse<IEnumerable<News>>
                {
                    Data = news,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<News>>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<NewsViewModel>> GetByIdAsync(Guid id)
        {
            try
            {
                var news = await _newsRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (news == null)
                {
                    return new BaseResponse<NewsViewModel>
                    {
                        Description = "News not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<NewsViewModel>
                {
                    Data = (NewsViewModel)news,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<NewsViewModel>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<bool>> DeleteAsync(Guid id)
        {
            try
            {
                var news = await _newsRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (news == null)
                {
                    return new BaseResponse<bool>
                    {
                        Description = "News not found",
                        StatusCode = StatusCode.NotFound,
                        Data = false
                    };
                }

                await _newsRepository.DeleteAsync(news);

                return new BaseResponse<bool>
                {
                    StatusCode = StatusCode.OK,
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<News>> CreateAsync(NewsViewModel viewModel)
        {
            try
            {
                var news = (News)viewModel;
                await _newsRepository.CreateAsync(news);

                return new BaseResponse<News>
                {
                    StatusCode = StatusCode.OK,
                    Data = news
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<News>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<News>> EditAsync(NewsViewModel viewModel)
        {
            try
            {
                var news = await _newsRepository.GetAll().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

                if (news == null)
                {
                    return new BaseResponse<News>
                    {
                        Description = "News not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                viewModel.CopyToModel(ref news);

                await _newsRepository.UpdateAsync(news);

                return new BaseResponse<News>
                {
                    Data = news,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<News>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<News>> GetModelByIdAsync(Guid id)
        {
            try
            {
                var news = await _newsRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (news == null)
                {
                    return new BaseResponse<News>
                    {
                        Description = "News not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<News>
                {
                    Data = news,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<News>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
