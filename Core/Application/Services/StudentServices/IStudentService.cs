using Domain.Entities;
namespace Application.Services.StudentServices
{
    public interface IStudentService
    {
        // students= StudentService.GetAllStudents();
        public List<Student> GetAllStudents();
    }
}