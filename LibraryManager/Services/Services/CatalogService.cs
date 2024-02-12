using BusinessObjects.Entity;
using BusinessLayer.Catalog;
using System.Linq;

namespace Services.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly ICatalogManager _catalogManager;
        
        public CatalogService(ICatalogManager catalogManager)
        {
            _catalogManager = catalogManager;
        }

        public IEnumerable<Book> ShowCatalog()
        {
            return _catalogManager.DisplayCatalog();
        }

        public IEnumerable<Book> ShowCatalog(BookTypes type)
        { 
            return _catalogManager.DisplayCatalog(type);
        }

        public Book? FindBook(int id)
        {
            return _catalogManager.FindBook(id);
        }
        
        public Book GetBestRatedBook()
        {
            return _catalogManager.GetBestRatedBook();
        }   
        
        public IEnumerable<Book> ShowFantasyBooks()
        {
            return _catalogManager.DisplayFantasyBooks();
        }

        public Book GetBookById(int id)
        {
            return _catalogManager.GetBookById(id);
        }

        public IEnumerable<Book> GetBooksByType(string type)
        {
            return _catalogManager.GetBooksByType(type);
        }

        public Book GetTopRatedBook()
        {
            return _catalogManager.GetTopRatedBook();
        }
    }
}
