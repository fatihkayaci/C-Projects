namespace LibraryManagementSystem;

public class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? ISBN { get; set; }
    public bool IsAvailable { get; set; }

    public Book(string title, string author, string isbn, bool isAvailable = true)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        IsAvailable = isAvailable;
    }

    public Book()
    {
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Available: {(IsAvailable ? "Yes" : "No")}");
    }

    // public override string ToString()
    // {
    //     return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Available: {(IsAvailable ? "Yes" : "No")}";
    // }
}
