using ManyToMany.Model;

namespace ManyToMany.Interface
{
	public interface IStudentRepository
	{
		Student CreateStudent(Student student);	
		Student UpdateStudent(Student student);
		bool DeleteStudent(Student student);
		Student GetStudent(int id);
		IList<Student> GetStudents();
	}
}
