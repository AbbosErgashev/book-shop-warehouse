using BookShop.Business.Models.AuthorModel;
using BookShop.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Business.IServices
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAllAuthors();
        Task<Author> GetAuthor(int id);
        Task<ReadAuthorModel> CreateAuthor(CreateAuthorModel model);
        Task UpdateAuthor(UpdateAuthorModel model);
        Task DeleteAuthor(int id);
    }
}
