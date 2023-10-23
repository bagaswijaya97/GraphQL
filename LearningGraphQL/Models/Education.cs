namespace LearningGraphQL.Models
{
	public class Education
	{
        public class Student {
			public int StudentId { get; set; }
			public string? Name { get; set; }
			public string? Gender { get; set; }
			public int? Age { get; set; }
			public School School { get; set; }

		}

		public class School
		{
			public int SchoolId { get; set; }
			public int StudentId { get; set; }
			public string? Grade { get; set; }
		}

       
    }
}
