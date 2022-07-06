using PCGuide.Domain.Entities;
using PCGuide.Domain.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.DAL.Interfaces
{
    public interface IBaseRepository<T>
        where T : IIdentifiable
    {
        Task CreateAsync(T entity);

        IQueryable<T> GetAll();

        Task DeleteAsync(T entity);

        Task<T> UpdateAsync(T entity);
    }
}
