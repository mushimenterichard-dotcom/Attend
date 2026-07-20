using Domain.Entities;
namespace Application.Interfaces
{
    public interface IClasses
    {
        public List<Classing> GetAllClasses();
        public void AddClass(Classing classesss);
    }
}