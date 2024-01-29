using BusinessObjects.Entity;
using BusinessLayer.Catalog;

namespace Services.Services
{
    public class CatalogService
    {
        private readonly CatalogManager _catalogManager = new CatalogManager();

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
    }
}
