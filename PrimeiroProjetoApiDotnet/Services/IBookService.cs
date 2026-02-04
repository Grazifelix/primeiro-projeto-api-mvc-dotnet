using PrimeiroProjetoApiDotnet.Model;
using PrimeiroProjetoApiDotnet.Services.DTOs;

namespace PrimeiroProjetoApiDotnet.Services
{
    public interface IBookService
    {
        public Books AddBook(Books book);
        public List<BooksDTO> GetAllBooks();
        public Books GetBookByTitle(string title);

    }
}
