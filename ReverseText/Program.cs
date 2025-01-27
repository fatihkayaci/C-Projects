namespace ReverseText;

class Program
{
    static void Main(string[] args)
    {
        bool toContinue = true; 
        do
        {
            Console.WriteLine("Enter Text!");
            string? text = Console.ReadLine();
            if (text != null)
            {
                for (int i = text.Count() - 1; i >= 0; i--)
                {
                    Console.Write(text[i]);
                }
            }
            
            Console.WriteLine("\nPlease press enter to continue");
            ConsoleKeyInfo exit = Console.ReadKey();
            if (exit.Key != ConsoleKey.Enter)
                toContinue = false;
                
        } while (toContinue);   
    }
}
