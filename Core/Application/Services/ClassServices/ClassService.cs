using Application.Interfaces;
using Application.DTOs;
namespace Application.Services.ClassServices

{
    public class ClassService:IClassService
    {
         private readonly IClasses _classes;
        public ClassService(IClasses classess)
        {
            _classes=classess;
        }
        public async Task <List<GetClassDTO>> GetAllClassesAsync()
        {
           return await _classes.GetAllClassesAsync();
        }
        public async Task AddClassAsync(AddClassDTO classesss)
        {
            await _classes.AddClassAsync(classesss);
        }
        public async Task <GetClassDTO?> GetClassByIdAsync(int id)
        {
            return await _classes.GetClassByIdAsync(id);
        }
        public async Task UpdateClassAsync(UpdateClassDTO classesss)
        {
           await _classes.UpdateClassAsync(classesss);
        }
        public async Task DeleteClassAsync(DeleteClassDTO classesss)
        {
            await _classes.DeleteClassAsync(classesss);
        }
    }
    
}