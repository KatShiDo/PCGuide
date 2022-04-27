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

        public async Task<IBaseResponse<Frame>> CreateAsync(FrameViewModel viewModel)
        {
            try
            {
                var frame = viewModel.ToModel();
                await _frameRepository.CreateAsync(frame);

                return new BaseResponse<Frame>
                {
                    StatusCode = StatusCode.OK,
                    Data = frame
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Frame>
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
                var frame = await _frameRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (frame == null)
                {
                    return new BaseResponse<bool>
                    {
                        Description = "Frame not found",
                        StatusCode = StatusCode.NotFound,
                        Data = false
                    };
                }

                await _frameRepository.DeleteAsync(frame);

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

        public async Task<IBaseResponse<Frame>> EditAsync(FrameViewModel viewModel)
        {
            try
            {
                var frame = await _frameRepository.GetAll().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

                if (frame == null)
                {
                    return new BaseResponse<Frame>
                    {
                        Description = "Frame not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                frame = viewModel.ToModel();
                await _frameRepository.UpdateAsync(frame);

                return new BaseResponse<Frame>
                {
                    Data = frame,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Frame>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public IBaseResponse<IEnumerable<Frame>> GetAll()
        {
            try
            {
                var frames = _frameRepository.GetAll();

                if (!frames.Any())
                {
                    return new BaseResponse<IEnumerable<Frame>>
                    {
                        Description = "Found 0 elements",
                        StatusCode = StatusCode.OK,
                        Data = frames
                    };
                }

                return new BaseResponse<IEnumerable<Frame>>
                {
                    Data = frames,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Frame>>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<FrameViewModel>> GetByIdAsync(Guid id)
        {
            try
            {
                var frame = await _frameRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (frame == null)
                {
                    return new BaseResponse<FrameViewModel>
                    {
                        Description = "Frame not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<FrameViewModel>
                {
                    Data = frame.ToViewModel(),
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<FrameViewModel>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
