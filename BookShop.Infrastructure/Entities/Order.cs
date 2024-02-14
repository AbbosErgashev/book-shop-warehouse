using BookShop.Infrastructure.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Infrastructure.Entities
{
    public class Order : BaseEntity
    {
        public int BookId { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public Book Book { get; set; } = null!;
    }
}
