using System.ComponentModel.DataAnnotations;

namespace ManyToMany.Model
{
	public class Course
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string CourseName { get; set; }
		public string Department { get; set; }
		public ICollection<StudentCourse> StudentCourses { get; set; }
	}
}
