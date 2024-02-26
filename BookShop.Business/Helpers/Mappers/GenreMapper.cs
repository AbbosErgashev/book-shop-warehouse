using AutoMapper;
using BookShop.Business.Models.GenreModel;
using BookShop.Infrastructure.Entities;

namespace BookShop.Business.Helpers.Mappers
{
    public class GenreMapper : Profile
    {
        public GenreMapper()
        {
            CreateMap<Genre, CreateGenreModel>().ReverseMap();
            CreateMap<Genre, ReadGenreModel>().ReverseMap();
            CreateMap<Genre, UpdateGenreModel>().ReverseMap();
        }
    }
}
