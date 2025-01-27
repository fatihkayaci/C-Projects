namespace UniversityManagementSystem;

class Student : Person
{
    public string? Department { get; set; }
    public string? Grade { get; set; }
    
    public Student(string? id, string? name, string? surname, string? email, string? department, string? grade)
        : base(id, name, surname, email)
    {
        Department = department;
        Grade = grade;
    }
    public override void DisplayInfo()
    {
        throw new NotImplementedException();
    }
    public override string ToString()
    {
        return $"{id} {surname} ({email})";
    }
}
