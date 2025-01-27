namespace UniversityManagementSystem;

class Teacher : Person
{
    public string? Subject { get; set; }
    public decimal Salary { get; set; }
    public Teacher(string? id, string? name, string? surname, string? email, string? subject, decimal salary)
        : base(id, name, surname, email) // Base class constructor çağrısı
    {
        Subject = subject;
        Salary = salary;
    }
    public override void DisplayInfo()
    {
        throw new NotImplementedException();
    }
}
