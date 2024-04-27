using ManyToMany.Context;
using ManyToMany.Interface;
using ManyToMany.Model;
using ManyToMany.ResponseModel;
using static ManyToMany.Dtos.StudentDto;

namespace ManyToMany.Services
{
	public class StudentService:IStudentService
	{
		private readonly IStudentRepository _studentRepository;
		private readonly ICourseRepository _courseRepository;
		private ApplicationContext _context;
        public StudentService(IStudentRepository studentRepository, ICourseRepository courseRepository, ApplicationContext context)
        {
			_studentRepository = studentRepository;
			_courseRepository = courseRepository;
			_context = context;
        }

	   public BaseResponse CreateStudent(RegisterStudent registerStudent)
		{
			var createStudent = new Student
			{
				FirstName = registerStudent.FirstName,
				LastName = registerStudent.LastName,
				Email = registerStudent.Email
			};
			_studentRepository.CreateStudent(createStudent);
			return new BaseResponse
			{
				Message = "Registration sucessful",
				Status = true
			};
		}

		public BaseResponse AddCourse(Course addCourse)
		{
			var addCours = new Course
			{
				CourseName = addCourse.CourseName,
				Department = addCourse.Department
			};
			 _courseRepository.CreateCourse(addCours);
			var getCourse = _courseRepository.GetCourse(addCourse.Id);
			var getStudent = new RegisterStudent();
			var addStudentCourse = new StudentCourse()
			{
				StudentId = getStudent.Id,
				CourseId = getCourse.Id,
			};
			_context.StudentCourses.Add(addStudentCourse);
			return new BaseResponse
			{
				Message = "Course Added",
				Status = true
			};

		}
    }
}
