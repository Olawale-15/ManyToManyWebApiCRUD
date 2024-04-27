using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ManyToMany.Model
{
	public class Student
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[MinLength(10, ErrorMessage ="Firstname can not less than 10"), MaxLength(40, ErrorMessage ="Firstname can not be more than 40")]
		public string FirstName { get; set; }
		[Required]
		[MinLength(10, ErrorMessage ="Lastname can not less than 10"), MaxLength(40, ErrorMessage ="Lastname can not be more than 40")]
		public string LastName { get; set; }
		[Required]
		public string Email { get; set; }
		public ICollection<StudentCourse> studentCourses { get; set; }
	}
}
