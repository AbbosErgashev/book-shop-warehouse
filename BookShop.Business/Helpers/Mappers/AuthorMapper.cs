using AutoMapper;
using BookShop.Business.Models.AuthorModel;
using BookShop.Infrastructure.Entities;

namespace BookShop.Business.Helpers.Mappers
{
    public class AuthorMapper : Profile
    {
        public AuthorMapper() 
        {
            CreateMap<Author, CreateAuthorModel>().ReverseMap();
            CreateMap<Author, ReadAuthorModel>().ReverseMap();
            CreateMap<Author, UpdateAuthorModel>().ReverseMap();
        }
    }
}
