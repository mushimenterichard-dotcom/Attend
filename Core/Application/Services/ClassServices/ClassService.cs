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
        public List<GetClassDTO> GetAllClasses()
        {
           return _classes.GetAllClasses();
        }
        public void AddClass(AddClassDTO classesss)
        {
            _classes.AddClass(classesss);
        }
        public GetClassDTO? GetClassById(int id)
        {
            return _classes.GetClassById(id);
        }
        public void UpdateClass(UpdateClassDTO classesss)
        {
            _classes.UpdateClass(classesss);
        }
        public void DeleteClass(DeleteClassDTO classesss)
        {
            _classes.DeleteClass(classesss);
        }
    }
    
}