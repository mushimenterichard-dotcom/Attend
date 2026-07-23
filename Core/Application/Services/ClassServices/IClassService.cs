using Application.DTOs;
namespace Application.Services.ClassServices
{
    public interface IClassService
    {
        public Task <List<GetClassDTO>> GetAllClassesAsync();
        Task AddClassAsync(AddClassDTO classesss);
        Task <GetClassDTO?> GetClassByIdAsync(int id);
        Task UpdateClassAsync(UpdateClassDTO classesss);
        Task DeleteClassAsync(DeleteClassDTO classesss);
    }
}