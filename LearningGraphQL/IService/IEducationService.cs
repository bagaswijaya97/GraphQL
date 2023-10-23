using LearningGraphQL.Models;
using static LearningGraphQL.Models.Education;

namespace LearningGraphQL.IService
{
	public interface IEducationService
	{
		List<Student> GetStudents();
		List<School> GetSchools();
		Student GetStudentByStudentId(int studentId);
		School GetSchoolByStudentId(int studentId);

	}
}
