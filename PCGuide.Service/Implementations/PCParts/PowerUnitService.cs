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
    public class PowerUnitService : IBaseService<PowerUnit, PowerUnitViewModel>
    {
        public Task<IBaseResponse<PowerUnit>> CreateAsync(PowerUnitViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<bool>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<PowerUnit>> EditAsync(Guid id, PowerUnitViewModel model)
        {
            throw new NotImplementedException();
        }

        public IBaseResponse<IEnumerable<PowerUnit>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<PowerUnitViewModel>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
