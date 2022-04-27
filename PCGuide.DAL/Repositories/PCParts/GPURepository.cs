using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.DAL.Repositories
{
    public class GPURepository : IBaseRepository<GPU>
    {
        private readonly ApplicationDbContext _context;

        public GPURepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(GPU entity)
        {
            await _context.GPUs.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<GPU> GetAll()
        {
            return _context.GPUs;
        }

        public async Task DeleteAsync(GPU entity)
        {
            _context.GPUs.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<GPU> UpdateAsync(GPU entity)
        {
            _context.GPUs.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
