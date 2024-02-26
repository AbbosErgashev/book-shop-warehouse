using BookShop.Business.Models.GenreModel;

namespace BookShop.Business.IServices
{
    public interface IBookService
    {
        Task<IEnumerable<ReadBookModel>> GetAllService();
        Task<ReadBookModel> GetByIdService(int id);
        Task<ReadBookModel> CreateService(CreateBookModel book);
        Task UpdateService(int id, UpdateBookModel book);
        Task DeleteService(int id);
    }
}
