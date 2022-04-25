using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.DAL.Repositories
{
    public class RAMRepository : IBaseRepository<RAM>
    {
        private readonly ApplicationDbContext _context;

        public RAMRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(RAM entity)
        {
            await _context.RAM.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<RAM> GetAll()
        {
            return _context.RAM;
        }

        public async Task DeleteAsync(RAM entity)
        {
            _context.RAM.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<RAM> UpdateAsync(RAM entity)
        {
            _context.RAM.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
