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
    public class GPUService : IBaseService<GPU, GPUViewModel>
    {
        private readonly IBaseRepository<GPU> _GPURepository;

        public GPUService(IBaseRepository<GPU> GPURepository)
        {
            _GPURepository = GPURepository;
        }

        public IBaseResponse<IEnumerable<GPU>> GetAll()
        {
            try
            {
                var GPUs = _GPURepository.GetAll();

                if (!GPUs.Any())
                {
                    return new BaseResponse<IEnumerable<GPU>>
                    {
                        Description = "Found 0 elements",
                        StatusCode = StatusCode.OK,
                        Data = GPUs
                    };
                }

                return new BaseResponse<IEnumerable<GPU>>
                {
                    Data = GPUs,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<GPU>>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<GPUViewModel>> GetByIdAsync(Guid id)
        {
            try
            {
                var GPU = await _GPURepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (GPU == null)
                {
                    return new BaseResponse<GPUViewModel>
                    {
                        Description = "GPU not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<GPUViewModel>
                {
                    Data = (GPUViewModel)GPU,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<GPUViewModel>
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
                var GPU = await _GPURepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (GPU == null)
                {
                    return new BaseResponse<bool>
                    {
                        Description = "GPU not found",
                        StatusCode = StatusCode.NotFound,
                        Data = false
                    };
                }

                await _GPURepository.DeleteAsync(GPU);

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

        public async Task<IBaseResponse<GPU>> CreateAsync(GPUViewModel viewModel)
        {
            try
            {
                var GPU = (GPU)viewModel;
                await _GPURepository.CreateAsync(GPU);

                return new BaseResponse<GPU>
                {
                    StatusCode = StatusCode.OK,
                    Data = GPU
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<GPU>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<GPU>> EditAsync(GPUViewModel viewModel)
        {
            try
            {
                var GPU = await _GPURepository.GetAll().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

                if (GPU == null)
                {
                    return new BaseResponse<GPU>
                    {
                        Description = "GPU not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                viewModel.CopyToModel(ref GPU);
                await _GPURepository.UpdateAsync(GPU);

                return new BaseResponse<GPU>
                {
                    Data = GPU,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<GPU>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<GPU>> GetModelByIdAsync(Guid id)
        {
            try
            {
                var GPU = await _GPURepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (GPU == null)
                {
                    return new BaseResponse<GPU>
                    {
                        Description = "GPU not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<GPU>
                {
                    Data = GPU,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<GPU>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
