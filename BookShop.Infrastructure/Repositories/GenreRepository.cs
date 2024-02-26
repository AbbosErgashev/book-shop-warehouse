using BookShop.Infrastructure.Data;
using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Infrastructure.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly AppDataContext _context;
        public GenreRepository(AppDataContext context)
        {
            _context = context;
        }

        public async Task CreateRepository(Genre category)
        {
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRepository(int id)
        {
            var entity = await _context.FindAsync<Genre>(id);
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Genre>> GetAllRepository()
        {
            var getAll = await _context.Genres.ToListAsync();
            return getAll;
        }

        public async Task<Genre> GetByIdRepository(int id)
        {
            var getById = await _context.Genres.FirstOrDefaultAsync(x => x.Id == id);
            return getById;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task UpdateRepository(Genre genre)
        {
            await _context.SaveChangesAsync();
        }
    }
}
