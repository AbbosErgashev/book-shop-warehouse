using BookShop.Infrastructure.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Infrastructure.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int NumberOfPage { get; set; }
        public int BookCount { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public int GenreId { get; set; }
        public int PublisherId { get; set; }
        public int LanguageId { get; set; }
        public Order Order { get; set; } = null!;
        public Genre Genre { get; set; } = null!;
        public Publisher Publisher { get; set; } = null!;
        public Language Language { get; set; } = null!;
    }
}
