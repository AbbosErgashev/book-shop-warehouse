using BookShop.Infrastructure.Entities.Base;

namespace BookShop.Infrastructure.Entities
{
    public class Warehouse : BaseEntity
    {
        public int BookId { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public Book Book { get; set; } = null!;
    }
}
