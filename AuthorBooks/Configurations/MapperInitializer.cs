using AuthorBooks.Data;
using AuthorBooks.Models;
using AutoMapper;

namespace AuthorBooks.Configurations
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Author, CreateAuthorDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<Book, CreateBookDTO>().ReverseMap();
        }
    }
}
