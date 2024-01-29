using System.Collections.Generic;
using BusinessObjects.Entity;


public class BookRepository
{
    private List<Book> books;

    public BookRepository()
    {  
        books = new List<Book>();
    }

    public IEnumerable<Book> GetAll()
    {
        return books;
    }

    public Book? Get(int id)
    {
        return books.Find(book => book.Id == id);
    }
}
