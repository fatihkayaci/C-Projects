using System;
using LibraryManagementSystem;

namespace LibrarySystem
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Book book = new Book();
            Library library = new Library();
            string? title;
            bool programExit = false;
            Console.WriteLine("Welcome to the library system.");
            do
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                Console.WriteLine("1. View all books \n2. Barrow a book \n3. Return a book \n4. Add a new book \n5. Exit");
                string? number = Console.ReadLine();
                Console.WriteLine($"Choose an option: {number}");
                bool cont = true;
                switch (number)
                {
                    case "1":
                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                        library.DisplayBooks();
                        break;
                    case "2":
                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                        Console.WriteLine("please you want enter title.");
                        do
                        {
                            title = Console.ReadLine();
                            if (title != null && book.IsAvailable)
                            {
                                library.BorrowBook(title);
                                cont = false;
                            }
                            else 
                                Console.WriteLine("I'm sorry try again!");    
                        } while (cont);
                        break;
                    case "3":
                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                        Console.WriteLine("please you want enter title.");
                        do
                        {
                            title = Console.ReadLine();
                            if (title != null && !book.IsAvailable)
                            {
                                library.ReturnBook(title);
                                cont = false;
                            }
                            else
                                Console.WriteLine("I'm sorry try again!");
                        } while (cont);
                        break;
                    case "4":
                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                        Console.WriteLine("Please enter book properties");
                        Console.WriteLine("Please enter title");
                        string? Title = Console.ReadLine();
                        Console.WriteLine("Please enter author");
                        string? Author = Console.ReadLine();
                        Console.WriteLine("Please enter ISBN");
                        string? ISBN = Console.ReadLine();
                        if (Title != null && Author != null && ISBN != null)
                        {
                            book = new Book(Title, Author, ISBN);
                            library.AddBook(book);
                        }
                        else
                            Console.WriteLine("please book properties don't empty");
                        break;
                    case "5":
                        Console.WriteLine("Thank you so much see you later.");
                        programExit = true;
                        break;
                    default:
                        Console.WriteLine("Please Menu Select number enter");
                        break;
                }
            } while (!programExit);
            
        }
    }
}