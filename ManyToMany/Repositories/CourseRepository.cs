using System.Net.Http.Headers;
using ManyToMany.Context;
using ManyToMany.Interface;
using ManyToMany.Model;

namespace ManyToMany.Repositories
{
	public class CourseRepository:ICourseRepository 
	{
		private readonly ApplicationContext _context;
        public CourseRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Course CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return course;
        }

        public Course UpdateCourse(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
            return course;
        }

        public bool DeleteCourse(Course course)
        {
            _context.Courses.Remove(course);
            _context.SaveChanges();
            return true;
        }

        public IList<Course> GetCourses()
        {
            var getStudent = _context.Courses.ToList();
            return getStudent;
        }

        public Course GetCourse(int id)
        {
            var getCourse = _context.Courses.Find(id);
            return getCourse;
        }
    }
}
