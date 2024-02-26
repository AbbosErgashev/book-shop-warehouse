using BookShop.Infrastructure.Data;
using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDataContext _context;

        public BookRepository(AppDataContext context)
        {
            _context = context;
        }
        public async Task CreateRepository(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRepository(Book book)
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Book>> GetAllRepository()
        {
            var getAll = await _context.Books.ToListAsync();
            return getAll;
        }

        public async Task<Book> GetByIdRepository(int id)
        {
            var getById = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
            return getById;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public Task UpdateRepository(Book book)
        {
            return _context.SaveChangesAsync();
        }
    }
}
