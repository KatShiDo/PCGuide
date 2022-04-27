using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.DAL.Repositories
{
    public class FrameRepository : IBaseRepository<Frame>
    {
        private readonly ApplicationDbContext _context;

        public FrameRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Frame entity)
        {
            await _context.Frames.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Frame> GetAll()
        {
            return _context.Frames;
        }

        public async Task DeleteAsync(Frame entity)
        {
            _context.Frames.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Frame> UpdateAsync(Frame entity)
        {
            _context.Frames.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
