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
    public class GPUService : IBaseService<GPU, GPUViewModel>
    {
        public Task<IBaseResponse<GPU>> CreateAsync(GPUViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<bool>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<GPU>> EditAsync(Guid id, GPUViewModel model)
        {
            throw new NotImplementedException();
        }

        public IBaseResponse<IEnumerable<GPU>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<GPUViewModel>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
