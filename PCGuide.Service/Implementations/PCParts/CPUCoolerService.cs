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
    public class CPUCoolerService : IBaseService<CPUCooler, CPUCoolerViewModel>
    {
        private readonly IBaseRepository<CPUCooler> _CPUCoolerRepository;

        public CPUCoolerService(IBaseRepository<CPUCooler> CPUCoolerRepository)
        {
            _CPUCoolerRepository = CPUCoolerRepository;
        }

        public async Task<IBaseResponse<CPUCooler>> CreateAsync(CPUCoolerViewModel viewModel)
        {
            try
            {
                var CPUCooler = (CPUCooler)viewModel;
                await _CPUCoolerRepository.CreateAsync(CPUCooler);

                return new BaseResponse<CPUCooler>
                {
                    StatusCode = StatusCode.OK,
                    Data = CPUCooler
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPUCooler>
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
                var CPUCooler = await _CPUCoolerRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (CPUCooler == null)
                {
                    return new BaseResponse<bool>
                    {
                        Description = "CPUCooler not found",
                        StatusCode = StatusCode.NotFound,
                        Data = false
                    };
                }

                await _CPUCoolerRepository.DeleteAsync(CPUCooler);

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

        public async Task<IBaseResponse<CPUCooler>> EditAsync(CPUCoolerViewModel viewModel)
        {
            try
            {
                var CPUCooler = await _CPUCoolerRepository.GetAll().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

                if (CPUCooler == null)
                {
                    return new BaseResponse<CPUCooler>
                    {
                        Description = "CPUCooler not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                viewModel.CopyToModel(ref CPUCooler);
                await _CPUCoolerRepository.UpdateAsync(CPUCooler);

                return new BaseResponse<CPUCooler>
                {
                    Data = CPUCooler,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPUCooler>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public IBaseResponse<IEnumerable<CPUCooler>> GetAll()
        {
            try
            {
                var CPUCoolers = _CPUCoolerRepository.GetAll();

                if (!CPUCoolers.Any())
                {
                    return new BaseResponse<IEnumerable<CPUCooler>>
                    {
                        Description = "Found 0 elements",
                        StatusCode = StatusCode.OK,
                        Data = CPUCoolers
                    };
                }

                return new BaseResponse<IEnumerable<CPUCooler>>
                {
                    Data = CPUCoolers,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<CPUCooler>>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<CPUCoolerViewModel>> GetByIdAsync(Guid id)
        {
            try
            {
                var CPUCooler = await _CPUCoolerRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (CPUCooler == null)
                {
                    return new BaseResponse<CPUCoolerViewModel>
                    {
                        Description = "CPUCooler not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<CPUCoolerViewModel>
                {
                    Data = (CPUCoolerViewModel)CPUCooler,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPUCoolerViewModel>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<CPUCooler>> GetModelByIdAsync(Guid id)
        {
            try
            {
                var CPUCooler = await _CPUCoolerRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (CPUCooler == null)
                {
                    return new BaseResponse<CPUCooler>
                    {
                        Description = "CPUCooler not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<CPUCooler>
                {
                    Data = CPUCooler,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPUCooler>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
