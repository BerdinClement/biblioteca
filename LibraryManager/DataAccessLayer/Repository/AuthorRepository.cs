using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repository;


public class AuthorRepository : IGenericRepository<Author>
{
    private readonly LibraryContext _libraryContext;

    public AuthorRepository(LibraryContext libraryContext)
    {
        _libraryContext = libraryContext;
    }

    public IEnumerable<Author> GetAll()
    {
        return _libraryContext.Authors.ToList();
    }

    public Author? Get(int id)
    {
        return _libraryContext.Authors.ToList().Find(author => author.Id == id);
    }
}
