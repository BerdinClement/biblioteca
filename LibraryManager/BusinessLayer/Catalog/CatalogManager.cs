using BusinessObjects.Entity;
using DataAccessLayer.Repository;

namespace BusinessLayer.Catalog;

public class CatalogManager : ICatalogManager
{
    private readonly IGenericRepository<Book> _bookRepository;
    
    public CatalogManager(IGenericRepository<Book> bookRepository)
    {
        _bookRepository = bookRepository;
    }
    
    public IEnumerable<Book> DisplayCatalog()
    {
        return _bookRepository.GetAll();
    }

    public IEnumerable<Book> DisplayCatalog(BookTypes type)
    {
        return _bookRepository.GetAll().ToList().FindAll(book => book.Type == type);
    }

    public Book? FindBook(int id)
    {
        return _bookRepository.Get(id);
    }
    
    public Book GetBestRatedBook()
    {
        return _bookRepository.GetAll().OrderByDescending(book => book.Rate).First();
    }
    
    public IEnumerable<Book> DisplayFantasyBooks()
    {
        return _bookRepository.GetAll().Where(book => book.Type == BookTypes.Fantasy);
    }

    public IEnumerable<Book> ShowCatalog()
    {
        throw new NotImplementedException();
    }

    public Book GetBookById(int id)
    {
        return _bookRepository.Get(id);
    }

    public IEnumerable<Book> GetBooksByType(string type)
    {
        return _bookRepository.GetAll().Where(book => book.Type == BookTypes.Fantasy);
    }

    public Book GetTopRatedBook()
    {
        throw new NotImplementedException();
    }
}