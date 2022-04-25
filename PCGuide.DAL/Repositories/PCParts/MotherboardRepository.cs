using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.DAL.Repositories
{
    public class MotherboardRepository : IBaseRepository<Motherboard>
    {
        private readonly ApplicationDbContext _context;

        public MotherboardRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Motherboard entity)
        {
            await _context.Motherboards.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Motherboard> GetAll()
        {
            return _context.Motherboards;
        }

        public async Task DeleteAsync(Motherboard entity)
        {
            _context.Motherboards.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Motherboard> UpdateAsync(Motherboard entity)
        {
            _context.Motherboards.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
