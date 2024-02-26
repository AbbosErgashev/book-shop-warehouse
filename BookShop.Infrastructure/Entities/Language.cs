using BookShop.Infrastructure.Entities.Base;

namespace BookShop.Infrastructure.Entities
{
    public class Language : BaseEntity
    {
        public string BookLanguage { get; set; } = null!;
    }
}
