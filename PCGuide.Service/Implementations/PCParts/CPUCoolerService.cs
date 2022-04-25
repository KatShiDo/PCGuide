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
    public class CPUCoolerService : IBaseService<CPUCooler, CPUCoolerViewModel>
    {
        private readonly IBaseRepository<CPUCooler> _CPUCoolerRepository;

        public CPUCoolerService(IBaseRepository<CPUCooler> CPUCoolerRepository)
        {
            _CPUCoolerRepository = CPUCoolerRepository;
        }

        public async Task<IBaseResponse<CPUCooler>> CreateAsync(CPUCoolerViewModel model)
        {
            var baseResponse = new BaseResponse<CPUCooler>();

            try
            {
                var CPUCooler = new CPUCooler()
                {
                    Id = model.Id,
                    DateCreate = model.DateCreate,
                    Name = model.Name,
                    TDP = model.TDP,
                    Height = model.Height,
                    Image = model.ImageData
                };

                await _CPUCoolerRepository.CreateAsync(CPUCooler);
                baseResponse.StatusCode = StatusCode.OK;
                baseResponse.Data = CPUCooler;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPUCooler>()
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
                var CPUCooler = await _CPUCoolerRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (CPUCooler == null)
                {
                    baseResponse.Description = "CPUCooler not found";
                    baseResponse.StatusCode = StatusCode.NotFound;
                    baseResponse.Data = false;

                    return baseResponse;
                }

                await _CPUCoolerRepository.DeleteAsync(CPUCooler);
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

        public async Task<IBaseResponse<CPUCooler>> EditAsync(Guid id, CPUCoolerViewModel model)
        {
            var baseResponse = new BaseResponse<CPUCooler>();

            try
            {
                var CPUCooler = await _CPUCoolerRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (CPUCooler == null)
                {
                    baseResponse.Description = "CPUCooler not found";
                    baseResponse.StatusCode = StatusCode.NotFound;

                    return baseResponse;
                }

                CPUCooler.Name = model.Name;
                CPUCooler.TDP = model.TDP;
                CPUCooler.Height = model.Height;
                CPUCooler.Image = model.ImageData;

                await _CPUCoolerRepository.UpdateAsync(CPUCooler);

                baseResponse.Data = CPUCooler;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPUCooler>()
                {
                    Description = $"[EditAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public IBaseResponse<IEnumerable<CPUCooler>> GetAll()
        {
            var baseResponse = new BaseResponse<IEnumerable<CPUCooler>>();

            try
            {
                var CPUCoolers = _CPUCoolerRepository.GetAll();

                if (!CPUCoolers.Any())
                {
                    baseResponse.Description = "Found 0 elements";
                    baseResponse.StatusCode = StatusCode.OK;

                    return baseResponse;
                }

                baseResponse.Data = CPUCoolers;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<CPUCooler>>()
                {
                    Description = $"[GetAll] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<CPUCoolerViewModel>> GetByIdAsync(Guid id)
        {
            var baseResponse = new BaseResponse<CPUCoolerViewModel>();

            try
            {
                var CPUCooler = await _CPUCoolerRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (CPUCooler == null)
                {
                    baseResponse.Description = "CPUCooler not found";
                    baseResponse.StatusCode = StatusCode.NotFound;

                    return baseResponse;
                }

                var data = new CPUCoolerViewModel()
                {
                    DateCreate = CPUCooler.DateCreate,
                    Name = CPUCooler.Name,
                    TDP = CPUCooler.TDP,
                    Height = CPUCooler.Height,
                    ImageData = CPUCooler.Image
                };

                baseResponse.Data = data;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<CPUCoolerViewModel>()
                {
                    Description = $"[GetByIdAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
