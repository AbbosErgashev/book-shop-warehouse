using AutoMapper;
using BookShop.Business.Models.LanguageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Business.Helpers.Mappers
{
    public class BookLanguage : Profile
    {
        public BookLanguage()
        {
            CreateMap<BookLanguage, CreateLanguageModel>().ReverseMap();
            CreateMap<BookLanguage, ReadLanguageModel>().ReverseMap();
            CreateMap<BookLanguage, UpdateLanguageModel>().ReverseMap();
        }
    }
}
