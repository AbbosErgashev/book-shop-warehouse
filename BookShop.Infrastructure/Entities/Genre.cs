using BookShop.Infrastructure.Entities.Base;

namespace BookShop.Infrastructure.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; } = null!;
    }
}
