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
    public class SSDService : IBaseService<SSD, SSDViewModel>
    {
        private readonly IBaseRepository<SSD> _SSDRepository;

        public SSDService(IBaseRepository<SSD> SSDRepository)
        {
            _SSDRepository = SSDRepository;
        }

        public IBaseResponse<IEnumerable<SSD>> GetAll()
        {
            try
            {
                var CPUs = _SSDRepository.GetAll();

                if (!CPUs.Any())
                {
                    return new BaseResponse<IEnumerable<SSD>>
                    {
                        Description = "Found 0 elements",
                        StatusCode = StatusCode.OK,
                        Data = CPUs
                    };
                }

                return new BaseResponse<IEnumerable<SSD>>
                {
                    Data = CPUs,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<SSD>>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<SSDViewModel>> GetByIdAsync(Guid id)
        {
            try
            {
                var SSD = await _SSDRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (SSD == null)
                {
                    return new BaseResponse<SSDViewModel>
                    {
                        Description = "SSD not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<SSDViewModel>
                {
                    Data = (SSDViewModel)SSD,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<SSDViewModel>
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
                var SSD = await _SSDRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (SSD == null)
                {
                    return new BaseResponse<bool>
                    {
                        Description = "SSD not found",
                        StatusCode = StatusCode.NotFound,
                        Data = false
                    };
                }

                await _SSDRepository.DeleteAsync(SSD);

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

        public async Task<IBaseResponse<SSD>> CreateAsync(SSDViewModel viewModel)
        {
            try
            {
                var SSD = (SSD)viewModel;
                await _SSDRepository.CreateAsync(SSD);

                return new BaseResponse<SSD>
                {
                    StatusCode = StatusCode.OK,
                    Data = SSD
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<SSD>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<SSD>> EditAsync(SSDViewModel viewModel)
        {
            try
            {
                var SSD = await _SSDRepository.GetAll().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

                if (SSD == null)
                {
                    return new BaseResponse<SSD>
                    {
                        Description = "SSD not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                viewModel.CopyToModel(ref SSD);
                await _SSDRepository.UpdateAsync(SSD);

                return new BaseResponse<SSD>
                {
                    Data = SSD,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<SSD>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<SSD>> GetModelByIdAsync(Guid id)
        {
            try
            {
                var SSD = await _SSDRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (SSD == null)
                {
                    return new BaseResponse<SSD>
                    {
                        Description = "SSD not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<SSD>
                {
                    Data = SSD,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<SSD>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
