namespace BusinessObjects.Entity;

public class Library
{
    private int Id { get; set; }
    private string? Name { get; set; }
    private string? Address { get; set; }
    private IEnumerable<Book>? Books { get; set; }
}