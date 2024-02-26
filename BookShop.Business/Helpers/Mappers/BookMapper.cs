using AutoMapper;
using BookShop.Business.Models.GenreModel;
using BookShop.Infrastructure.Entities;

namespace BookShop.Business.Helpers.Mappers
{
    public class BookMapper : Profile
    {
        public BookMapper()
        {
            CreateMap<Book, CreateBookModel>().ReverseMap();
            CreateMap<Book, ReadBookModel>().ReverseMap();
            CreateMap<Book, UpdateBookModel>().ReverseMap();
        }
    }
}
