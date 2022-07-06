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
    public class RAMService : IBaseService<RAM, RAMViewModel>
    {
        private readonly IBaseRepository<RAM> _RAMRepository;

        public RAMService(IBaseRepository<RAM> RAMRepository)
        {
            _RAMRepository = RAMRepository;
        }

        public IBaseResponse<IEnumerable<RAM>> GetAll()
        {
            try
            {
                var CPUs = _RAMRepository.GetAll();

                if (!CPUs.Any())
                {
                    return new BaseResponse<IEnumerable<RAM>>
                    {
                        Description = "Found 0 elements",
                        StatusCode = StatusCode.OK,
                        Data = CPUs
                    };
                }

                return new BaseResponse<IEnumerable<RAM>>
                {
                    Data = CPUs,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<RAM>>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<RAMViewModel>> GetByIdAsync(Guid id)
        {
            try
            {
                var RAM = await _RAMRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (RAM == null)
                {
                    return new BaseResponse<RAMViewModel>
                    {
                        Description = "RAM not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<RAMViewModel>
                {
                    Data = (RAMViewModel)RAM,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<RAMViewModel>
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
                var RAM = await _RAMRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (RAM == null)
                {
                    return new BaseResponse<bool>
                    {
                        Description = "RAM not found",
                        StatusCode = StatusCode.NotFound,
                        Data = false
                    };
                }

                await _RAMRepository.DeleteAsync(RAM);

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

        public async Task<IBaseResponse<RAM>> CreateAsync(RAMViewModel viewModel)
        {
            try
            {
                var RAM = (RAM)viewModel;
                await _RAMRepository.CreateAsync(RAM);

                return new BaseResponse<RAM>
                {
                    StatusCode = StatusCode.OK,
                    Data = RAM
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<RAM>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<RAM>> EditAsync(RAMViewModel viewModel)
        {
            try
            {
                var RAM = await _RAMRepository.GetAll().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

                if (RAM == null)
                {
                    return new BaseResponse<RAM>
                    {
                        Description = "RAM not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                viewModel.CopyToModel(ref RAM);
                await _RAMRepository.UpdateAsync(RAM);

                return new BaseResponse<RAM>
                {
                    Data = RAM,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<RAM>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<RAM>> GetModelByIdAsync(Guid id)
        {
            try
            {
                var RAM = await _RAMRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (RAM == null)
                {
                    return new BaseResponse<RAM>
                    {
                        Description = "RAM not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<RAM>
                {
                    Data = RAM,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<RAM>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
