using AutoMapper;
using BibliotecaMVC.Models;
using BibliotecaMVC.Services;
using BibliotecaMVC.Services.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BibliotecaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService _service;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IBookService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            var booksDTO = await _service.GetAllBooks();
            var booksView = _mapper.Map<List<BooksViewModel>>(booksDTO);
            return View("Index", booksView);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
