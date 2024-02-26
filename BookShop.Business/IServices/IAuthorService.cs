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
        public Task<IEnumerable<Author>> GetAllAuthors();
        public Task<Author> GetAuthor(int id);
        public Task<ReadAuthorModel> CreateAuthor(CreateAuthorModel model);
        public Task UpdateAuthor(UpdateAuthorModel model);
        public Task DeleteAuthor(int id);
    }
}
