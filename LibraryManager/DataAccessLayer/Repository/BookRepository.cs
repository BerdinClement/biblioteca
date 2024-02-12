using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;


public class BookRepository : IGenericRepository<Book>
{
    private readonly LibraryContext _libraryContext;

    public BookRepository(LibraryContext libraryContext)
    {
        _libraryContext = libraryContext;
    }

    public IEnumerable<Book> GetAll()
    {
        return _libraryContext.Books.Include(x => x.Author).ToList();
    }

    public Book? Get(int id)
    {
        return _libraryContext.Books.ToList().Find(book => book.Id == id);
    }
}
