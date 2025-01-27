using Microsoft.EntityFrameworkCore;
using UniversityManagementSystemMvc.Models;

namespace UniversityManagementSystemMvc.Data
{
    public class UniversityManagementSystemMvcContext : DbContext
    {
        public DbSet<Student> tblStudents { get; set; }
        public DbSet<Admin> tblAdmins { get; set; }
        public DbSet<Academician> tblAcademicians { get; set; }
        public DbSet<Course> tblCourses { get; set; }
        public DbSet<CourseRegistration> tblCourseRegistrations { get; set; }

        public UniversityManagementSystemMvcContext(DbContextOptions<UniversityManagementSystemMvcContext> options) 
        : base(options)
        {}
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseRegistration>()
                .HasKey(cr => new { cr.StudentId, cr.CourseId });

            modelBuilder.Entity<CourseRegistration>()
                .HasOne(cr => cr.Student)
                .WithMany(s => s.CourseRegistrations)
                .HasForeignKey(cr => cr.StudentId);

            modelBuilder.Entity<CourseRegistration>()
                .HasOne(cr => cr.Course)
                .WithMany(c => c.CourseRegistrations)
                .HasForeignKey(cr => cr.CourseId);
                
            base.OnModelCreating(modelBuilder);
        }
    }    
}