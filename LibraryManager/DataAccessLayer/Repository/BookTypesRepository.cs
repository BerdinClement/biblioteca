using System.Collections.Generic;
using BusinessObjects.Entity;

public class BookTypesRepository
{
    private List<BookTypes> bookTypes;

    public BookTypesRepository()
    {
        bookTypes = new List<BookTypes>();
    }

    public IEnumerable<BookTypes> GetAll()
    {
        return bookTypes;
    }


}
