namespace BusinessObjects.Entity;

public class Library
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public IEnumerable<Book>? Books { get; set; }
}