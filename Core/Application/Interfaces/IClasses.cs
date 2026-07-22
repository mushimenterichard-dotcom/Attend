using Application.DTOs;
namespace Application.Interfaces
{
    public interface IClasses
    {
        public List<GetClassDTO> GetAllClasses();
        public void AddClass(AddClassDTO classesss);
        public GetClassDTO? GetClassById(int id);
    }
}