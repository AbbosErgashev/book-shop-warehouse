using AutoMapper;
using BookShop.Business.IServices;
using BookShop.Business.Models.GenreModel;
using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository;

namespace BookShop.Business.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _repository;
        private readonly IMapper _mapper;

        public GenreService(IGenreRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReadGenreModel>> GetAllGenres()
        {
            var getAll = await _repository.GetAllRepository();
            var mapped = _mapper.Map<IEnumerable<ReadGenreModel>>(getAll);
            return mapped;
        }

        public async Task<ReadGenreModel> GetByIdGenre(int id)
        {
            var getById = await _repository.GetByIdRepository(id);
            var mapped = _mapper.Map<ReadGenreModel>(getById);
            return mapped;
        }

        public async Task<ReadGenreModel> CreateGenre(CreateGenreModel create)
        {
            if (string.IsNullOrEmpty(create.Name))
            {
                throw new ArgumentNullException(nameof(create));
            }
            var createModel = _mapper.Map<Genre>(create);
            await _repository.CreateRepository(createModel);
            var mepped = _mapper.Map<ReadGenreModel>(createModel);
            return mepped;
        }

        public async Task UpdateGenre(UpdateGenreModel model)
        {
            var getById = await _repository.GetByIdRepository(model.Id);
            if (getById == null)
            {
                throw new ArgumentException("Genre not found");
            }
            if (string.IsNullOrEmpty(model.Name))
            {
                throw new ArgumentNullException(nameof(model), "Name cannot be null or empty");
            }
            await _repository.UpdateRepository(getById);
            _mapper.Map(model, getById);
            await _repository.SaveChangesAsync();
        }

        public async Task DeleteGenre(int id)
        {
            var getById = await _repository.GetByIdRepository(id);
            if(getById is null)
            {
                throw new ArgumentNullException(nameof(getById));
            }
            await _repository.DeleteRepository(id);
        }
    }
}
