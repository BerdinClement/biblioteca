using BusinessObjects.Entity;
using DataAccessLayer.Repository;


public class AuthorRepository : IGenericRepository<Author>
{
    private List<Author> _authors ;

    public AuthorRepository()
    {
        _authors = new List<Author>();
    }
    
    public AuthorRepository(List<Author> authors)
    {
        _authors = authors;
    }

    public IEnumerable<Author> GetAll()
    {
        return _authors;
    }

    public Author? Get(int id)
    {
        return _authors.Find(author => author.Id == id);
    }
}
