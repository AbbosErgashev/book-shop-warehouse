using System.ComponentModel.DataAnnotations;

namespace BookShop.Infrastructure.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
