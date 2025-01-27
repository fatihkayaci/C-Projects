namespace UniversityManagementSystem;

class UniversityManagement : IUniversityManagement
{
    List<Person> person = new List<Person>();

    public void AddPerson(Person p)
    {
        person.Add(p);
    }

    public void ListPersons()
    {
        Console.WriteLine("Teachers; ");
        foreach (Person p in person)
            if (p is Teacher teacher)
                Console.WriteLine(teacher.ToString());
                
        Console.WriteLine("Students; ");
        foreach (Person s in person)
            if (s is Student student)
                Console.WriteLine(student.ToString());
    }
    public void ListTeachers()
    {        
        Console.WriteLine("Teachers; ");
        foreach (Person p in person)
            if (p is Teacher teacher)
                Console.WriteLine(teacher.ToString());
    }
    public void ListStudents()
    {
        Console.WriteLine("Students; ");
        foreach (Person s in person)
            if (s is Student student)
                Console.WriteLine(student.ToString());
    }
    public void RemovePerson(string id)
    {
        var personToRemove = person.FirstOrDefault(p => p.id == id);
        if (personToRemove != null)
        {
            person.Remove(personToRemove);
            Console.WriteLine($"Person with ID {id} has been removed.");
        }
        else
        {
            Console.WriteLine($"Person with ID {id} not found.");
        }
    }
    public int PersonCount()
    {
        return person.Count();
    }
}
