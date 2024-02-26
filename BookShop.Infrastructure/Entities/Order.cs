using BookShop.Infrastructure.Entities.Base;

namespace BookShop.Infrastructure.Entities
{
    public class Order : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int BuyCount { get; set; } = 0!;
    }
}
