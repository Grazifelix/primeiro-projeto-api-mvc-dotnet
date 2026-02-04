using AutoMapper;
using PrimeiroProjetoApiDotnet.Infrastructure;
using PrimeiroProjetoApiDotnet.Model;
using PrimeiroProjetoApiDotnet.Services;
using PrimeiroProjetoApiDotnet.Services.DTOs;

namespace PrimeiroProjetoApiDotnet.Service
{
    public class BookService:IBookService
    {
        private readonly IRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IRepository bookRepository, IMapper mapper) {

            _bookRepository = bookRepository;
            _mapper = mapper;
        
        }

        public List<BooksDTO> GetAllBooks()
        {
            var books = _bookRepository.getAllBooks();
            return _mapper.Map<List<BooksDTO>>(books);
        }

        public Books AddBook(Books book)
        {
            if (book == null || string.IsNullOrWhiteSpace(book.title))
                return null;

            // verifica se já existe livro com o mesmo título
            var existingBook = _bookRepository.searchBook(book.title);

            if (existingBook != null)
            {
                // livro já cadastrado
                return null;
            }

            // salva se não existir
            _bookRepository.save(book);
            return book;

        }

        public Books GetBookByTitle(string title)
        {
            var book = _bookRepository.searchBook(title);
            return _mapper.Map<Books>(book);
        }

    }
}
