using Application.DTOs;
namespace Application.Services.ClassServices
{
    public interface IClassService
    {
        public List<GetClassDTO> GetAllClasses();
        public void AddClass(AddClassDTO classesss);
        public GetClassDTO? GetClassById(int id);
    }
}