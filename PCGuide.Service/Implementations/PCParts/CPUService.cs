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
using System.Text;
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
            var baseResponse = new BaseResponse<IEnumerable<CPU>>();

            try
            {
                var CPUs = _CPURepository.GetAll();

                if (!CPUs.Any())
                {
                    baseResponse.Description = "Found 0 elements";
                    baseResponse.StatusCode = StatusCode.OK;

                    return baseResponse;
                }

                baseResponse.Data = CPUs;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<CPU>>()
                {
                    Description = $"[GetAll] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<CPUViewModel>> GetByIdAsync(Guid id)
        {
            var baseResponse = new BaseResponse<CPUViewModel>();

            try
            {
                var CPU = await _CPURepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (CPU == null)
                {
                    baseResponse.Description = "CPU not found";
                    baseResponse.StatusCode = StatusCode.NotFound;

                    return baseResponse;
                }

                var data = new CPUViewModel()
                {
                    DateCreate = CPU.DateCreate,
                    Name = CPU.Name,
                    Company = CPU.Company,
                    Series = CPU.Series,
                    Socket = CPU.Socket,
                    TechnicalProcess = CPU.TechnicalProcess,
                    CoresCount = CPU.CoresCount,
                    ThreadsCount = CPU.ThreadsCount,
                    L1CacheCapacity = CPU.L1CacheCapacity,
                    L2CachCapacity = CPU.L2CachCapacity,
                    L3CacheCapacity = CPU.L3CacheCapacity,
                    HaveIntegratedGraphics = CPU.HaveIntegratedGraphics,
                    IntegratedGraphics = CPU.IntegratedGraphics,
                    ClockSpeed = CPU.ClockSpeed,
                    BoostClockSpeed = CPU.BoostClockSpeed,
                    TDP = CPU.TDP,
                    RAMThreads = CPU.RAMThreads,
                    RAMType = CPU.RAMType.ToString(),
                    ImageData = CPU.Image
                };

                baseResponse.Data = data;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPUViewModel>()
                {
                    Description = $"[GetByIdAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<bool>> DeleteAsync(Guid id)
        {
            var baseResponse = new BaseResponse<bool>();

            try
            {
                var CPU = await _CPURepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (CPU == null)
                {
                    baseResponse.Description = "CPU not found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    baseResponse.Data = false;

                    return baseResponse;
                }

                await _CPURepository.DeleteAsync(CPU);
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

        public async Task<IBaseResponse<CPU>> CreateAsync(CPUViewModel model)
        {
            var baseResponse = new BaseResponse<CPU>();

            try
            {
                var CPU = new CPU()
                {
                    Id = model.Id,
                    DateCreate = model.DateCreate,
                    Name = model.Name,
                    Company = model.Company,
                    Series = model.Series,
                    Socket = model.Socket,
                    TechnicalProcess = model.TechnicalProcess,
                    CoresCount = model.CoresCount,
                    ThreadsCount = model.ThreadsCount,
                    L1CacheCapacity = model.L1CacheCapacity,
                    L2CachCapacity = model.L2CachCapacity,
                    L3CacheCapacity = model.L3CacheCapacity,
                    HaveIntegratedGraphics = model.HaveIntegratedGraphics,
                    IntegratedGraphics = model.IntegratedGraphics,
                    ClockSpeed = model.ClockSpeed,
                    BoostClockSpeed = model.BoostClockSpeed,
                    TDP = model.TDP,
                    RAMThreads = model.RAMThreads,
                    RAMType = (MemoryType)Convert.ToInt32(model.RAMType),
                    Image = model.ImageData
                };

                await _CPURepository.CreateAsync(CPU);
                baseResponse.StatusCode = StatusCode.OK;
                baseResponse.Data = CPU;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPU>()
                {
                    Description = $"[CreateAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<CPU>> EditAsync(Guid id, CPUViewModel model)
        {
            var baseResponse = new BaseResponse<CPU>();

            try
            {
                var CPU = await _CPURepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (CPU == null)
                {
                    baseResponse.Description = "CPU not found";
                    baseResponse.StatusCode = StatusCode.NotFound;

                    return baseResponse;
                }

                CPU.Name = model.Name;
                CPU.Company = model.Company;
                CPU.Series = model.Series;
                CPU.Socket = model.Socket;
                CPU.TechnicalProcess = model.TechnicalProcess;
                CPU.CoresCount = model.CoresCount;
                CPU.ThreadsCount = model.ThreadsCount;
                CPU.L1CacheCapacity = model.L1CacheCapacity;
                CPU.L2CachCapacity = model.L2CachCapacity;
                CPU.L3CacheCapacity = model.L3CacheCapacity;
                CPU.HaveIntegratedGraphics = model.HaveIntegratedGraphics;
                CPU.IntegratedGraphics = model.IntegratedGraphics;
                CPU.ClockSpeed = model.ClockSpeed;
                CPU.BoostClockSpeed = model.BoostClockSpeed;
                CPU.TDP = model.TDP;
                CPU.RAMThreads = model.RAMThreads;
                CPU.RAMType = (MemoryType)Convert.ToInt32(model.RAMType);
                CPU.Image = model.ImageData;

                await _CPURepository.UpdateAsync(CPU);

                baseResponse.Data = CPU;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPU>()
                {
                    Description = $"[EditAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
