using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repository;


public class LibraryRepository : IGenericRepository<Library>
{
    private readonly LibraryContext _libraryContext;

    public LibraryRepository(LibraryContext libraryContext)
    {
        _libraryContext = libraryContext;
    }

    public IEnumerable<Library> GetAll()
    {
        return _libraryContext.Libraries.ToList();
    }

    public Library? Get(int id)
    {
        return _libraryContext.Libraries.ToList().Find(library => library.Id == id);
    }
}