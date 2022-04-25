using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.DAL.Repositories
{
    public class SSDRepository : IBaseRepository<SSD>
    {
        private readonly ApplicationDbContext _context;

        public SSDRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(SSD entity)
        {
            await _context.SSDs.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<SSD> GetAll()
        {
            return _context.SSDs;
        }

        public async Task DeleteAsync(SSD entity)
        {
            _context.SSDs.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<SSD> UpdateAsync(SSD entity)
        {
            _context.SSDs.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
