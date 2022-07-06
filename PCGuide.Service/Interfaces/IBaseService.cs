using PCGuide.Domain.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCGuide.Service.Interfaces
{
    public interface IBaseService<T, TViewModel>
    {
        IBaseResponse<IEnumerable<T>> GetAll();

        Task<IBaseResponse<TViewModel>> GetByIdAsync(Guid id);

        Task<IBaseResponse<T>> GetModelByIdAsync(Guid id);

        Task<IBaseResponse<T>> CreateAsync(TViewModel viewModel);

        Task<IBaseResponse<bool>> DeleteAsync(Guid id);

        Task<IBaseResponse<T>> EditAsync(TViewModel viewModel);
    }
}
