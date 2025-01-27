
namespace UniversityManagementSystemMvc.Models;

public class Academician : Person
{
    #pragma warning disable CS0649
    public string Department { get; set; }
    public ICollection<Course> Courses { get; set; }
    #pragma warning restore CS0649
}
