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
    public class CPUService : IBaseService<CPU, CPUViewModel>
    {
        private readonly IBaseRepository<CPU> _CPURepository;

        public CPUService(IBaseRepository<CPU> CPURepository)
        {
            _CPURepository = CPURepository;
        }

        public IBaseResponse<IEnumerable<CPU>> GetAll()
        {
            try
            {
                var CPUs = _CPURepository.GetAll();

                if (!CPUs.Any())
                {
                    return new BaseResponse<IEnumerable<CPU>>
                    {
                        Description = "Found 0 elements",
                        StatusCode = StatusCode.OK,
                        Data = CPUs
                    };
                }

                return new BaseResponse<IEnumerable<CPU>>
                {
                    Data = CPUs,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<CPU>>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<CPUViewModel>> GetByIdAsync(Guid id)
        {
            try
            {
                var CPU = await _CPURepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (CPU == null)
                {
                    return new BaseResponse<CPUViewModel>
                    {
                        Description = "CPU not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<CPUViewModel>
                {
                    Data = (CPUViewModel)CPU,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPUViewModel>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<CPU>> GetModelByIdAsync(Guid id)
        {
            try
            {
                var CPU = await _CPURepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (CPU == null)
                {
                    return new BaseResponse<CPU>
                    {
                        Description = "CPU not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<CPU>
                {
                    Data = CPU,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPU>
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
                var CPU = await _CPURepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (CPU == null)
                {
                    return new BaseResponse<bool>
                    {
                        Description = "CPU not found",
                        StatusCode = StatusCode.NotFound,
                        Data = false
                    };
                }

                await _CPURepository.DeleteAsync(CPU);

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

        public async Task<IBaseResponse<CPU>> CreateAsync(CPUViewModel viewModel)
        {
            try
            {
                var CPU = (CPU)viewModel;
                await _CPURepository.CreateAsync(CPU);

                return new BaseResponse<CPU>
                {
                    StatusCode = StatusCode.OK,
                    Data = CPU
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPU>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<CPU>> EditAsync(CPUViewModel viewModel)
        {
            try
            {
                var CPU = await _CPURepository.GetAll().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

                if (CPU == null)
                {
                    return new BaseResponse<CPU>
                    {
                        Description = "CPU not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                viewModel.CopyToModel(ref CPU);
                await _CPURepository.UpdateAsync(CPU);

                return new BaseResponse<CPU>
                {
                    Data = CPU,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPU>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
