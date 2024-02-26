using BookShop.Infrastructure.Data;
using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly AppDataContext _context;
        public LanguageRepository(AppDataContext context)
        {
            _context = context;
        }
        public async Task CreateRepository(Language language)
        {
            await _context.AddAsync(language);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRepository(int id)
        {
            var entity = await _context.FindAsync<Language>(id);
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Language>> GetAllRepository()
        {
            var getAll = await _context.Languages.ToListAsync();
            return getAll;
        }

        public async Task<Language> GetByIdRepository(int id)
        {
            var entity = await _context.Languages.FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task UpdateRepository(Language language)
        {
            await _context.SaveChangesAsync();
        }
    }
}
