using BusinessObjects.Entity;

namespace Services.Services;

public interface ICatalogService
{
    public IEnumerable<Book> ShowCatalog();
    public IEnumerable<Book> ShowCatalog(BookTypes type);
    public Book? FindBook(int id);
    public Book GetBestRatedBook();
    public IEnumerable<Book> ShowFantasyBooks();
}