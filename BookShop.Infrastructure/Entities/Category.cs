using BookShop.Infrastructure.Entities.Base;

namespace BookShop.Infrastructure.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = null!;
    }
}
