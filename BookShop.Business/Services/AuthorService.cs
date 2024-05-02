using AutoMapper;
using BookShop.Business.IServices;
using BookShop.Business.Models.AuthorModel;
using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository;

namespace BookShop.Business.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _repository;

        public AuthorService(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ReadAuthorModel> CreateAuthor(CreateAuthorModel model)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                throw new ArgumentNullException(nameof(model.Name));
            }
            var create = _mapper.Map<Author>(model);
            await _repository.CreateRepository(create);
            var mapped = _mapper.Map<ReadAuthorModel>(create);
            return mapped;
        }

        public async Task DeleteAuthor(int id)
        {
            var entity = await _repository.GetByIdRepository(id);
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await _repository.DeleteRepository(id);
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            var getAll = await _repository.GetAllRepository();
            if (getAll is null)
            {
                throw new ArgumentNullException(nameof(getAll));
            }
            return getAll;
        }

        public async Task<Author> GetAuthor(int id)
        {
            var entity = await _repository.GetByIdRepository(id);
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            return entity;
        }

        public async Task UpdateAuthor(UpdateAuthorModel model)
        {
            var entity = await _repository.GetByIdRepository(model.Id);
            if (entity is null)
            {
                throw new ArgumentException("Author not found");
            }
            if (string.IsNullOrEmpty(model.Name))
            {
                throw new ArgumentNullException(nameof(model), "Author name cannot be null or empty");
            }
            await _repository.UpdateRepository(entity);
            _mapper.Map(model, entity);
            await _repository.SaveChangesAsync();
        }
    }
}
