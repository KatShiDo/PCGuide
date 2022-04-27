using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.DAL.Repositories
{
    public class HardDriveRepository : IBaseRepository<HardDrive>
    {
        private readonly ApplicationDbContext _context;

        public HardDriveRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(HardDrive entity)
        {
            await _context.HardDrives.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<HardDrive> GetAll()
        {
            return _context.HardDrives;
        }

        public async Task DeleteAsync(HardDrive entity)
        {
            _context.HardDrives.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<HardDrive> UpdateAsync(HardDrive entity)
        {
            _context.HardDrives.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
