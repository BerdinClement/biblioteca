namespace BusinessObjects.Entity;

public class Book
{
    private int Id { get; set; }
    private string? Name { get; set; }
    private int Pages { get; set; }
    private BookTypes Type { get; set; }
    private int Rate { get; set; }
    private Author? Author { get; set; }
    private Library? Library { get; set; }
}