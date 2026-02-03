using BibliotecaMVC.Models;
using BibliotecaMVC.Services.DTOs;
using static System.Reflection.Metadata.BlobBuilder;

namespace BibliotecaMVC.Services
{
    public interface IBookService
    {
        // public BooksViewModel AddBook(BooksViewModel book);
       Task<List<BooksDTO>> GetAllBooks();

    }
}
