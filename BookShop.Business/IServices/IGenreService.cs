using BookShop.Business.Models.GenreModel;

namespace BookShop.Business.IServices
{
    public interface IGenreService
    {
        Task<IEnumerable<ReadGenreModel>> GetAllGenres();
        Task<ReadGenreModel> GetByIdGenre(int id);
        Task<ReadGenreModel> CreateGenre(CreateGenreModel model);
        Task UpdateGenre(UpdateGenreModel model);
        Task DeleteGenre(int id);
    }
}
