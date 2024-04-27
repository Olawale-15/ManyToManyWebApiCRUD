using ManyToMany.Context;
using ManyToMany.Interface;
using ManyToMany.Model;

namespace ManyToMany.Repositories
{
	public class StudentRepository:IStudentRepository
	{
		private readonly ApplicationContext _context;
        public StudentRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Student CreateStudent(Student student) { _context.Students.Add(student); _context.SaveChanges(); return student; }
        public Student UpdateStudent(Student student) { _context.Students.Update(student); _context.SaveChanges(); return student; }
        public bool DeleteStudent(Student student) { _context.Students.Remove(student); _context.SaveChanges(); return true; }
        public Student GetStudent(int id) { var getStudent = _context.Students.Find(id); return getStudent; }
        public IList<Student> GetStudents() { var getStudent = _context.Students.ToList(); return getStudent; }

    }
}
