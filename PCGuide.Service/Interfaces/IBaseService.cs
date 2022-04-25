using PCGuide.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Service.Interfaces
{
    public interface IBaseService<T, TViewModel>
    {
        IBaseResponse<IEnumerable<T>> GetAll();

        Task<IBaseResponse<TViewModel>> GetByIdAsync(Guid id);

        Task<IBaseResponse<T>> CreateAsync(TViewModel model);

        Task<IBaseResponse<bool>> DeleteAsync(Guid id);

        Task<IBaseResponse<T>> EditAsync(Guid id, TViewModel model);
    }
}
