namespace LibraryManagementSystem;

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Added List");
    }
    public void BorrowBook(string title)
    {
        Book? bookToBorrow = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (bookToBorrow != null && bookToBorrow.IsAvailable)
        {
            bookToBorrow.IsAvailable = false;
            Console.WriteLine($"You have borrowed \"{bookToBorrow.Title}\".");
        }
        else if (bookToBorrow != null && !bookToBorrow.IsAvailable)
            Console.WriteLine($"The book \"{bookToBorrow.Title}\" is currently not available.");
        else
            Console.WriteLine("Sorry, we couldn't find that book.");
    }

    public void ReturnBook(string title)
    {
        Book? bookToBorrow = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (bookToBorrow != null && !bookToBorrow.IsAvailable)
        {
            bookToBorrow.IsAvailable = true;
            Console.WriteLine($"You have borrowed \"{bookToBorrow.Title}\".");
        }
        else if (bookToBorrow != null && !bookToBorrow.IsAvailable)
            Console.WriteLine($"The book \"{bookToBorrow.Title}\" is currently not available.");
        else
            Console.WriteLine("Sorry, we couldn't find that book.");

    }
    public void DisplayBooks()
    {
        Console.WriteLine("Books in the library");
        foreach (Book book in books)
        {
            book.DisplayInfo();
        }
    }
}
