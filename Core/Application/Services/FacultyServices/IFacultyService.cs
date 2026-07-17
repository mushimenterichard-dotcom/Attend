using Domain.Entities;
namespace Application.Services.FacultyServices
{
    public interface IFacultyService
    {
        public List<Faculty> GetAllFaculty();
    }
}