using Microsoft.EntityFrameworkCore;
using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.DAL.Repositories
{
    public class NewsRepository : IBaseRepository<News>
    {
        private readonly ApplicationDbContext _context;

        public NewsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(News entity)
        {
            await _context.News.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<News> GetAll()
        {
            return _context.News;
        }

        public async Task DeleteAsync(News entity)
        {
            _context.News.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<News> UpdateAsync(News entity)
        {
            _context.News.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
