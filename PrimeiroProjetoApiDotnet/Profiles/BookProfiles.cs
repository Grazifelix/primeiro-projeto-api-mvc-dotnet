using PrimeiroProjetoApiDotnet.Model;
using PrimeiroProjetoApiDotnet.Services.DTOs;
using AutoMapper;


namespace PrimeiroProjetoApiDotnet.Trasfer
{
    public class BookProfiles:Profile
    {
        public BookProfiles()
        {
            CreateMap<Books, BooksDTO>().ReverseMap();
        }

    }
}
