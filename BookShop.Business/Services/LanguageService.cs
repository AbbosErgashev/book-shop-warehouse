using AutoMapper;
using BookShop.Business.IServices;
using BookShop.Business.Models.LanguageModel;
using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository;

namespace BookShop.Business.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly IMapper _mapper;
        private readonly ILanguageRepository _repository;

        public LanguageService(IMapper mapper, ILanguageRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<ReadLanguageModel> CreateLanguage(CreateLanguageModel model)
        {
            if (string.IsNullOrEmpty(model.Language))
            {
                throw new ArgumentNullException(nameof(model));
            }
            var create = _mapper.Map<Language>(model);
            await _repository.CreateRepository(create);
            var mapped = _mapper.Map<ReadLanguageModel>(create);
            return mapped;
        }

        public async Task DeleteLanguage(int id)
        {
            var getById = await _repository.GetByIdRepository(id);
            if (getById is null)
            {
                throw new ArgumentNullException(nameof(getById));
            }
            await _repository.DeleteRepository(id);
        }

        public async Task<IEnumerable<ReadLanguageModel>> GetAllLanguage()
        {
            var getAll = await _repository.GetAllRepository();
            var mapped = _mapper.Map<IEnumerable<ReadLanguageModel>>(getAll);
            return mapped;
        }

        public async Task<ReadLanguageModel> GetByIdLanguage(int id)
        {
            var getById = await _repository.GetByIdRepository(id);
            var mapped = _mapper.Map<ReadLanguageModel>(getById);
            return mapped;

        }

        public async Task UpdateLanguage(UpdateLanguageModel model)
        {
            var entity = await _repository.GetByIdRepository(model.Id);
            if (entity is null)
            {
                throw new ArgumentException("Language not found");
            }
            if (string.IsNullOrEmpty(model.BookLanguage))
            {
                throw new ArgumentNullException(nameof(model));
            }
            await _repository.UpdateRepository(entity);
            _mapper.Map(model, entity);
            await _repository.SaveChangesAsync();
        }
    }
}
