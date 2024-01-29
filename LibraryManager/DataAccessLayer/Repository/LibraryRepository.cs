using System.Collections.Generic;
using BusinessObjects.Entity;


public class LibraryRepository
{
    private List<Library> _libraries;

    public LibraryRepository()
    {
        _libraries = new List<Library>();
    }
    
    public LibraryRepository(List<Library> libraries)
    {
        _libraries = libraries;
    }

    public IEnumerable<Library> GetAll()
    {
        return _libraries;
    }

    public Library? Get(int id)
    {
        return _libraries.Find(library => library.Id == id);
    }
}
