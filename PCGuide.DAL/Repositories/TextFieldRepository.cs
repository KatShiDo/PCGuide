using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.DAL.Repositories
{
    public class TextFieldRepository : IBaseRepository<TextField>
    {
        private readonly ApplicationDbContext _context;

        public TextFieldRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(TextField entity)
        {
            await _context.TextFields.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<TextField> GetAll()
        {
            return _context.TextFields;
        }

        public async Task DeleteAsync(TextField entity)
        {
            _context.TextFields.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<TextField> UpdateAsync(TextField entity)
        {
            _context.TextFields.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
