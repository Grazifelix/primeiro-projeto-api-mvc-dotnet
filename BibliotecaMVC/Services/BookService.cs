using AutoMapper;
using BibliotecaMVC.Models;
using BibliotecaMVC.Services;

using BibliotecaMVC.Services.DTOs;
using static System.Reflection.Metadata.BlobBuilder;

namespace BibliotecaMVC.Service
{

    public class BookService : IBookService
    {

        private readonly HttpClient http;
        private readonly IMapper _mapper;

        public BookService (HttpClient http, IMapper mapper)
        {
            this.http = http;
            this._mapper = mapper;
        }

        // public BooksViewModel AddBook(BooksViewModel book);
        public async Task<List<BooksDTO>> GetAllBooks()
        {
            var resposta = await http.GetAsync("Book");

            var books = await resposta.Content.ReadFromJsonAsync<List<BooksDTO>>();

            return books ?? new List<BooksDTO>();
        }

    }
        
}
