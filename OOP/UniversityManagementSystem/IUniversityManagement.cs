namespace UniversityManagementSystem;

interface IUniversityManagement
{
    public void AddPerson(Person p);
    public void RemovePerson(string id);
    public void ListPersons(); 
    public int PersonCount();
    public void ListTeachers();
    public void ListStudents();
}
