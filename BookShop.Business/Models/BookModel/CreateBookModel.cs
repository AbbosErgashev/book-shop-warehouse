using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Business.Models.CategoryModel
{
    public class CreateBookModel
    {
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public required string ISBN { get; set; }
        public required string Title { get; set; }
        public string? AuthorName { get; set; }
        public string? Description { get; set; }
    }
}
