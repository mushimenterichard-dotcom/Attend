using Application.Interfaces;
using Domain.Entities;
namespace Application.Services.EducationLevelServices

{
    public class EducationLevelService:IEducationLevelService
    {
         private readonly IEducationLevel _educationlevel;
        public EducationLevelService(IEducationLevel educationlevel)
        {
            _educationlevel=educationlevel;
        }
        public List<EducationLevel> GetAllEducationLevel()

        {
           return _educationlevel.GetAllEducationLevel();
        }
    }
    
  
}