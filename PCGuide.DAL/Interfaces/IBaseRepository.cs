using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task CreateAsync(T entity);

        IQueryable<T> GetAll();

        Task DeleteAsync(T entity);

        Task<T> UpdateAsync(T entity);
    }
}
