using BusinessObjects.Entity;
using Microsoft.EntityFrameworkCore;
using Library = Microsoft.Extensions.DependencyModel.Library;

namespace DataAccessLayer.Contexts;

public class LibraryContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    //public DbSet<Author> Authors { get; set; }

    public LibraryContext(DbContextOptions<LibraryContext> dbContextOptions) : base(dbContextOptions) {}
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().ToTable("book");
        // modelBuilder.Entity<Author>().ToTable("author");
    }
}