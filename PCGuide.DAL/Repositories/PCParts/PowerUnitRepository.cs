using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.DAL.Repositories
{
    public class PowerUnitRepository : IBaseRepository<PowerUnit>
    {
        private readonly ApplicationDbContext _context;

        public PowerUnitRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(PowerUnit entity)
        {
            await _context.PowerUnits.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<PowerUnit> GetAll()
        {
            return _context.PowerUnits;
        }

        public async Task DeleteAsync(PowerUnit entity)
        {
            _context.PowerUnits.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<PowerUnit> UpdateAsync(PowerUnit entity)
        {
            _context.PowerUnits.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
