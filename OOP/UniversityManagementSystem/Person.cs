namespace UniversityManagementSystem;

abstract class Person
{
    public string? id { get; set; }
    public string? name { get; set; }
    public string? surname { get; set; }
    public string? email { get; set; }
    public Person(string? id, string? name, string? surname, string? email)
    {
        this.id = id;
        this.name = name;
        this.surname = surname;
        this.email = email;
    }
    public abstract void DisplayInfo();
    public override string ToString()
    {
        return $"{id} {name} {surname} ({email})";
    }
}
