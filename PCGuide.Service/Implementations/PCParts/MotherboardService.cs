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
    public class MotherboardService : IBaseService<Motherboard, MotherboardViewModel>
    {
        private readonly IBaseRepository<Motherboard> _motherboardRepository;

        public MotherboardService(IBaseRepository<Motherboard> motherboardRepository)
        {
            _motherboardRepository = motherboardRepository;
        }

        public IBaseResponse<IEnumerable<Motherboard>> GetAll()
        {
            try
            {
                var motherboards = _motherboardRepository.GetAll();

                if (!motherboards.Any())
                {
                    return new BaseResponse<IEnumerable<Motherboard>>
                    {
                        Description = "Found 0 elements",
                        StatusCode = StatusCode.OK,
                        Data = motherboards
                    };
                }

                return new BaseResponse<IEnumerable<Motherboard>>
                {
                    Data = motherboards,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Motherboard>>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<MotherboardViewModel>> GetByIdAsync(Guid id)
        {
            try
            {
                var motherboard = await _motherboardRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (motherboard == null)
                {
                    return new BaseResponse<MotherboardViewModel>
                    {
                        Description = "Motherboard not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<MotherboardViewModel>
                {
                    Data = (MotherboardViewModel)motherboard,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<MotherboardViewModel>
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
                var motherboard = await _motherboardRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (motherboard == null)
                {
                    return new BaseResponse<bool>
                    {
                        Description = "Motherboard not found",
                        StatusCode = StatusCode.NotFound,
                        Data = false
                    };
                }

                await _motherboardRepository.DeleteAsync(motherboard);

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

        public async Task<IBaseResponse<Motherboard>> CreateAsync(MotherboardViewModel viewModel)
        {
            try
            {
                var motherboard = (Motherboard)viewModel;
                await _motherboardRepository.CreateAsync(motherboard);

                return new BaseResponse<Motherboard>
                {
                    StatusCode = StatusCode.OK,
                    Data = motherboard
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Motherboard>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<Motherboard>> EditAsync(MotherboardViewModel viewModel)
        {
            try
            {
                var motherboard = await _motherboardRepository.GetAll().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

                if (motherboard == null)
                {
                    return new BaseResponse<Motherboard>
                    {
                        Description = "Motherboard not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                viewModel.CopyToModel(ref motherboard);
                await _motherboardRepository.UpdateAsync(motherboard);

                return new BaseResponse<Motherboard>
                {
                    Data = motherboard,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Motherboard>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<Motherboard>> GetModelByIdAsync(Guid id)
        {
            try
            {
                var motherboard = await _motherboardRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (motherboard == null)
                {
                    return new BaseResponse<Motherboard>
                    {
                        Description = "Motherboard not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<Motherboard>
                {
                    Data = motherboard,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Motherboard>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
