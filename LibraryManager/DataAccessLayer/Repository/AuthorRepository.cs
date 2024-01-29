using System.Collections.Generic;
using BusinessObjects.Entity;


public class AuthorRepository
{
    private List<Author> Authors;

    public AuthorRepository()
    {
        Authors = new List<Author>();
    }

    public IEnumerable<Author> GetAll()
    {
        return Authors;
    }

    public Author? Get(int id)
    {
        return Authors.Find(Author => Author.Id == id);
    }
}
