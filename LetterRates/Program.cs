namespace LetterRates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        do
        {
            string? text = "";
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            Console.WriteLine("Please Enter Text");
            text = Console.ReadLine();
            if (text == "" || text == null)
            {
                Console.WriteLine("text not empty!");
                continue;
            }
            for (int i = 0; i < text.Count(); i++)
            {
                if(!dictionary.ContainsKey(text[i]))
                    dictionary.Add(text[i], 1);
                else
                    dictionary[text[i]]++;
            }
            foreach (var score in dictionary)
            {
                Console.WriteLine($"{score.Key}: {score.Value}");
            }
        } while (true);
    }
}
