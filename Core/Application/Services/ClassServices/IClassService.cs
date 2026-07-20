using Domain.Entities;
namespace Application.Services.ClassServices
{
    public interface IClassService
    {
        public List<Classing> GetAllClasses();
        public void AddClass(Classing classesss);
    }
}