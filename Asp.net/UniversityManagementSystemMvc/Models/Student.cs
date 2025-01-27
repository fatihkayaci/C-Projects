namespace UniversityManagementSystemMvc.Models;

public class Student : Person
{
    public uint Number { get; set; }
    public string Grade { get; set; }
    public string Department { get; set; }
    
    public ICollection<CourseRegistration> CourseRegistrations { get; set; }
}
