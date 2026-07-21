using Application.DTOs;
using Domain.Entities;
namespace Application.Interfaces
{
    public interface IStudent
    {
        public List<GetStudentDTO> GetAllStudents();
        public void AddStudent(AddStudentDTO student);
        public GetStudentDTO? GetStudentById(int id);
        public void UpdateStudent(UpdateStudentDTO student);
        public void DeleteStudent(DeleteStudentDTO student);
    }
}