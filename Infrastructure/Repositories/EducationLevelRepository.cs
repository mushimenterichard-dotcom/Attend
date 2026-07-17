using Application.Interfaces;
using Domain.Entities;
namespace Infrastructure.Repositories
{
    public class EducationLevelRepository : IEducationLevel
    {
        public List<EducationLevel> GetAllEducationLevel()

        {
            return new List<EducationLevel>
            {

            };
        }
    }
}