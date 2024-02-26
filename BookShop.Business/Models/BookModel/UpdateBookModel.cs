using BookShop.Infrastructure.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Business.Models.GenreModel
{
    public class UpdateBookModel : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int NumberOfPage { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }
    }
}
