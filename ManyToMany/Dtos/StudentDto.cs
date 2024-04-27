namespace ManyToMany.Dtos
{
	public class StudentDto
	{
		public class RegisterStudent
		{
			public int Id { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }	
			public string Email { get; set;}
		}

		public class AddCourse
		{
			public int Id { get; set; }
			public string Coursename { get; set; }
			public string Department { get; set;}
		}

		
	}
}
