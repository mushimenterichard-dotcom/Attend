using Application.Interfaces;
using Domain.Entities;
namespace Infrastructure.Repositories
{
    public class ClassesRepository : IClasses
    {
        public List<Classing> GetAllClasses()
        {
            return new List<Classing>
            {
            new Classing  { Id = 1 , Name = "College-level (AP / IB)" , InstructorName = "MELLISA uwase" , Code = 001},
            new Classing  { Id = 2 , Name = "Honors / Advanced" , InstructorName = "BIKORIMANA Louis" , Code = 002}

            };
        }
    }
}