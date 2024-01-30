namespace BusinessObjects.Entity;

public class Book
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Pages { get; set; }
    public BookTypes Type { get; set; }
    public int Rate { get; set; }
    // public Author? Author { get; set; }
    // public IEnumerable<Library>? Libraries { get; set; }
}