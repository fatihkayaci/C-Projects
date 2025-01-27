namespace Fibonacci;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int[] numberArray;
        Console.WriteLine("Enter number...");
        number = Convert.ToInt16(Console.ReadLine());
        numberArray = new int[number];
        numberArray[0] = 1;
        numberArray[1] = 1;
        for (int i = 1; i < numberArray.Length - 1; i++)
        {
            numberArray[i + 1] = numberArray[i] + numberArray[i - 1];
        }
        foreach (int num in numberArray)
        {
            Console.Write(num + ", ");
        }
    }
}
