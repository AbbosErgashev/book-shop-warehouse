using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository.Base;

namespace BookShop.Infrastructure.IRepository
{
    public interface ICategoryRepository : IBaseRepository
    {
        Task<ICollection<Category>> GetAllRepository();
        Task<Category> GetByIdRepository(int id);
        Task CreateRepository(Category category);
        Task DeleteRepository(Category category);
        Task UpdateRepository(Category category);
    }
}
