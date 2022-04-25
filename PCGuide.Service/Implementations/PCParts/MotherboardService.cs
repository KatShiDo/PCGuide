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
    public class MotherboardService : IBaseService<Motherboard, MotherboardViewModel>
    {
        public Task<IBaseResponse<Motherboard>> CreateAsync(MotherboardViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<bool>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<Motherboard>> EditAsync(Guid id, MotherboardViewModel model)
        {
            throw new NotImplementedException();
        }

        public IBaseResponse<IEnumerable<Motherboard>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<MotherboardViewModel>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
