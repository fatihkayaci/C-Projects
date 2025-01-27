using System;

namespace UniversityManagementSystem
{
    class MainProgram
    {
        static void Main()
        {
            IUniversityManagement universityManagement = new UniversityManagement();
            string? choose;
            bool exitProgram = false;
            Console.WriteLine("===================================");
            Console.WriteLine("     UNIVERSITY MANAGEMENT SYSTEM");
            Console.WriteLine("===================================");
            do
            {                
                string? id = "", name = "", surname = "", email = "";
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Teacher");
                Console.WriteLine("3. Remove Person");
                Console.WriteLine("4. Display All Students");
                Console.WriteLine("5. Display All Teachers");
                Console.WriteLine("6. Display All Person");
                Console.WriteLine("7. Exit");
                choose = Console.ReadLine();
                Console.WriteLine($"Choose an option: {choose}");
                switch (choose)
                {
                    case "1":
                        // string id, string? name, string? surname, string? email, string? department, string? grade student
                        string? department , grade;
                        Console.WriteLine("Enter name...");
                        name = Console.ReadLine();

                        Console.WriteLine("Enter surname...");
                        surname = Console.ReadLine();

                        Console.WriteLine("Enter email...");
                        email = Console.ReadLine();

                        Console.WriteLine("Enter department...");
                        department = Console.ReadLine();
                        
                        Console.WriteLine("Enter grade...");
                        grade = Console.ReadLine();

                        if (department != null)
                            id = $"S{department[0]}{universityManagement.PersonCount()}";
                        universityManagement.AddPerson(new Student(id, name, surname, email, department, grade));
                        break;
                    case "2":
                        // string? id, string? name, string? surname, string? email, string? subject, decimal salary teacher
                        string? subject;
                        decimal salary;
                        Console.WriteLine("Enter name...");
                        name = Console.ReadLine();

                        Console.WriteLine("Enter surname...");
                        surname = Console.ReadLine();

                        Console.WriteLine("Enter email...");
                        email = Console.ReadLine();

                        Console.WriteLine("Enter department...");
                        subject = Console.ReadLine();
                        
                        Console.WriteLine("Enter grade...");
                        salary = Convert.ToDecimal(Console.ReadLine());

                        if (subject != null)
                            id = $"T{subject[0]}{universityManagement.PersonCount()}";
                        universityManagement.AddPerson(new Teacher(id, name, surname, email, subject, salary));

                        break;
                    case "3":
                        id = Console.ReadLine();
                        if (id != null)
                            universityManagement.RemovePerson(id);
                        break;
                    case "4":
                        universityManagement.ListStudents();
                        break;
                    case "5":
                        universityManagement.ListTeachers();
                        break;
                    case "6":
                        universityManagement.ListPersons();
                        break;
                    case "7":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("aa");
                        break;
                }
            } while (!exitProgram);
        }
    }
}