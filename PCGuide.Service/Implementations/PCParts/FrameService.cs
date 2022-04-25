using Microsoft.EntityFrameworkCore;
using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
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
    public class FrameService : IBaseService<Frame, FrameViewModel>
    {
        private readonly IBaseRepository<Frame> _frameRepository;

        public FrameService(IBaseRepository<Frame> frameRepository)
        {
            _frameRepository = frameRepository;
        }

        public async Task<IBaseResponse<Frame>> CreateAsync(FrameViewModel model)
        {
            var baseResponse = new BaseResponse<Frame>();

            try
            {
                var frame = new Frame()
                {
                    Id = model.Id,
                    DateCreate = model.DateCreate,
                    Name = model.Name,
                    Height = model.Height,
                    Width = model.Width,
                    Lenght = model.Lenght,
                    MotherboardType = (MotherboardType)Convert.ToInt32(model.MotherboardType),
                    Image = model.ImageData
                };

                await _frameRepository.CreateAsync(frame);
                baseResponse.StatusCode = StatusCode.OK;
                baseResponse.Data = frame;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<Frame>()
                {
                    Description = $"[CreateAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<bool>> DeleteAsync(Guid id)
        {
            var baseResponse = new BaseResponse<bool>();

            try
            {
                var frame = await _frameRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (frame == null)
                {
                    baseResponse.Description = "Frame not found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    baseResponse.Data = false;

                    return baseResponse;
                }

                await _frameRepository.DeleteAsync(frame);
                baseResponse.StatusCode = StatusCode.OK;
                baseResponse.Data = true;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[DeleteAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<Frame>> EditAsync(Guid id, FrameViewModel model)
        {
            var baseResponse = new BaseResponse<Frame>();

            try
            {
                var frame = await _frameRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (frame == null)
                {
                    baseResponse.Description = "Frame not found";
                    baseResponse.StatusCode = StatusCode.NotFound;

                    return baseResponse;
                }

                frame.Name = model.Name;
                frame.Height = model.Height;
                frame.Width = model.Width;
                frame.Lenght = model.Lenght;
                frame.MotherboardType = (MotherboardType)Convert.ToInt32(model.MotherboardType);
                frame.Image = model.ImageData;

                await _frameRepository.UpdateAsync(frame);

                baseResponse.Data = frame;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<Frame>()
                {
                    Description = $"[EditAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public IBaseResponse<IEnumerable<Frame>> GetAll()
        {
            var baseResponse = new BaseResponse<IEnumerable<Frame>>();

            try
            {
                var frames = _frameRepository.GetAll();

                if (!frames.Any())
                {
                    baseResponse.Description = "Found 0 elements";
                    baseResponse.StatusCode = StatusCode.OK;

                    return baseResponse;
                }

                baseResponse.Data = frames;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Frame>>()
                {
                    Description = $"[GetAll] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<FrameViewModel>> GetByIdAsync(Guid id)
        {
            var baseResponse = new BaseResponse<FrameViewModel>();

            try
            {
                var frame = await _frameRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (frame == null)
                {
                    baseResponse.Description = "Frame not found";
                    baseResponse.StatusCode = StatusCode.NotFound;

                    return baseResponse;
                }

                var data = new FrameViewModel()
                {
                    DateCreate = frame.DateCreate,
                    Name = frame.Name,
                    Height = frame.Height,
                    Width = frame.Width,
                    Lenght = frame.Lenght,
                    MotherboardType = frame.MotherboardType.ToString(),
                    ImageData = frame.Image
                };

                baseResponse.Data = data;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<FrameViewModel>()
                {
                    Description = $"[GetByIdAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
