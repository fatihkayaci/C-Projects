Console.Clear();
string? prime;
string? press;
bool programContinue = true;
do
{
    Console.WriteLine("Pls Enter Number.");
    prime = Console.ReadLine();
    if (!int.TryParse(prime, out int number))
    {
        Console.WriteLine($"{prime} is not number.");
        return;
    }
    if (number == 2)
    {
        Console.WriteLine($"{number} is a prime number");
    }
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            Console.WriteLine($"{number} is not a prime number");
            break;
        }
        else
        {
            Console.WriteLine($"{number} is a prime number");
           
            break;
        }
    }
    int factoriyel = 1;
    for (int j = number; j > 1; j--)
    {
        factoriyel *= j;
    }
    Console.WriteLine($"{number}! = {factoriyel}");
    Console.WriteLine("Press 'e' to exit the program or any other key to continue.");
    press = Console.ReadLine();

    if (press?.ToLower() == "e")
    {
        Console.WriteLine("Program is exiting...");
        programContinue = false;
    }
} while (programContinue);
