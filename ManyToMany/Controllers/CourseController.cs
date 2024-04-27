using System.Security.Cryptography.X509Certificates;
using ManyToMany.Context;
using ManyToMany.Model;
using Microsoft.AspNetCore.Mvc;

namespace ManyToMany.Controllers
{
	public class CourseController : Controller
	{
		private readonly ApplicationContext _context;
        public CourseController(ApplicationContext context)
        {
			_context = context;
        }

		[HttpPost("Create Book")]
		public IActionResult CreateCourse(Course course, Student student)
		{ 
			_context.Courses.Add(course);
			_context.Students.Add(student);
			var createCourseStud = new StudentCourse
			{
				CourseId = course.Id,
				StudentId = student.Id
			};
			_context.StudentCourses.Add(createCourseStud);
			_context.SaveChanges();
			return Ok("Book created");
		}

		[HttpPut("Update Book")]
		public IActionResult UpdateBook(Course course)
		{
			_context.Courses.Update(course);
			_context.SaveChanges();
			return Ok("Course updated");
		}

		[HttpGet("Get All Course")]
		public IActionResult GetAllCourse()
		{
			var getAllStudent = _context.Courses.ToList();
			return Ok(getAllStudent);
		}

		[HttpGet("Get by id")]
		public IActionResult GetCourseById(int Id)
		{
			var getCourseById = _context.Courses.Find(Id);
			return Ok(getCourseById);
		}

		[HttpDelete("Delete course")]
		public IActionResult DeleteCourse(int id)
		{
			var deleteCourse = _context.Courses.Find(id);
			_context.Courses.Remove(deleteCourse);
			_context.SaveChanges();
			return Ok("Course Removed");
		}
	}
}
