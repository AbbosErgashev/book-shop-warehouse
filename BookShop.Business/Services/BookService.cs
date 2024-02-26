using AutoMapper;
using BookShop.Business.IServices;
using BookShop.Business.Models.GenreModel;
using BookShop.Infrastructure.Entities;
using BookShop.Infrastructure.IRepository;

namespace BookShop.Business.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReadBookModel>> GetAllService()
        {
            var getAll = await _bookRepository.GetAllRepository();
            var mapped = _mapper.Map<IEnumerable<ReadBookModel>>(getAll);
            return mapped;
        }

        public async Task<ReadBookModel> GetByIdService(int id)
        {
            var getById = await _bookRepository.GetByIdRepository(id);
            var mapped = _mapper.Map<ReadBookModel>(getById);
            return mapped;
        }

        public async Task<ReadBookModel> CreateService(CreateBookModel create)
        {
            var createModel = _mapper.Map<Book>(create);
            await _bookRepository.CreateRepository(createModel);
            var mepped = _mapper.Map<ReadBookModel>(createModel);
            return mepped;
        }

        public async Task DeleteService(int id)
        {
            var getById = await _bookRepository.GetByIdRepository(id);
            await _bookRepository.DeleteRepository(getById);
            _mapper.Map<ReadBookModel>(getById);
            await _bookRepository.SaveChangesAsync();
        }

        public async Task UpdateService(int id, UpdateBookModel update)
        {
            var getById = await _bookRepository.GetByIdRepository(id);
            _mapper.Map(update, getById);
            await _bookRepository.UpdateRepository(getById);
            await _bookRepository.SaveChangesAsync();
        }
    }
}
