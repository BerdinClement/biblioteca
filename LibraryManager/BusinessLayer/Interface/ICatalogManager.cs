using BusinessObjects.Entity;

namespace BusinessLayer.Catalog;

public interface ICatalogManager
{
    public IEnumerable<Book> DisplayCatalog();
    public IEnumerable<Book> DisplayCatalog(BookTypes type);
    public Book? FindBook(int id);
    public Book GetBestRatedBook();
    public IEnumerable<Book> DisplayFantasyBooks();
    public IEnumerable<Book> ShowCatalog();
    public Book GetBookById(int id);
    public IEnumerable<Book> GetBooksByType(string type);
    public Book GetTopRatedBook();
}