using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.DAL.Repositories
{
    public class CPURepository : IBaseRepository<CPU>
    {
        private readonly ApplicationDbContext _context;

        public CPURepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CPU entity)
        {
            await _context.CPUs.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<CPU> GetAll()
        {
            return _context.CPUs;
        }

        public async Task DeleteAsync(CPU entity)
        {
            _context.CPUs.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<CPU> UpdateAsync(CPU entity)
        {
            _context.CPUs.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
