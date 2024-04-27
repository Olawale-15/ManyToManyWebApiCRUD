using ManyToMany.ResponseModel;
using static ManyToMany.Dtos.StudentDto;

namespace ManyToMany.Interface
{
	public interface IStudentService
	{
		BaseResponse CreateStudent(RegisterStudent registerStudent);
		BaseResponse AddCourse(AddCourse course);
	}
}
