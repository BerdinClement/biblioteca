using BusinessObjects.Entity;
[Obsolete]
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
