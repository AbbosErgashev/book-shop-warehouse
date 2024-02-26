using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.IRepository
{
    public interface IAuthorRepository : IBaseRepository
    {
        Task<ICollection<Author>> GetAllRepository();
        Task<Author> GetByIdRepository(int id);
        Task CreateRepository(Author genre);
        Task UpdateRepository(Author genre);
        Task DeleteRepository(int id);
    }
}
