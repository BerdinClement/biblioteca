using BusinessObjects.Entity;

namespace BusinessLayer.Catalog;

public class CatalogManager
{
    private readonly BookRepository _bookRepository = new BookRepository();
    
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
}