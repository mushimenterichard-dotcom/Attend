using Application.Interfaces;
using Domain.Entities;
namespace Infrastructure.Repositories
{
    public class ClassStudentRepository : IClassStudent
    {
        public List<ClassStudent> GetAllClassStudent()

        {
            return new List<ClassStudent>
            {

            };
        }
    }
}