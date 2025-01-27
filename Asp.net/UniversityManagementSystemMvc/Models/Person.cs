namespace UniversityManagementSystemMvc.Models;
public enum UserRole
{
    Admin,
    Academician,
    Student
}
public abstract class Person
{
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateOnly BirthDate { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public UserRole Role { get; set; }
   
}
