using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.DAL.Repositories
{
    public class CPUCoolerRepository : IBaseRepository<CPUCooler>
    {
        private readonly ApplicationDbContext _context;

        public CPUCoolerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CPUCooler entity)
        {
            await _context.CPUCoolers.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<CPUCooler> GetAll()
        {
            return _context.CPUCoolers;
        }

        public async Task DeleteAsync(CPUCooler entity)
        {
            _context.CPUCoolers.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<CPUCooler> UpdateAsync(CPUCooler entity)
        {
            _context.CPUCoolers.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
