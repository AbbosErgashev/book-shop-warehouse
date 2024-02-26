using BookShop.Infrastructure.Data;
using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.IRepository
{
    public interface ILanguageRepository : IBaseRepository
    {
        Task<ICollection<Language>> GetAllRepository();
        Task<Language> GetByIdRepository(int id);
        Task CreateRepository(Language language);
        Task UpdateRepository(Language language);
        Task DeleteRepository(int id);
    }
}
