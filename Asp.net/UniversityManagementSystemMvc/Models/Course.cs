using UniversityManagementSystemMvc.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int TeacherId { get; set; }
    public Academician Academician { get; set; }
    public ICollection<CourseRegistration> CourseRegistrations { get; set; }
}
