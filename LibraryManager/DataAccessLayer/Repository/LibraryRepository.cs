using System.Collections.Generic;
using BusinessObjects.Entity;


public class LibraryRepository
{
    private List<Library> Librarys;

    public LibraryRepository()
    {
        Librarys = new List<Library>();
    }

    public IEnumerable<Library> GetAll()
    {
        return Librarys;
    }

    public Library Get(int id)
    {
        return Librarys.Find(Library => Library.Id == id);
    }
}
