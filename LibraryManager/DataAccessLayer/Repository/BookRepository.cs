using BusinessObjects.Entity;
using DataAccessLayer.Repository;


public class BookRepository : IGenericRepository<Book>
{
    private List<Book> _books;

    public BookRepository()
    {  
        _books = new List<Book>();
    }

    public BookRepository(List<Book> books)
    {
        _books = books;
    }

    public IEnumerable<Book> GetAll()
    {
        return _books;
    }

    public Book? Get(int id)
    {
        return _books.Find(book => book.Id == id);
    }
}
