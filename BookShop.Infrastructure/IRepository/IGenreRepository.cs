using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository.Base;

namespace BookShop.Infrastructure.IRepository
{
    public interface IGenreRepository : IBaseRepository
    {
        Task<ICollection<Genre>> GetAllRepository();
        Task<Genre> GetByIdRepository(int id);
        Task CreateRepository(Genre genre);
        Task DeleteRepository(int id);
        Task UpdateRepository(Genre genre);
    }
}
