using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.DAL.Repositories
{
    public class ITextFieldRepository : IBaseRepository<TextField>
    {
        private readonly ApplicationDbContext _context;

        public ITextFieldRepository(ApplicationDbContext context)
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
