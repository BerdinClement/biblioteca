using BusinessObjects.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Contexts;

public class LibraryContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Library> Libraries { get; set; }
    
    public LibraryContext(DbContextOptions<LibraryContext> dbContextOptions) : base(dbContextOptions) {}
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .ToTable("book")
            .HasOne<Author>(book => book.Author)
            .WithMany(author => author.Books)
            .HasForeignKey("id_author");
        modelBuilder.Entity<Book>()
            .ToTable("book")
            .HasMany<Library>(book => book.Libraries)
            .WithMany(library => library.Books)
            .UsingEntity(j => j.ToTable("stock"));
        modelBuilder.Entity<Author>()
            .ToTable("author")
            .HasMany<Book>(author => author.Books)
            .WithOne(book => book.Author)
            .HasForeignKey("id_author");
        modelBuilder.Entity<Library>()
            .ToTable("library")
            .HasMany<Book>(library => library.Books)
            .WithMany(book => book.Libraries)
            .UsingEntity(j => j.ToTable("stock"));
    }
}