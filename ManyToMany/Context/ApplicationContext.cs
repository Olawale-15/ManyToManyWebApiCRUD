using ManyToMany.Model;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany.Context
{
	public class ApplicationContext:DbContext
	{
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
