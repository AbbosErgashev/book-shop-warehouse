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
    public class AuthorRepository : IAuthorRepository
    {
        private readonly AppDataContext _context;

        public AuthorRepository(AppDataContext context)
        {
            _context = context;
        }

        public async Task CreateRepository(Author genre)
        {
            await _context.AddAsync(genre);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRepository(int id)
        {
            var entity = await _context.FindAsync<Author>(id);
            if(entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Author>> GetAllRepository()
        {
            var getAll = await _context.Authors.ToListAsync();
            return getAll;
        }

        public async Task<Author> GetByIdRepository(int id)
        {
            var getById = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);
            return getById;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task UpdateRepository(Author genre)
        {
            await _context.SaveChangesAsync();
        }
    }
}
