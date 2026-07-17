using Application.Interfaces;
using Domain.Entities;
namespace Application.Services.FacultyServices

{
    public class FacultyService:IFacultyService
    {
         private readonly IFaculty _faculty;
        public FacultyService(IFaculty faculties)
        {
            _faculty=faculties;
        }
        public List<Faculty> GetAllFaculty()
        {
           return _faculty.GetAllFaculty();
        }
    }
    
  
}