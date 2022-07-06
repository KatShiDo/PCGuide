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
    public class PowerUnitService : IBaseService<PowerUnit, PowerUnitViewModel>
    {
        private readonly IBaseRepository<PowerUnit> _powerUnitRepository;

        public PowerUnitService(IBaseRepository<PowerUnit> powerUnitRepository)
        {
            _powerUnitRepository = powerUnitRepository;
        }

        public IBaseResponse<IEnumerable<PowerUnit>> GetAll()
        {
            try
            {
                var powerUnits = _powerUnitRepository.GetAll();

                if (!powerUnits.Any())
                {
                    return new BaseResponse<IEnumerable<PowerUnit>>
                    {
                        Description = "Found 0 elements",
                        StatusCode = StatusCode.OK,
                        Data = powerUnits
                    };
                }

                return new BaseResponse<IEnumerable<PowerUnit>>
                {
                    Data = powerUnits,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<PowerUnit>>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<PowerUnitViewModel>> GetByIdAsync(Guid id)
        {
            try
            {
                var powerUnit = await _powerUnitRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (powerUnit == null)
                {
                    return new BaseResponse<PowerUnitViewModel>
                    {
                        Description = "PowerUnit not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<PowerUnitViewModel>
                {
                    Data = (PowerUnitViewModel)powerUnit,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<PowerUnitViewModel>
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
                var powerUnit = await _powerUnitRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (powerUnit == null)
                {
                    return new BaseResponse<bool>
                    {
                        Description = "PowerUnit not found",
                        StatusCode = StatusCode.NotFound,
                        Data = false
                    };
                }

                await _powerUnitRepository.DeleteAsync(powerUnit);

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

        public async Task<IBaseResponse<PowerUnit>> CreateAsync(PowerUnitViewModel viewModel)
        {
            try
            {
                var powerUnit = (PowerUnit)viewModel;
                await _powerUnitRepository.CreateAsync(powerUnit);

                return new BaseResponse<PowerUnit>
                {
                    StatusCode = StatusCode.OK,
                    Data = powerUnit
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<PowerUnit>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<PowerUnit>> EditAsync(PowerUnitViewModel viewModel)
        {
            try
            {
                var powerUnit = await _powerUnitRepository.GetAll().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

                if (powerUnit == null)
                {
                    return new BaseResponse<PowerUnit>
                    {
                        Description = "PowerUnit not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                viewModel.CopyToModel(ref powerUnit);
                await _powerUnitRepository.UpdateAsync(powerUnit);

                return new BaseResponse<PowerUnit>
                {
                    Data = powerUnit,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<PowerUnit>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<PowerUnit>> GetModelByIdAsync(Guid id)
        {
            try
            {
                var powerUnit = await _powerUnitRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (powerUnit == null)
                {
                    return new BaseResponse<PowerUnit>
                    {
                        Description = "PowerUnit not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<PowerUnit>
                {
                    Data = powerUnit,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<PowerUnit>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
