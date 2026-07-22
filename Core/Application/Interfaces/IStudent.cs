using Application.DTOs;
using Domain.Entities;
namespace Application.Interfaces
{
    public interface IStudent
    {
        Task <List<GetStudentDTO>> GetAllStudentsAsync();
        Task AddStudentAsync(AddStudentDTO student);
        Task <GetStudentDTO?> GetStudentByIdAsync(int id);
        Task UpdateStudentAsync(UpdateStudentDTO student);
        Task DeleteStudentAsync(DeleteStudentDTO student);
    }
}