namespace BookShop.Infrastructure.IRepository.Base
{
    public interface IBaseRepository
    {
        Task<bool> SaveChangesAsync();
    }
}
