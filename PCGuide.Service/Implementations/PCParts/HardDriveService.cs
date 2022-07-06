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
    public class HardDriveService : IBaseService<HardDrive, HardDriveViewModel>
    {
        private readonly IBaseRepository<HardDrive> _hardDriveRepository;

        public HardDriveService(IBaseRepository<HardDrive> hardDriveRepository)
        {
            _hardDriveRepository = hardDriveRepository;
        }

        public IBaseResponse<IEnumerable<HardDrive>> GetAll()
        {
            try
            {
                var hardDrives = _hardDriveRepository.GetAll();

                if (!hardDrives.Any())
                {
                    return new BaseResponse<IEnumerable<HardDrive>>
                    {
                        Description = "Found 0 elements",
                        StatusCode = StatusCode.OK,
                        Data = hardDrives
                    };
                }

                return new BaseResponse<IEnumerable<HardDrive>>
                {
                    Data = hardDrives,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<HardDrive>>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<HardDriveViewModel>> GetByIdAsync(Guid id)
        {
            try
            {
                var hardDrive = await _hardDriveRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (hardDrive == null)
                {
                    return new BaseResponse<HardDriveViewModel>
                    {
                        Description = "HardDrive not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<HardDriveViewModel>
                {
                    Data = (HardDriveViewModel)hardDrive,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<HardDriveViewModel>
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
                var hardDrive = await _hardDriveRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (hardDrive == null)
                {
                    return new BaseResponse<bool>
                    {
                        Description = "HardDrive not found",
                        StatusCode = StatusCode.NotFound,
                        Data = false
                    };
                }

                await _hardDriveRepository.DeleteAsync(hardDrive);

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

        public async Task<IBaseResponse<HardDrive>> CreateAsync(HardDriveViewModel viewModel)
        {
            try
            {
                var hardDrive = (HardDrive)viewModel;
                await _hardDriveRepository.CreateAsync(hardDrive);

                return new BaseResponse<HardDrive>
                {
                    StatusCode = StatusCode.OK,
                    Data = hardDrive
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<HardDrive>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<HardDrive>> EditAsync(HardDriveViewModel viewModel)
        {
            try
            {
                var hardDrive = await _hardDriveRepository.GetAll().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

                if (hardDrive == null)
                {
                    return new BaseResponse<HardDrive>
                    {
                        Description = "HardDrive not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                viewModel.CopyToModel(ref hardDrive);
                await _hardDriveRepository.UpdateAsync(hardDrive);

                return new BaseResponse<HardDrive>
                {
                    Data = hardDrive,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<HardDrive>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<HardDrive>> GetModelByIdAsync(Guid id)
        {
            try
            {
                var hardDrive = await _hardDriveRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (hardDrive == null)
                {
                    return new BaseResponse<HardDrive>
                    {
                        Description = "HardDrive not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<HardDrive>
                {
                    Data = hardDrive,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<HardDrive>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
