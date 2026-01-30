
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjetoApiDotnet.Model;
using PrimeiroProjetoApiDotnet.Services;
using PrimeiroProjetoApiDotnet.Services.DTOs;


namespace PrimeiroProjetoApiDotnet.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class BookController:ControllerBase
    {

        private readonly IBookService _bookService;

        public BookController (IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public List<BooksDTO> getAllBooks()
        {
            return _bookService.GetAllBooks(); 
        }
    }
}
