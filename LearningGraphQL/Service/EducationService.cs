using LearningGraphQL.IService;
using static LearningGraphQL.Models.Education;

namespace LearningGraphQL.Service
{
	public class EducationService : IEducationService
	{
		#region Fields

		private List<Student> Students = new List<Student>();
		private List<School> Schools = new List<School>();

		#endregion

		#region Constructor

		public EducationService()
		{
			InitializeStudents();
			InitializeSchools();
		}

		#endregion

		#region Initialization Methods

		private void InitializeStudents()
		{
			Students.AddRange(Enumerable.Range(1, 3).Select(i => new Student
			{
				StudentId = i,
				Name = "Bagas " + i,
				Age = 18 + i,
				Gender = "Male"
			}));
		}

		private void InitializeSchools()
		{
			Schools.AddRange(Students.Select((student, index) => new School
			{
				StudentId = student.StudentId,
				SchoolId = index + 1,
				Grade = "Junior " + (index + 1)
			}));
		}

		#endregion

		#region Public Methods

		public List<Student> GetStudents()
		{
			return Students;
		}

		public List<School> GetSchools()
		{
			return Schools;
		}

		public Student GetStudentByStudentId(int studentId)
		{
			var student = Students.FirstOrDefault(item => item.StudentId == studentId);
			var school = Schools.FirstOrDefault(item => item.StudentId == studentId);

			if (student != null)
			{
				return student;
			}
			else
			{
				// Mengembalikan nilai default jika siswa tidak ditemukan.
				return new Student { StudentId = 0, Name = "Siswa Tidak Ditemukan" };
			}
		}

		public School GetSchoolByStudentId(int studentId)
		{
			var student = Students.FirstOrDefault(item => item.StudentId == studentId);
			var school = Schools.FirstOrDefault(item => item.StudentId == studentId);

			if (school != null)
			{
				return school;
			}
			else
			{
				// Mengembalikan nilai default jika kelas tidak ditemukan.
				return new School { StudentId = 0, Grade = "Kelas Tidak Ditemukan" };
			}
		}

		#endregion
	}
}
