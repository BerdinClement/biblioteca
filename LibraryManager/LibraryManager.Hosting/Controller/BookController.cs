using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace LibraryManager.Hosting.Controller;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
  private ICatalogService _catalogService;
  public BookController(ICatalogService catalogService)
  {
    _catalogService = catalogService;
  }
  [HttpGet]
  public IEnumerable<Book> GetAll()
  {
    return _catalogService.ShowCatalog();
  }
  
}