using PCGuide.Domain.Entities;
using PCGuide.Domain.Response;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCGuide.Service.Implementations
{
    public class HardDriveService : IBaseService<HardDrive, HardDriveViewModel>
    {
        public Task<IBaseResponse<HardDrive>> CreateAsync(HardDriveViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<bool>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<HardDrive>> EditAsync(HardDriveViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public IBaseResponse<IEnumerable<HardDrive>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<HardDriveViewModel>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
