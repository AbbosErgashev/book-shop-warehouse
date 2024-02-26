using BookShop.Business.Models.LanguageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Business.IServices
{
    public interface ILanguageService
    {
        Task<IEnumerable<ReadLanguageModel>> GetAllLanguage();
        Task<ReadLanguageModel> GetByIdLanguage(int id);
        Task<ReadLanguageModel> CreateLanguage(CreateLanguageModel model);
        Task UpdateLanguage(UpdateLanguageModel model);
        Task DeleteLanguage(int id);
    }
}
