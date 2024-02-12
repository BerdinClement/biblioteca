using BusinessObjects.Entity;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace LibraryManager.Hosting.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ICatalogService _catalogService;

        public BookController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet]
        public IEnumerable<Book> GetAll()
        {
            return _catalogService.ShowCatalog();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _catalogService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpGet("books/{type}")]
        public IEnumerable<Book> GetByType(string type)
        {
            return _catalogService.GetBooksByType(type);
        }

        [HttpGet("book/topRatedBook")]
        public IActionResult GetTopRatedBook()
        {
            var topRatedBook = _catalogService.GetTopRatedBook();
            if (topRatedBook == null)
            {
                return NotFound();
            }
            return Ok(topRatedBook);
        }
    }
}
