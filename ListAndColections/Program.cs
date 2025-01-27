using System.Collections;
using System.Collections.Generic;
Console.Clear();
List<string> stringList = new List<string>();

bool okey = true;
do
{
    Console.WriteLine("please enter name");
    string? name = Console.ReadLine();

    if (name != null)
        stringList.Add(name);
    else
        stringList.Add("");

    Console.WriteLine("please 'e' button press for in program exit");
    string? press = Console.ReadLine();
    if (press == "e")
    {
        Console.WriteLine("Exit program...");
        okey = false;
    }
} while (okey);

stringList.Sort();
foreach (string str in stringList)
{
    Console.WriteLine(str);
}