using BookShop.Infrastructure.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Infrastructure.Entities
{
    public class Book : BaseEntity
    {
        public int CategoryId { get; set; }
        public string ISBN { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string? AuthorName { get; set; }
        public string? Description { get; set; }
        public Category Category { get; set; } = null!;
    }
}
