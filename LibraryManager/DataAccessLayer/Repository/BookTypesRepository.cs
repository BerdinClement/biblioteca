using System.Collections.Generic;
using BusinessObjects.Entity;

public class BookTypesRepository
{
    private List<BookTypes> _bookTypes;

    public BookTypesRepository()
    {
        _bookTypes = new List<BookTypes>();
    }

    public IEnumerable<BookTypes> GetAll()
    {
        return _bookTypes;
    }


}
