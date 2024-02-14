using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository.Base;

namespace BookShop.Infrastructure.IRepository
{
    public interface IOrderRepository : IBaseRepository
    {
        Task<ICollection<Order>> GetAllRepository();
        Task<Order> GetByIdRepository(int id);
        Task CreateRepository(Order order);
        Task UpdateRepository(Order order);
        Task DeleteRepository(int id);
    }
}
