using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository.Base;

namespace BookShop.Infrastructure.IRepository
{
    public interface IWarehouseRepository : IBaseRepository
    {
        Task<ICollection<Warehouse>> GetAllRepository();
        Task<Warehouse> GetByIdRepository(int id);
        Task CreateRepository(Warehouse warehouse);
        Task DeleteRepository(Warehouse warehouse);
        Task UpdateRepository(Warehouse warehouse);
    }
}
