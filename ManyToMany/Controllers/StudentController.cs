using ManyToMany.Context;
using ManyToMany.Interface;
using ManyToMany.Model;
using Microsoft.AspNetCore.Mvc;
using static ManyToMany.Dtos.StudentDto;

namespace ManyToMany.Controllers
{
	public class StudentController : Controller
	{
		private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
			_studentService = studentService;
        }

		[HttpPost("Register")]
		public IActionResult CreateStudent(RegisterStudent registerStudent)
		{
			var createStudent = _studentService.CreateStudent(registerStudent);
			return Ok(createStudent);
		}

		/*[HttpPut("Update")]
		public IActionResult UpdateStudent(Student student)
		{
			_context.Students.Update(student);
			_context.SaveChanges();
			return Ok("Student updated sucessfully");
		}

		[HttpGet("Get student by id")]
		public IActionResult GetStudent(int id)
		{
			var getStudent = _context.Students.Find(id);
			return Ok(getStudent);
		}

		[HttpGet("Get all student")]
		public IActionResult GetAll()
		{
			var getAllStudent = _context.Students.ToList();
			return Ok(getAllStudent);
		}

		[HttpDelete("Delete all student")]
		public IActionResult Delete(int id)
		{
			var getAllStud = _context.Students.Find(id);
			_context.Students.Remove(getAllStud);
			_context.SaveChanges();
			return Ok("Data deleted");
		}*/
	}
}
