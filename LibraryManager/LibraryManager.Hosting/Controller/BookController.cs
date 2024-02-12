using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.Hosting.Controller;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
  private readonly LibraryManager _libraryManager = new LibraryManager();
  private readonly IGenericRepository<Book> _bookRepository = new BookRepository(_libraryManager);
  private readonly ICatalogManager _catalogManager = new CatalogManager(_bookRepository);
  
  public IEnumerable<Book> GetAll()
  {
    
  }
  
}