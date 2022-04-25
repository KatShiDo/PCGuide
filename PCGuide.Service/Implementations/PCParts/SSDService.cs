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
    public class SSDService : IBaseService<SSD, SSDViewModel>
    {
        public Task<IBaseResponse<SSD>> CreateAsync(SSDViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<bool>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<SSD>> EditAsync(Guid id, SSDViewModel model)
        {
            throw new NotImplementedException();
        }

        public IBaseResponse<IEnumerable<SSD>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<SSDViewModel>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
