using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository.Base;

namespace BookShop.Infrastructure.IRepository
{
    public interface IBookRepository : IBaseRepository
    {
        Task<ICollection<Book>> GetAllRepository();
        Task<Book> GetByIdRepository(int id);
        Task CreateRepository(Book book);
        Task DeleteRepository(Book book);
        Task UpdateRepository(Book book);
    }
}
