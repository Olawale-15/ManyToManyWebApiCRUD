using ManyToMany.Model;

namespace ManyToMany.Interface
{
	public interface ICourseRepository
	{
	    Course CreateCourse(Course course);
		Course UpdateCourse(Course course);
		bool DeleteCourse(Course Course);
		Course GetCourse(int id);
		IList<Course> GetCourses();
	}
}
