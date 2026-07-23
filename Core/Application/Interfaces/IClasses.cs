using Application.DTOs;
namespace Application.Interfaces
{
    public interface IClasses
    {
        Task <List<GetClassDTO>> GetAllClassesAsync();
        Task AddClassAsync(AddClassDTO classesss);
        Task <GetClassDTO?> GetClassByIdAsync(int id);
        Task UpdateClassAsync(UpdateClassDTO classesss);
        Task DeleteClassAsync(DeleteClassDTO classesss);
    }
}