namespace ToDoList;

class Program
{
    static List<string> tasks = new List<string>();
    static bool exit = false;
    static void Main(string[] args)
    {
        int menu;
        do
        {
            Console.WriteLine("Select Menu...");
            Console.WriteLine("1-) Get to List");
            Console.WriteLine("2-) Add To List");
            Console.WriteLine("3-) Delete To List");
            Console.WriteLine("4-) Exit The Program");
            menu = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------");
            switch (menu)
            {
                case 1:
                    GetList();
                    break;
                case 2:
                    AddList();
                    break;
                case 3:
                    DeleteList();
                    break;
                case 4:
                    ExitProgram();
                    break;
                default:
                    Console.WriteLine("Text");
                    break;
            }
        } while (!exit);
    }
    static void GetList()
    {
        int id = 1;
        if(tasks.Count == 0)
            Console.WriteLine("List Empty...");
        else
        {
            foreach (string task in tasks)
            {
                Console.WriteLine($"{id}-) {task}");
                id++;
            }
        }
        Console.WriteLine("---------------------------------------------------------------------------");
    }
    static void AddList()
    {
        Console.WriteLine("Enter Task");
        string? text = Console.ReadLine();
        if (text != null) 
            tasks.Add(text);
        Console.WriteLine("Added task...");
        Console.WriteLine("---------------------------------------------------------------------------");
    }
    static void DeleteList()
    {
        int number;
        Console.WriteLine("Number enter for delete");
        number = Convert.ToInt16(Console.ReadLine());
        if (number <= tasks.Count())
        {
            tasks.RemoveAt(number - 1);
            Console.WriteLine("Success for delete processing.");
        }
        else
            Console.WriteLine("Don't succes for delete");
            
        Console.WriteLine("---------------------------------------------------------------------------");
    }
    static void ExitProgram()
    {
        exit = true;
    }
}
