using System.IO;
string? textName;
Console.WriteLine("please write a text document name");
textName = Console.ReadLine();
if (string.IsNullOrWhiteSpace(textName))
    {
        Console.WriteLine("Document name cannot be empty.");
        return;
    }
StreamWriter stw = OpenTextFile(textName);
Console.WriteLine("Enter text (type 'exit' to stop):");
    while (true)
    {
        string? input = Console.ReadLine();
        if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
            break;

        if (!string.IsNullOrWhiteSpace(input))
        {
            WriteText(stw, input);
        }
        Console.WriteLine($"Text has been written to '{textName}.txt'.");
    }

StreamWriter OpenTextFile(string textName)
{
    return new StreamWriter($"C:/Users/pc/Desktop/C#portfoy/FileProcess/{textName}.txt");
}

void WriteText(StreamWriter textFile, string text)
{
    textFile.WriteLine(text);
}