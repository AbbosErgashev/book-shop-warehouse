using BookShop.Infrastructure.Entities.Base;

namespace BookShop.Business.Models.GenreModel
{
    public class UpdateGenreModel : BaseEntity
    {
        public string Name { get; set; } = null!;
    }
}
