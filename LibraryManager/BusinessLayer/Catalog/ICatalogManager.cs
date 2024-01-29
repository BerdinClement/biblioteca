using BusinessObjects.Entity;

namespace BusinessLayer.Catalog;

public interface ICatalogManager
{
    public IEnumerable<Book> DisplayCatalog();
    public IEnumerable<Book> DisplayCatalog(BookTypes type);
    public Book? FindBook(int id);
    public Book GetBestRatedBook();
    public IEnumerable<Book> DisplayFantasyBooks();
}